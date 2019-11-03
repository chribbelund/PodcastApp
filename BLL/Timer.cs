using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BLL
{
    class Timer
    {
        private static System.Timers.Timer aTimer;

        public static ElapsedEventHandler OnTimedEvent { get; private set; }

        public static void Main()
        {
            SetTimer();

            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();

        }

        private static void SetTimer()
        {
            // Create a timer with a twenty second interval.
            aTimer = new System.Timers.Timer(20000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private async void InitializeTimer()
        {
            await WaitAndExecute(2000, () =>
            {
                var viewmodel = new BandInfoRepository();
                listView.ItemsSource = viewmodel.BandInfo;
            });
        }
        private async Task WaitAndExecute(int milisec, Action actionToExecute)
        {
            await Task.Delay(milisec);
            actionToExecute();
        }

        static async Task DoStuffOnTimer()
        {
            using (var timer = new TaskTimer(1000).Start())
            {
                foreach (var task in timer)
                {
                    await task;
                    DoStuff();
                }
            }
        }
    }
}
