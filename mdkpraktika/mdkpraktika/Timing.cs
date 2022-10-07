using System;
using System.Diagnostics;

namespace mdkpraktika {
    internal class Timing {
        TimeSpan duration;
        TimeSpan[] threads;

        public Timing() {
            duration = new TimeSpan(0);
            threads = new TimeSpan[Process.GetCurrentProcess().Threads.Count];
        }

        public void StartTime() {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            for (int i = 0; i < threads.Length; i++)
                threads[i] = Process.GetCurrentProcess().Threads[i].UserProcessorTime;
        }

        public void StopTime() {
            TimeSpan tmp;
            for(int i = 0; i < threads.Length; i++) {
                tmp = Process.GetCurrentProcess().Threads[i].UserProcessorTime.Subtract(threads[i]);
                if (tmp > TimeSpan.Zero)
                    duration = tmp;
            }
        }

        public TimeSpan Result() {
            return duration;
        }
    }
}
