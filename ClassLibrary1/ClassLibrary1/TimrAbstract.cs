using System;
using System.Threading;
using System.Timers;

namespace ClassLibrary1
{
    public abstract class TimerAbstract
    {
        private Timer timer;

        public TimerAbstract(double interval)
        {
            timer = new Timer(interval);
            timer.Elapsed += TimerElapsed;
        }
        private void  TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Log();
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        public abstract void Log();


    }
}
