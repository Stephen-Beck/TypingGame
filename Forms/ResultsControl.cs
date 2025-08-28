using System.Configuration;
using System.Globalization;
using TypingGame.Core;
using TypingGame.DataModels;

namespace TypingGame.Forms
{
    public partial class ResultsControl : UserControl
    {
        LeaderboardHandler leaderboardHandler;
        GameSummary Summary { get; }
        GameConfig LastConfig { get; }
        public ResultsControl(GameSummary summary, GameConfig? config)
        {
            InitializeComponent();
            Summary = summary;
            LastConfig = config;
            leaderboardHandler = new(summary);
            DisplaySummary();
            lblLeaderboardType.Text = $"(Category: {summary.Category}, Blind Mode: {(summary.BlindMode ? "Enabled" : "Disabled")})";
            dgvLeaderboard.CellFormatting += dgvLeaderboard_CellFormatting;
            BindDataGridView();
        }

        private void dgvLeaderboard_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvLeaderboard.Columns[e.ColumnIndex].HeaderText == "Timestamp" && e.Value is DateTime dateTime)
            {
                //if (dateTime.Kind == DateTimeKind.Unspecified)
                //    dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);

                var local = dateTime.ToLocalTime(); // Adjust to player's local timezone
                e.Value = local.ToString("M/d/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                e.FormattingApplied = true;
            }
        }

        private void BindDataGridView()
        {
            leaderboardHandler.LoadFromJSON();
            dgvLeaderboard.DataSource = leaderboardHandler.Leaderboard.Entries;
        }

        private void DisplaySummary()
        {
            lblPlayerName.Text = Summary.PlayerName;
            lblCategory.Text = Summary.Category.ToString();
            lblBlindMode.Text = Summary.BlindMode ? "Enabled" : "Disabled";
            lblGameDuration.Text = Summary.GameDurationSeconds.ToString() + " seconds";
            lblTotalSubmissions.Text = Summary.TotalSubmissions.ToString();
            lblTotalChars.Text = Summary.TotalChars.ToString();
            lblTotalErrors.Text = Summary.TotalErrors.ToString();
            lblGrossWPM.Text = Summary.FinalGrossWPM.ToString("N0");
            lblAccuracy.Text = Summary.FinalAccuracy.ToString("P1");
            lblNetWPM.Text = Summary.FinalNetWPM.ToString("N0");
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfigMenu_Click(object sender, EventArgs e)
        {
            ExitToConfigMenuRequested?.Invoke(this, e);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgainRequest?.Invoke(this, LastConfig);
        }

        private void btnSaveToLeaderboard_Click(object sender, EventArgs e)
        {
            leaderboardHandler.AddEntry(Summary);
            BindDataGridView();
            btnSaveToLeaderboard.Enabled = false;
            btnSaveToLeaderboard.Text = "Saved to Leaderboard!";
        }

        public event EventHandler? ExitToConfigMenuRequested;
        public event EventHandler<GameConfig>? PlayAgainRequest;
    }
}
