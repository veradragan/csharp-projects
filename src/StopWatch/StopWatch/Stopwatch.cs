using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Stopwatch
    {
        private DateTime _startTime;

        private DateTime _stopTime;
        public void Start()
        {
            _startTime = DateTime.Now;

        }

        public void Stop()
        {
            _stopTime = DateTime.Now;

        }

        public TimeSpan GetElapsedTime()
        {
            //var totalTime = _stopTime - _startTime;
            // return totalTime
            return _stopTime - _startTime;
        }
    }
}
