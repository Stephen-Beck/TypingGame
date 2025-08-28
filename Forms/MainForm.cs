using TypingGame.Core;

namespace TypingGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(1000, 600);
            ScreenManager screenManager = new(MainPanel);
            screenManager.ShowConfig();
        }

        public void LoadUserControl(UserControl control)
        {
            MainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(control);
            
        }
    }
}
