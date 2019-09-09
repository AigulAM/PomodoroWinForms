namespace PomodorWinForm
{
    partial class Pomodoro
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
            this.RemainingTimeTextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.WorkPeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WorkPeriodLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BreakPeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPeriodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakPeriodNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RemainingTimeTextBox
            // 
            this.RemainingTimeTextBox.Location = new System.Drawing.Point(12, 12);
            this.RemainingTimeTextBox.Name = "RemainingTimeTextBox";
            this.RemainingTimeTextBox.Size = new System.Drawing.Size(242, 20);
            this.RemainingTimeTextBox.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 102);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(115, 33);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Старт/Рестарт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(139, 102);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(115, 32);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // WorkPeriodNumericUpDown
            // 
            this.WorkPeriodNumericUpDown.Location = new System.Drawing.Point(217, 46);
            this.WorkPeriodNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.WorkPeriodNumericUpDown.Name = "WorkPeriodNumericUpDown";
            this.WorkPeriodNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.WorkPeriodNumericUpDown.TabIndex = 3;
            this.WorkPeriodNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WorkPeriodLabel
            // 
            this.WorkPeriodLabel.AutoSize = true;
            this.WorkPeriodLabel.Location = new System.Drawing.Point(16, 46);
            this.WorkPeriodLabel.Name = "WorkPeriodLabel";
            this.WorkPeriodLabel.Size = new System.Drawing.Size(177, 13);
            this.WorkPeriodLabel.TabIndex = 4;
            this.WorkPeriodLabel.Text = "Длительность рабочего периода:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Длительность перерыва:";
            // 
            // BreakPeriodNumericUpDown
            // 
            this.BreakPeriodNumericUpDown.Location = new System.Drawing.Point(217, 72);
            this.BreakPeriodNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.BreakPeriodNumericUpDown.Name = "BreakPeriodNumericUpDown";
            this.BreakPeriodNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.BreakPeriodNumericUpDown.TabIndex = 5;
            this.BreakPeriodNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BreakPeriodNumericUpDown);
            this.Controls.Add(this.WorkPeriodLabel);
            this.Controls.Add(this.WorkPeriodNumericUpDown);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.RemainingTimeTextBox);
            this.MaximizeBox = false;
            this.Name = "Pomodoro";
            this.Text = "Pomedoro";
            ((System.ComponentModel.ISupportInitialize)(this.WorkPeriodNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakPeriodNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RemainingTimeTextBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.NumericUpDown WorkPeriodNumericUpDown;
        private System.Windows.Forms.Label WorkPeriodLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BreakPeriodNumericUpDown;
    }
}

