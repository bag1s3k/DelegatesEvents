namespace DelegatesEvents;

using System;
using System.Threading;

public class Timer {
    public event Action Tick;

    public void Start() {
        for (int i = 0; i < 5; i++) {
            Thread.Sleep(1000);
            Tick?.Invoke();
        }
    }
}

public class Program {
    
    static void Main() {
        Timer timer = new Timer();
        
        timer.Tick += TimerOnTick;
        timer.Start();

        void TimerOnTick() {
            Console.WriteLine("idk");
        }
    }
}