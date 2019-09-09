namespace PomodorWinForm
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.BreakPeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WorkPeriodLabel = new System.Windows.Forms.Label();
            this.WorkPeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SetChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BreakPeriodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPeriodNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Длительность перерыва:";
            // 
            // BreakPeriodNumericUpDown
            // 
            this.BreakPeriodNumericUpDown.Location = new System.Drawing.Point(213, 46);
            this.BreakPeriodNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.BreakPeriodNumericUpDown.Name = "BreakPeriodNumericUpDown";
            this.BreakPeriodNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.BreakPeriodNumericUpDown.TabIndex = 9;
            this.BreakPeriodNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WorkPeriodLabel
            // 
            this.WorkPeriodLabel.AutoSize = true;
            this.WorkPeriodLabel.Location = new System.Drawing.Point(12, 20);
            this.WorkPeriodLabel.Name = "WorkPeriodLabel";
            this.WorkPeriodLabel.Size = new System.Drawing.Size(177, 13);
            this.WorkPeriodLabel.TabIndex = 8;
            this.WorkPeriodLabel.Text = "Длительность рабочего периода:";
            // 
            // WorkPeriodNumericUpDown
            // 
            this.WorkPeriodNumericUpDown.Location = new System.Drawing.Point(213, 20);
            this.WorkPeriodNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.WorkPeriodNumericUpDown.Name = "WorkPeriodNumericUpDown";
            this.WorkPeriodNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.WorkPeriodNumericUpDown.TabIndex = 7;
            this.WorkPeriodNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SetChangesButton
            // 
            this.SetChangesButton.Location = new System.Drawing.Point(75, 85);
            this.SetChangesButton.Name = "SetChangesButton";
            this.SetChangesButton.Size = new System.Drawing.Size(103, 33);
            this.SetChangesButton.TabIndex = 11;
            this.SetChangesButton.Text = "Применить";
            this.SetChangesButton.UseVisualStyleBackColor = true;
            this.SetChangesButton.Click += new System.EventHandler(this.SetChangesButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 130);
            this.Controls.Add(this.SetChangesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BreakPeriodNumericUpDown);
            this.Controls.Add(this.WorkPeriodLabel);
            this.Controls.Add(this.WorkPeriodNumericUpDown);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.BreakPeriodNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkPeriodNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BreakPeriodNumericUpDown;
        private System.Windows.Forms.Label WorkPeriodLabel;
        private System.Windows.Forms.NumericUpDown WorkPeriodNumericUpDown;
        private System.Windows.Forms.Button SetChangesButton;
    }
}