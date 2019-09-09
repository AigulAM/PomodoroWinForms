using System;
using System.Drawing;
using System.Windows.Forms;

namespace PomodorWinForm
{
    public partial class Pomodoro : Form
    {
        private CustomTime time;
        public Pomodoro()
        {
            InitializeComponent();
            RemainingTimeTextBox.Text = "Нажмите Старт, для запуска";
            time = new CustomTime();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RemainingTimeTextBox.Text = time.GetTime(out Color color).ToString();
            RemainingTimeTextBox.ForeColor = color;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            
            time.StartTime();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            RemainingTimeTextBox.Text = "Вы остановили программу";

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings formSettings = new Settings(time);
            formSettings.ShowDialog();

               
        }
    }
}
