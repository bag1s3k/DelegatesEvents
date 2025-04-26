namespace DelegatesEvents;

using System;
using System.Threading;

public class Timer {
    public delegate void TickHandler(int second);
    
    public event TickHandler Tick;

    public void Start() {
        for (int i = 0; i < 5; i++) {
            Thread.Sleep(1000);
            Tick?.Invoke(i);
        }
    }
}

public class Program {
    
    static void Main() {
        Timer timer = new Timer();
        
        timer.Tick += TimerOnTick;
        timer.Start();

        void TimerOnTick(int second) {
            if (second % 2 == 0)
                Console.WriteLine("suda");
            else
                Console.WriteLine("licha");
        }
    }
}