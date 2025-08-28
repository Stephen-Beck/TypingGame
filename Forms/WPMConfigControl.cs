using TypingGame.DataModels;

namespace TypingGame
{
    public partial class WPMConfigControl : UserControl
    {
        //int gameDurationSeconds = 60; // variable in case I decide to make this selectable in the future
        public WPMConfigControl()
        {
            InitializeComponent();
            CategoryDropDown.DataSource = Enum.GetValues(typeof(Category));
            btnStart.Enabled = false;
            btnStart.Text = "Please input a player name";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"You are about to start a game with these settings:\n" +
                $"\n\tPlayer Name: {txtPlayerName.Text.Trim()}" +
                $"\n\tCategory: {CategoryDropDown.SelectedValue}" +
                $"\n\tBlind Mode: {(checkboxBlindMode.Checked ? "Enabled" : "Disabled")}" +
                $"\n\nStart game?", "Confirm Settings", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            // Build GameConfig
            GameConfig config = new(
                PlayerName: txtPlayerName.Text.Trim(),
                Category: (Category)CategoryDropDown.SelectedValue,
                BlindMode: (checkboxBlindMode.Checked));

            StartRequested?.Invoke(this, config);
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerName.Text.Trim() == "")
            {
                btnStart.Enabled = false;
                btnStart.Text = "Please input a player name before starting the game";
            }
            else
            {
                btnStart.Enabled = true;
                btnStart.Text = "Start";
            }
        }

        // Override to allow Enter to press btnStart as User Controls do not have an AcceptButton property
        //      A KeyPress or KeyDown event could do this as well, but I implement this solution after finding out the method
        //      to get Ctrl+Shift+Backspace working in WPMGameplayControl. This prevents the annoying Windows "ding" sound.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnStart.PerformClick();
                return true; // Prevent annoying "ding"
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public event EventHandler<GameConfig>? StartRequested;
    }
}
