namespace TypingGame.Forms
{
    partial class ResultsControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblPlayerName = new Label();
            lblCategory = new Label();
            lblBlindMode = new Label();
            lblGameDuration = new Label();
            lblTotalSubmissions = new Label();
            lblTotalChars = new Label();
            lblTotalErrors = new Label();
            lblGrossWPM = new Label();
            lblAccuracy = new Label();
            lblNetWPM = new Label();
            dgvLeaderboard = new DataGridView();
            playerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finalNetWPMDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finalAccuracyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finalGrossWPMDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timestampDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            entriesBindingSource = new BindingSource(components);
            leaderboardBindingSource = new BindingSource(components);
            btnSaveToLeaderboard = new Button();
            btnExitApp = new Button();
            btnConfigMenu = new Button();
            btnPlayAgain = new Button();
            lblLeaderboardType = new Label();
            label11 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvLeaderboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entriesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leaderboardBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(59, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Player Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(85, 28);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(29, 56);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 2;
            label3.Text = "Blind Input Mode:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(42, 84);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 3;
            label4.Text = "Game Duration:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 112);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 4;
            label5.Text = "Total Submissions:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(38, 140);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 5;
            label6.Text = "Total Characters:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(70, 168);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 6;
            label7.Text = "Total Errors:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(66, 196);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 7;
            label8.Text = "Gross WPM:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(86, 224);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 8;
            label9.Text = "Accuracy:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(81, 252);
            label10.Name = "label10";
            label10.Size = new Size(80, 21);
            label10.TabIndex = 9;
            label10.Text = "Net WPM:";
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoEllipsis = true;
            lblPlayerName.AutoSize = true;
            lblPlayerName.Dock = DockStyle.Fill;
            lblPlayerName.Font = new Font("Segoe UI", 12F);
            lblPlayerName.Location = new Point(167, 0);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(158, 28);
            lblPlayerName.TabIndex = 10;
            lblPlayerName.Text = "label11";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.Location = new Point(167, 28);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(158, 28);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "label11";
            // 
            // lblBlindMode
            // 
            lblBlindMode.AutoSize = true;
            lblBlindMode.Dock = DockStyle.Fill;
            lblBlindMode.Font = new Font("Segoe UI", 12F);
            lblBlindMode.Location = new Point(167, 56);
            lblBlindMode.Name = "lblBlindMode";
            lblBlindMode.Size = new Size(158, 28);
            lblBlindMode.TabIndex = 12;
            lblBlindMode.Text = "label11";
            // 
            // lblGameDuration
            // 
            lblGameDuration.AutoSize = true;
            lblGameDuration.Dock = DockStyle.Fill;
            lblGameDuration.Font = new Font("Segoe UI", 12F);
            lblGameDuration.Location = new Point(167, 84);
            lblGameDuration.Name = "lblGameDuration";
            lblGameDuration.Size = new Size(158, 28);
            lblGameDuration.TabIndex = 13;
            lblGameDuration.Text = "label11";
            // 
            // lblTotalSubmissions
            // 
            lblTotalSubmissions.AutoSize = true;
            lblTotalSubmissions.Dock = DockStyle.Fill;
            lblTotalSubmissions.Font = new Font("Segoe UI", 12F);
            lblTotalSubmissions.Location = new Point(167, 112);
            lblTotalSubmissions.Name = "lblTotalSubmissions";
            lblTotalSubmissions.Size = new Size(158, 28);
            lblTotalSubmissions.TabIndex = 14;
            lblTotalSubmissions.Text = "label11";
            // 
            // lblTotalChars
            // 
            lblTotalChars.AutoSize = true;
            lblTotalChars.Dock = DockStyle.Fill;
            lblTotalChars.Font = new Font("Segoe UI", 12F);
            lblTotalChars.Location = new Point(167, 140);
            lblTotalChars.Name = "lblTotalChars";
            lblTotalChars.Size = new Size(158, 28);
            lblTotalChars.TabIndex = 15;
            lblTotalChars.Text = "label11";
            // 
            // lblTotalErrors
            // 
            lblTotalErrors.AutoSize = true;
            lblTotalErrors.Dock = DockStyle.Fill;
            lblTotalErrors.Font = new Font("Segoe UI", 12F);
            lblTotalErrors.Location = new Point(167, 168);
            lblTotalErrors.Name = "lblTotalErrors";
            lblTotalErrors.Size = new Size(158, 28);
            lblTotalErrors.TabIndex = 16;
            lblTotalErrors.Text = "label11";
            // 
            // lblGrossWPM
            // 
            lblGrossWPM.AutoSize = true;
            lblGrossWPM.Dock = DockStyle.Fill;
            lblGrossWPM.Font = new Font("Segoe UI", 12F);
            lblGrossWPM.Location = new Point(167, 196);
            lblGrossWPM.Name = "lblGrossWPM";
            lblGrossWPM.Size = new Size(158, 28);
            lblGrossWPM.TabIndex = 17;
            lblGrossWPM.Text = "label11";
            // 
            // lblAccuracy
            // 
            lblAccuracy.AutoSize = true;
            lblAccuracy.Dock = DockStyle.Fill;
            lblAccuracy.Font = new Font("Segoe UI", 12F);
            lblAccuracy.Location = new Point(167, 224);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new Size(158, 28);
            lblAccuracy.TabIndex = 18;
            lblAccuracy.Text = "label11";
            // 
            // lblNetWPM
            // 
            lblNetWPM.AutoSize = true;
            lblNetWPM.Dock = DockStyle.Fill;
            lblNetWPM.Font = new Font("Segoe UI", 12F);
            lblNetWPM.Location = new Point(167, 252);
            lblNetWPM.Name = "lblNetWPM";
            lblNetWPM.Size = new Size(158, 31);
            lblNetWPM.TabIndex = 19;
            lblNetWPM.Text = "label11";
            // 
            // dgvLeaderboard
            // 
            dgvLeaderboard.AllowUserToAddRows = false;
            dgvLeaderboard.AllowUserToDeleteRows = false;
            dgvLeaderboard.AllowUserToResizeRows = false;
            dgvLeaderboard.AutoGenerateColumns = false;
            dgvLeaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaderboard.Columns.AddRange(new DataGridViewColumn[] { playerNameDataGridViewTextBoxColumn, finalNetWPMDataGridViewTextBoxColumn, finalAccuracyDataGridViewTextBoxColumn, finalGrossWPMDataGridViewTextBoxColumn, timestampDataGridViewTextBoxColumn });
            dgvLeaderboard.DataSource = entriesBindingSource;
            dgvLeaderboard.Location = new Point(341, 87);
            dgvLeaderboard.MultiSelect = false;
            dgvLeaderboard.Name = "dgvLeaderboard";
            dgvLeaderboard.ReadOnly = true;
            dgvLeaderboard.RowHeadersVisible = false;
            dgvLeaderboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaderboard.Size = new Size(629, 487);
            dgvLeaderboard.TabIndex = 20;
            dgvLeaderboard.TabStop = false;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            playerNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            playerNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            playerNameDataGridViewTextBoxColumn.HeaderText = "Player Name";
            playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalNetWPMDataGridViewTextBoxColumn
            // 
            finalNetWPMDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            finalNetWPMDataGridViewTextBoxColumn.DataPropertyName = "FinalNetWPM";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            finalNetWPMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            finalNetWPMDataGridViewTextBoxColumn.HeaderText = "Net WPM";
            finalNetWPMDataGridViewTextBoxColumn.Name = "finalNetWPMDataGridViewTextBoxColumn";
            finalNetWPMDataGridViewTextBoxColumn.ReadOnly = true;
            finalNetWPMDataGridViewTextBoxColumn.Width = 83;
            // 
            // finalAccuracyDataGridViewTextBoxColumn
            // 
            finalAccuracyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            finalAccuracyDataGridViewTextBoxColumn.DataPropertyName = "FinalAccuracy";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "P1";
            finalAccuracyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            finalAccuracyDataGridViewTextBoxColumn.HeaderText = "Accuracy";
            finalAccuracyDataGridViewTextBoxColumn.Name = "finalAccuracyDataGridViewTextBoxColumn";
            finalAccuracyDataGridViewTextBoxColumn.ReadOnly = true;
            finalAccuracyDataGridViewTextBoxColumn.Width = 81;
            // 
            // finalGrossWPMDataGridViewTextBoxColumn
            // 
            finalGrossWPMDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            finalGrossWPMDataGridViewTextBoxColumn.DataPropertyName = "FinalGrossWPM";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            finalGrossWPMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            finalGrossWPMDataGridViewTextBoxColumn.HeaderText = "Gross WPM";
            finalGrossWPMDataGridViewTextBoxColumn.Name = "finalGrossWPMDataGridViewTextBoxColumn";
            finalGrossWPMDataGridViewTextBoxColumn.ReadOnly = true;
            finalGrossWPMDataGridViewTextBoxColumn.Width = 93;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            timestampDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "G";
            dataGridViewCellStyle5.NullValue = null;
            timestampDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            timestampDataGridViewTextBoxColumn.ReadOnly = true;
            timestampDataGridViewTextBoxColumn.Width = 92;
            // 
            // entriesBindingSource
            // 
            entriesBindingSource.DataMember = "Entries";
            entriesBindingSource.DataSource = leaderboardBindingSource;
            // 
            // leaderboardBindingSource
            // 
            leaderboardBindingSource.DataSource = typeof(DataModels.Leaderboard);
            // 
            // btnSaveToLeaderboard
            // 
            btnSaveToLeaderboard.Font = new Font("Segoe UI", 12F);
            btnSaveToLeaderboard.Location = new Point(42, 376);
            btnSaveToLeaderboard.Name = "btnSaveToLeaderboard";
            btnSaveToLeaderboard.Size = new Size(252, 36);
            btnSaveToLeaderboard.TabIndex = 21;
            btnSaveToLeaderboard.Text = "Save to Leaderboard?";
            btnSaveToLeaderboard.UseVisualStyleBackColor = true;
            btnSaveToLeaderboard.Click += btnSaveToLeaderboard_Click;
            // 
            // btnExitApp
            // 
            btnExitApp.Font = new Font("Segoe UI", 12F);
            btnExitApp.Location = new Point(42, 538);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(252, 36);
            btnExitApp.TabIndex = 22;
            btnExitApp.Text = "Exit Game";
            btnExitApp.UseVisualStyleBackColor = true;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // btnConfigMenu
            // 
            btnConfigMenu.Font = new Font("Segoe UI", 12F);
            btnConfigMenu.Location = new Point(42, 496);
            btnConfigMenu.Name = "btnConfigMenu";
            btnConfigMenu.Size = new Size(252, 36);
            btnConfigMenu.TabIndex = 23;
            btnConfigMenu.Text = "Back to Config Menu";
            btnConfigMenu.UseVisualStyleBackColor = true;
            btnConfigMenu.Click += btnConfigMenu_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Font = new Font("Segoe UI", 12F);
            btnPlayAgain.Location = new Point(42, 454);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(252, 36);
            btnPlayAgain.TabIndex = 24;
            btnPlayAgain.Text = "Play Again (Same Settings)";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // lblLeaderboardType
            // 
            lblLeaderboardType.Font = new Font("Segoe UI", 20F);
            lblLeaderboardType.Location = new Point(341, 23);
            lblLeaderboardType.Name = "lblLeaderboardType";
            lblLeaderboardType.Size = new Size(629, 61);
            lblLeaderboardType.TabIndex = 25;
            lblLeaderboardType.Text = "(Category: General, Blind Mode: Disabled)";
            lblLeaderboardType.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 26F);
            label11.Location = new Point(341, 4);
            label11.Name = "label11";
            label11.Size = new Size(629, 47);
            label11.TabIndex = 26;
            label11.Text = "Leaderboards";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(lblPlayerName, 1, 0);
            tableLayoutPanel1.Controls.Add(lblCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(lblBlindMode, 1, 2);
            tableLayoutPanel1.Controls.Add(lblGameDuration, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(lblNetWPM, 1, 9);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label10, 0, 9);
            tableLayoutPanel1.Controls.Add(lblAccuracy, 1, 8);
            tableLayoutPanel1.Controls.Add(lblTotalSubmissions, 1, 4);
            tableLayoutPanel1.Controls.Add(lblGrossWPM, 1, 7);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(lblTotalErrors, 1, 6);
            tableLayoutPanel1.Controls.Add(lblTotalChars, 1, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Location = new Point(7, 87);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(328, 283);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // ResultsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label11);
            Controls.Add(lblLeaderboardType);
            Controls.Add(btnPlayAgain);
            Controls.Add(btnConfigMenu);
            Controls.Add(btnExitApp);
            Controls.Add(btnSaveToLeaderboard);
            Controls.Add(dgvLeaderboard);
            Name = "ResultsControl";
            Size = new Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)dgvLeaderboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)entriesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)leaderboardBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblPlayerName;
        private Label lblCategory;
        private Label lblBlindMode;
        private Label lblGameDuration;
        private Label lblTotalSubmissions;
        private Label lblTotalChars;
        private Label lblTotalErrors;
        private Label lblGrossWPM;
        private Label lblAccuracy;
        private Label lblNetWPM;
        private DataGridView dgvLeaderboard;
        private Button btnSaveToLeaderboard;
        private Button btnExitApp;
        private Button btnConfigMenu;
        private Button btnPlayAgain;
        private Label lblLeaderboardType;
        private BindingSource entriesBindingSource;
        private BindingSource leaderboardBindingSource;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finalNetWPMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finalAccuracyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finalGrossWPMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
    }
}
