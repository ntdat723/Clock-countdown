namespace Countdown
{
    partial class CountdownForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HourUpDown = new System.Windows.Forms.NumericUpDown();
            this.SecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.Colon1 = new System.Windows.Forms.Label();
            this.Colon2 = new System.Windows.Forms.Label();
            this.OnDisplay = new System.Windows.Forms.Label();
            this.countingDown = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HourUpDown
            // 
            this.HourUpDown.Location = new System.Drawing.Point(131, 49);
            this.HourUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HourUpDown.Name = "HourUpDown";
            this.HourUpDown.Size = new System.Drawing.Size(54, 20);
            this.HourUpDown.TabIndex = 0;
            // 
            // SecondUpDown
            // 
            this.SecondUpDown.Location = new System.Drawing.Point(297, 49);
            this.SecondUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecondUpDown.Name = "SecondUpDown";
            this.SecondUpDown.Size = new System.Drawing.Size(54, 20);
            this.SecondUpDown.TabIndex = 1;
            // 
            // MinuteUpDown
            // 
            this.MinuteUpDown.Location = new System.Drawing.Point(214, 49);
            this.MinuteUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinuteUpDown.Name = "MinuteUpDown";
            this.MinuteUpDown.Size = new System.Drawing.Size(54, 20);
            this.MinuteUpDown.TabIndex = 2;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(128, 33);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(30, 13);
            this.HourLabel.TabIndex = 3;
            this.HourLabel.Text = "Hour";
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(211, 33);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(39, 13);
            this.MinuteLabel.TabIndex = 4;
            this.MinuteLabel.Text = "Minute";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(294, 33);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(44, 13);
            this.SecondLabel.TabIndex = 5;
            this.SecondLabel.Text = "Second";
            // 
            // Colon1
            // 
            this.Colon1.Location = new System.Drawing.Point(195, 49);
            this.Colon1.Name = "Colon1";
            this.Colon1.Size = new System.Drawing.Size(10, 20);
            this.Colon1.TabIndex = 6;
            this.Colon1.Text = ":";
            this.Colon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Colon2
            // 
            this.Colon2.Location = new System.Drawing.Point(278, 49);
            this.Colon2.Name = "Colon2";
            this.Colon2.Size = new System.Drawing.Size(10, 20);
            this.Colon2.TabIndex = 7;
            this.Colon2.Text = ":";
            this.Colon2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OnDisplay
            // 
            this.OnDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OnDisplay.AutoSize = true;
            this.OnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnDisplay.Location = new System.Drawing.Point(104, 107);
            this.OnDisplay.Name = "OnDisplay";
            this.OnDisplay.Size = new System.Drawing.Size(410, 76);
            this.OnDisplay.TabIndex = 8;
            this.OnDisplay.Text = "TimeRemain";
            this.OnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countingDown
            // 
            this.countingDown.Interval = 1000;
            this.countingDown.Tick += new System.EventHandler(this.countingDown_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(198, 259);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 54);
            this.Start.TabIndex = 9;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(198, 259);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(90, 54);
            this.PauseButton.TabIndex = 10;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Visible = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(198, 259);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(90, 54);
            this.ResumeButton.TabIndex = 11;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Visible = false;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // CountdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 393);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.OnDisplay);
            this.Controls.Add(this.Colon2);
            this.Controls.Add(this.Colon1);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.MinuteUpDown);
            this.Controls.Add(this.SecondUpDown);
            this.Controls.Add(this.HourUpDown);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.ResumeButton);
            this.MaximizeBox = false;
            this.Name = "CountdownForm";
            this.Text = "18125126 Countdown";
            this.Load += new System.EventHandler(this.CountdownForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown HourUpDown;
        private System.Windows.Forms.NumericUpDown SecondUpDown;
        private System.Windows.Forms.NumericUpDown MinuteUpDown;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label Colon1;
        private System.Windows.Forms.Label Colon2;
        private System.Windows.Forms.Label OnDisplay;
        private System.Windows.Forms.Timer countingDown;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ResumeButton;
    }
}

