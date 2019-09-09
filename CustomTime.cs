using System;
using System.Drawing;
using System.Media;

namespace PomodorWinForm
{
    public class CustomTime
    {
        private DateTime _time;
        private int _workPeriod;
        private int _breakPeriod;
        private Color _timeColor;
        public CustomTime(int workPeriod, int breakPeriod)
        {
            _workPeriod = workPeriod;
            _breakPeriod = breakPeriod;
        }
        public override string ToString()
        {
            var result = _time.ToString("HH:mm:ss");
            
            return base.ToString();
        }
        private DateTime _timeStart;
        private bool timeChange = false;

        private void CompateTimes(int period)
        {
            var result = DateTime.Compare(_timeStart.AddMinutes(period), DateTime.Now);
            if (result <= 0)
            {
                SoundAlarm(timeChange);
                timeChange = !timeChange;
                _timeStart = DateTime.Now;
            }
            else _time = DateTime.Now;
        }
        public DateTime GetTime(out Color _timeColor)
        {
            if (!timeChange)
            {
                CompateTimes(_workPeriod);
                _timeColor = Color.Black;
            }
            else
            {
                CompateTimes(_breakPeriod);
                _timeColor = Color.Red;
            }
            return _time;
        }
        public void StopTime()
        {
            _time = DateTime.MinValue;
        }
        public void StartTime()
        {
            _timeStart = DateTime.Now;
        }

        private void SoundAlarm(bool timeChange)
        {
            if (!timeChange) SystemSounds.Asterisk.Play();
            else SystemSounds.Beep.Play();
        }
    }
}
