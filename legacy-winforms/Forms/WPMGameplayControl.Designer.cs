namespace TypingGame
{
    partial class WPMGameplayControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblWord0 = new Label();
            lblWord1 = new Label();
            lblWord2 = new Label();
            lblWord3 = new Label();
            lblWord4 = new Label();
            txtUserEntry = new TextBox();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTimeRemaining = new Label();
            lblWPM = new Label();
            lblAccuracy = new Label();
            label4 = new Label();
            lblPause = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            progbarTimeRemaining = new ProgressBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            timerSuccess = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblWord0
            // 
            lblWord0.Font = new Font("Segoe UI", 33F);
            lblWord0.ForeColor = Color.Black;
            lblWord0.Location = new Point(34, 312);
            lblWord0.Name = "lblWord0";
            lblWord0.Size = new Size(932, 60);
            lblWord0.TabIndex = 0;
            lblWord0.Text = "Word";
            lblWord0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWord1
            // 
            lblWord1.Font = new Font("Segoe UI", 27F);
            lblWord1.ForeColor = Color.Gray;
            lblWord1.Location = new Point(34, 261);
            lblWord1.Name = "lblWord1";
            lblWord1.Size = new Size(932, 51);
            lblWord1.TabIndex = 1;
            lblWord1.Text = "Word";
            lblWord1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWord2
            // 
            lblWord2.Font = new Font("Segoe UI", 22F);
            lblWord2.ForeColor = Color.Silver;
            lblWord2.Location = new Point(34, 218);
            lblWord2.Name = "lblWord2";
            lblWord2.Size = new Size(932, 41);
            lblWord2.TabIndex = 2;
            lblWord2.Text = "Word";
            lblWord2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWord3
            // 
            lblWord3.Font = new Font("Segoe UI", 18F);
            lblWord3.ForeColor = Color.FromArgb(224, 224, 224);
            lblWord3.Location = new Point(34, 179);
            lblWord3.Name = "lblWord3";
            lblWord3.Size = new Size(932, 32);
            lblWord3.TabIndex = 3;
            lblWord3.Text = "Word";
            lblWord3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWord4
            // 
            lblWord4.CausesValidation = false;
            lblWord4.Font = new Font("Segoe UI", 14F);
            lblWord4.ForeColor = Color.FromArgb(224, 224, 224);
            lblWord4.Location = new Point(34, 146);
            lblWord4.Name = "lblWord4";
            lblWord4.Size = new Size(932, 25);
            lblWord4.TabIndex = 4;
            lblWord4.Text = "Word";
            lblWord4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserEntry
            // 
            txtUserEntry.BackColor = Color.White;
            txtUserEntry.Font = new Font("Segoe UI", 20F);
            txtUserEntry.Location = new Point(190, 384);
            txtUserEntry.Name = "txtUserEntry";
            txtUserEntry.Size = new Size(620, 43);
            txtUserEntry.TabIndex = 0;
            txtUserEntry.Leave += txtUserEntry_Leave;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 26F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 50);
            label1.TabIndex = 6;
            label1.Text = "Time Remaining";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 26F);
            label2.Location = new Point(290, 0);
            label2.Name = "label2";
            label2.Size = new Size(281, 50);
            label2.TabIndex = 7;
            label2.Text = "WPM";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 26F);
            label3.Location = new Point(577, 0);
            label3.Name = "label3";
            label3.Size = new Size(283, 50);
            label3.TabIndex = 8;
            label3.Text = "Accuracy";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTimeRemaining
            // 
            lblTimeRemaining.BorderStyle = BorderStyle.FixedSingle;
            lblTimeRemaining.Dock = DockStyle.Fill;
            lblTimeRemaining.Font = new Font("Segoe UI", 26F);
            lblTimeRemaining.Location = new Point(3, 50);
            lblTimeRemaining.Name = "lblTimeRemaining";
            lblTimeRemaining.Size = new Size(281, 50);
            lblTimeRemaining.TabIndex = 9;
            lblTimeRemaining.Text = "label4";
            lblTimeRemaining.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblWPM
            // 
            lblWPM.BorderStyle = BorderStyle.FixedSingle;
            lblWPM.Dock = DockStyle.Fill;
            lblWPM.Font = new Font("Segoe UI", 26F);
            lblWPM.Location = new Point(290, 50);
            lblWPM.Name = "lblWPM";
            lblWPM.Size = new Size(281, 50);
            lblWPM.TabIndex = 10;
            lblWPM.Text = "label5";
            lblWPM.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAccuracy
            // 
            lblAccuracy.BorderStyle = BorderStyle.FixedSingle;
            lblAccuracy.Dock = DockStyle.Fill;
            lblAccuracy.Font = new Font("Segoe UI", 26F);
            lblAccuracy.Location = new Point(577, 50);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new Size(283, 50);
            lblAccuracy.TabIndex = 11;
            lblAccuracy.Text = "label6";
            lblAccuracy.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(187, 3);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 12;
            label4.Text = "[Esc]: Pause";
            // 
            // lblPause
            // 
            lblPause.BackColor = Color.Transparent;
            lblPause.Font = new Font("Segoe UI", 16F);
            lblPause.Location = new Point(190, 459);
            lblPause.Name = "lblPause";
            lblPause.Size = new Size(620, 33);
            lblPause.TabIndex = 13;
            lblPause.Text = "Paused! Press any key to resume game.";
            lblPause.TextAlign = ContentAlignment.TopCenter;
            lblPause.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(119, 39);
            label5.Name = "label5";
            label5.Size = new Size(258, 30);
            label5.TabIndex = 14;
            label5.Text = "[Backspace]: Delete letter";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(592, 3);
            label6.Name = "label6";
            label6.Size = new Size(306, 30);
            label6.TabIndex = 15;
            label6.Text = "[Ctrl+Backspace]: Delete word";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(578, 39);
            label7.Name = "label7";
            label7.Size = new Size(335, 30);
            label7.TabIndex = 16;
            label7.Text = "[Ctrl+Shift+Backspace]: Delete all";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label7, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 511);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(994, 72);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // progbarTimeRemaining
            // 
            progbarTimeRemaining.Location = new Point(190, 433);
            progbarTimeRemaining.Maximum = 1000;
            progbarTimeRemaining.Name = "progbarTimeRemaining";
            progbarTimeRemaining.Size = new Size(620, 23);
            progbarTimeRemaining.Step = 1;
            progbarTimeRemaining.Style = ProgressBarStyle.Continuous;
            progbarTimeRemaining.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(lblTimeRemaining, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(lblWPM, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(lblAccuracy, 2, 1);
            tableLayoutPanel2.Location = new Point(69, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(863, 100);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // timerSuccess
            // 
            timerSuccess.Tick += timerSuccess_Tick;
            // 
            // WPMGameplayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lblPause);
            Controls.Add(progbarTimeRemaining);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtUserEntry);
            Controls.Add(lblWord4);
            Controls.Add(lblWord3);
            Controls.Add(lblWord2);
            Controls.Add(lblWord1);
            Controls.Add(lblWord0);
            Name = "WPMGameplayControl";
            Size = new Size(1000, 600);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserEntry;
        private System.Windows.Forms.Timer timer;
        private Label lblWord0;
        private Label lblWord1;
        private Label lblWord2;
        private Label lblWord3;
        private Label lblWord4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTimeRemaining;
        private Label lblWPM;
        private Label lblAccuracy;
        private Label label4;
        private Label lblPause;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar progbarTimeRemaining;
        private TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timerSuccess;
    }
}
