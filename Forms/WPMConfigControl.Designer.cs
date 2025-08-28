namespace TypingGame
{
    partial class WPMConfigControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WPMConfigControl));
            CategoryDropDown = new ComboBox();
            label1 = new Label();
            checkboxBlindMode = new CheckBox();
            toolTipBlindMode = new ToolTip(components);
            btnStart = new Button();
            label2 = new Label();
            txtPlayerName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // CategoryDropDown
            // 
            CategoryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryDropDown.Font = new Font("Segoe UI", 14F);
            CategoryDropDown.FormattingEnabled = true;
            CategoryDropDown.Location = new Point(225, 526);
            CategoryDropDown.Name = "CategoryDropDown";
            CategoryDropDown.Size = new Size(150, 33);
            CategoryDropDown.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(127, 527);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "Category:";
            // 
            // checkboxBlindMode
            // 
            checkboxBlindMode.AutoSize = true;
            checkboxBlindMode.Font = new Font("Segoe UI", 14F);
            checkboxBlindMode.Location = new Point(174, 559);
            checkboxBlindMode.Name = "checkboxBlindMode";
            checkboxBlindMode.Size = new Size(154, 29);
            checkboxBlindMode.TabIndex = 2;
            checkboxBlindMode.Text = "Blind Mode [?]";
            toolTipBlindMode.SetToolTip(checkboxBlindMode, "Blind Mode hides all typed characters, preventing players from visually confirming their input.");
            checkboxBlindMode.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 22F);
            btnStart.Location = new Point(381, 526);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(493, 61);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(127, 491);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 4;
            label2.Text = "Player Name:";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Font = new Font("Segoe UI", 14F);
            txtPlayerName.Location = new Point(256, 488);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(618, 32);
            txtPlayerName.TabIndex = 0;
            txtPlayerName.TextChanged += txtPlayerName_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(127, 41);
            label3.Name = "label3";
            label3.Size = new Size(747, 179);
            label3.TabIndex = 5;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(128, 220);
            label4.Name = "label4";
            label4.Size = new Size(120, 32);
            label4.TabIndex = 6;
            label4.Text = "Gameplay";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(127, 37);
            label5.Name = "label5";
            label5.Size = new Size(291, 32);
            label5.TabIndex = 7;
            label5.Text = "Configuration Instructions";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(127, 228);
            label6.Name = "label6";
            label6.Size = new Size(747, 257);
            label6.TabIndex = 8;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F);
            label7.Location = new Point(376, 0);
            label7.Name = "label7";
            label7.Size = new Size(248, 45);
            label7.TabIndex = 9;
            label7.Text = "WPM Calculator";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(412, 302);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(29, 29);
            label8.TabIndex = 10;
            label8.Text = "ⓘ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            toolTipBlindMode.SetToolTip(label8, "WPM includes the [Enter] key used to submit each phrase.");
            // 
            // WPMConfigControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtPlayerName);
            Controls.Add(label2);
            Controls.Add(btnStart);
            Controls.Add(checkboxBlindMode);
            Controls.Add(label1);
            Controls.Add(CategoryDropDown);
            Name = "WPMConfigControl";
            Size = new Size(1000, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryDropDown;
        private Label label1;
        private CheckBox checkboxBlindMode;
        private ToolTip toolTipBlindMode;
        private Button btnStart;
        private Label label2;
        private TextBox txtPlayerName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
