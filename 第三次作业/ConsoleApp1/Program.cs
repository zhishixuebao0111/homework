using System;
using System.Threading;
using System.Timers;

namespace AlarmClockDemo
{
    // 自定义事件参数
    public class TickEventArgs : EventArgs
    {
        public DateTime CurrentTime { get; set; }
    }

    public class AlarmEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

    // 闹钟类
    public class AlarmClock
    {
        // 定义事件
        public event EventHandler<TickEventArgs> Tick;
        public event EventHandler<AlarmEventArgs> Alarm;

        private System.Timers.Timer timer;
        private DateTime alarmTime;
        private bool isAlarmSet = false;

        public AlarmClock()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimerElapsed;
        }

        // 设置闹钟时间
        public void SetAlarm(DateTime time)
        {
            alarmTime = time;
            isAlarmSet = true;
            Console.WriteLine("闹钟已设置为: "+alarmTime);
        }

        // 启动闹钟
        public void Start()
        {
            timer.Start();
            Console.WriteLine("闹钟已启动...\n");
        }

        // 停止闹钟
        public void Stop()
        {
            timer.Stop();
            Console.WriteLine("闹钟已停止");
        }


        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;


            OnTick(new TickEventArgs { CurrentTime = now });

    
            if (isAlarmSet && now >= alarmTime)
            {
                OnAlarm(new AlarmEventArgs { Message = "叮铃铃！闹钟响了！" });
                isAlarmSet = false; 
            }
        }

    
        protected virtual void OnTick(TickEventArgs e)
        {
            Tick?.Invoke(this, e);
        }

        // 触发Alarm事件
        protected virtual void OnAlarm(AlarmEventArgs e)
        {
            Alarm?.Invoke(this, e);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock();
            clock.Tick += (sender, e) =>
            {
                Console.WriteLine(e.CurrentTime);
            };

            clock.Alarm += (sender, e) =>
            {
                Console.WriteLine(e.Message);
                Console.Beep(1000, 500);
            };

            DateTime alarmTime = DateTime.Now.AddSeconds(10);
            clock.SetAlarm(alarmTime);

            clock.Start();

            Console.WriteLine("按任意键停止闹钟...");
            Console.ReadKey();
            clock.Stop();
        }
    }
}