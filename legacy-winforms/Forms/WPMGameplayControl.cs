using TypingGame.Core;
using TypingGame.DataModels;

namespace TypingGame
{
    public partial class WPMGameplayControl : UserControl
    {
        bool correctInput = true;
        int countTimerSuccess = 0;
        GameController GameController { get; }
        public WPMGameplayControl(GameController gameController)
        {
            InitializeComponent();
            GameController = gameController;
            UpdateHUD();
            UpdateWords();
            lblPause.Visible = true;
            lblPause.Text = "Press any key to begin game!";

            if (GameController.Config.BlindMode) txtUserEntry.UseSystemPasswordChar = true;

            // Calculate the total number of ticks in a game based on `x` msec timer interval and `y` sec game duration
            // Set this value to progress bar Maximum property so it fills in smoothly over the entire game
            //progbarTimeRemaining.Maximum = (GameController.Config.GameDurationSeconds * 1000) / timer.Interval;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateHUD();
        }

        private bool _ending;
        private void UpdateHUD()
        {
            HUD hud = GameController.GetHUD();

            lblTimeRemaining.Text = hud.TimeRemaining.ToString("N1");
            lblWPM.Text = hud.GrossWPM.ToString("N0");
            lblAccuracy.Text = hud.AccuracyPercent.ToString("P1");
            progbarTimeRemaining.Value = Math.Min(progbarTimeRemaining.Maximum, (int)((1 - (hud.TimeRemaining / GameController.Config.GameDurationSeconds)) * 1000));

            // if gameTimer <= 0, end run and call results user control
            if (hud.TimeRemaining <= 0)
            {
                // Stop timer, set label to 0 and progress bar to max value for asthetics
                timer.Stop();
                lblTimeRemaining.Text = "0.0";
                progbarTimeRemaining.Value = progbarTimeRemaining.Maximum;

                // Clear user entry textbox and disable it
                txtUserEntry.Clear();
                txtUserEntry.Enabled = false;

                // Show results screen
                RunEnded?.Invoke(this, GameController.EndRun());
            }
        }

        private void UpdateWords()
        {
            IReadOnlyCollection<string> words = GameController.GetWordLabels();
            lblWord0.Text = words.ElementAt(0);
            lblWord1.Text = words.ElementAt(1);
            lblWord2.Text = words.ElementAt(2);
            lblWord3.Text = words.ElementAt(3);
            lblWord4.Text = words.ElementAt(4);
        }

        // Override to allow Ctrl+Shift+Backspace to clear textbox
        //      Using this instead of KeyDown or KeyPress event: The textbox was "eating" the Ctrl+Shift+Backspace combo
        //      by treating it as the Ctrl+Backspace shortcut before the KeyDown/KeyPress event was even passed
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (GameController.IsPaused)
            {
                Resume();
                if (keyData == Keys.Enter || keyData == Keys.Escape)
                    return true; // prevents Windows "ding"
            }
            else // not paused
            {
                switch (keyData)
                {
                    case Keys.Enter:
                        // Only submit if input is not blank or whitespace; prevents accidental blank submissions
                        if (txtUserEntry.Text.Trim() != "")
                            Submit();
                        return true;
                    case Keys.Escape:
                        Pause();
                        return true;
                    case (Keys.Control | Keys.Shift | Keys.Back):
                        txtUserEntry.Clear();
                        return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Pause()
        {
            GameController.Pause();
            lblPause.Visible = true;
            lblPause.Text = "Paused! Press any key to resume game.";
            timer.Stop();
        }

        private void Resume()
        {
            GameController.Resume();
            lblPause.Visible = false;
            timer.Start();
        }

        private void Submit()
        {
            correctInput = GameController.Submit(txtUserEntry.Text);

            if (correctInput) txtUserEntry.BackColor = Color.LightGreen;
            else txtUserEntry.BackColor = Color.LightCoral;

            timerSuccess.Start();
            txtUserEntry.Clear();
            UpdateWords();
        }

        private void txtUserEntry_Leave(object sender, EventArgs e)
        {
            txtUserEntry.Focus();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            txtUserEntry.Focus();
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.BeginInvoke((Action)(() => txtUserEntry.Focus()));
        }

        private void timerSuccess_Tick(object sender, EventArgs e)
        {
            //if (countTimerSuccess == 0)
            //{
            //    if (correctInput)
            //        txtUserEntry.BackColor = Color.LightGreen;
            //    else txtUserEntry.BackColor = Color.LightCoral;
            //    countTimerSuccess++;
            //}
            //else
            //{
            //    txtUserEntry.BackColor = Color.White;
            //    countTimerSuccess = 0;
            //    timerSuccess.Stop();
            //}
            txtUserEntry.BackColor = Color.White;
            timerSuccess.Stop();
        }

        public event EventHandler<GameSummary>? RunEnded; // Auto-trigger when run ends
    }
}
