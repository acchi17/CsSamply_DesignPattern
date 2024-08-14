using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public static class WarningTimer
    {
        private static System.Threading.Timer _timer;
        private static bool _isWarning = false;

        public static event Action<bool> NotifyWarning;

        static WarningTimer()
        {
            _timer = new System.Threading.Timer(TimerEvent);
        }

        public static bool IsWarning
        {
            get { return _isWarning; }
            private set
            {
                if (_isWarning != value)
                {
                    _isWarning = value;
                    NotifyWarning?.Invoke(_isWarning);
                }
            }
        }

        public static void StartTimer()
        {
            _timer.Change(0, 3000);
        }

        private static void TimerEvent(object? state)
        {
            string[] lines = System.IO.File.ReadAllLines("warning.txt");
            if (lines.Length > 0)
            {
                IsWarning = (lines[0] == "1");
            }
            else
            {
                IsWarning = false;
            }
        }
    }
}
