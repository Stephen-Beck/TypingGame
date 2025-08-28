using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingGame.DataModels;
using TypingGame.Forms;

namespace TypingGame.Core
{
    public class ScreenManager
    {
        private Control Main { get; }
        public ScreenManager(Control panel)
        {
            Main = panel;
        }
        public void ShowConfig()
        {
            WPMConfigControl control = new();
            control.StartRequested += (sender, config) => StartGameplay(config);
            LoadUserControl(control);
        }

        public void StartGameplay(GameConfig config)
        {
            GameController gameController = new(config);
            gameController.InitializeRun();

            WPMGameplayControl control = new(gameController);
            control.RunEnded += (sender, summary) => ShowResults(summary,config);
            LoadUserControl(control);
        }

        public void ShowResults(GameSummary summary, GameConfig? config)
        {
            ResultsControl control = new(summary, config);
            control.ExitToConfigMenuRequested += (sender,e)=> ShowConfig();
            control.PlayAgainRequest += (sender, config) => StartGameplay(config);
            LoadUserControl(control);
        }

        public void LoadUserControl(UserControl control)
        {
            Main.Controls.Clear();
            control.Dock = DockStyle.Fill;
            Main.Controls.Add(control);
            Main.Focus();
        }
    }
}
