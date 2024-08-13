using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class CheckTimer
    {
        private System.Threading.Timer _timer;
        private static CheckTimer? _instance;
        private static object _lock = new object();

        //public CheckTimer()
        //{
        //    _timer = new System.Threading.Timer(TimerEvent);
        //}

        public static CheckTimer GetInstance()
        {
            lock(_lock)
            {
                if (_instance == null)
                {
                    _instance = new CheckTimer();
                }
                return _instance;
            }
        }

        private CheckTimer()
        {
            _timer = new System.Threading.Timer(TimerEvent);
        }

        public void StartTimer()
        {
            _timer.Change(0, 3000);
        }

        private void TimerEvent(object? state)
        {
            //Console.WriteLine("TimerEvent():" + DateTime.Now); No message on Output Window
            Debug.WriteLine("TimerEvent():" + DateTime.Now);
        }
    }
}
