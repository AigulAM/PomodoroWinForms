using System;
using System.Windows.Forms;

namespace PomodorWinForm
{
    public partial class Settings : Form
    {
        private CustomTime _time;
        public Settings(CustomTime time)
        {
            InitializeComponent();
            _time = time;
        }

        private void SetChangesButton_Click(object sender, EventArgs e)
        {
            _time.BreakPeriod = Convert.ToInt32(BreakPeriodNumericUpDown.Value);
            _time.WorkPeriod = Convert.ToInt32(WorkPeriodNumericUpDown.Value);
            MessageBox.Show("Настройки успешно применены");
            this.Close();
        }
    }
}
