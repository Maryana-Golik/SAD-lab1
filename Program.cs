using System;
using SAD_lab1.Models;

namespace SAD_lab1
{
    class Program
    {
        static void Main()
        {

            var laptop = new Laptop("MacBook Air", 5000);
            var phone = new Smartphone("iPhone 15", 3000);
            var tablet = new Tablet("iPad Pro", 7000);


            EventHandler<DeviceEventArgs> handler = (object? sender, DeviceEventArgs e) => 
            {
                string timestamp = e.Timestamp.ToString("HH:mm:ss");
                Console.WriteLine("[" + timestamp + "] " + e.Message);
            };

            laptop.StatusChanged += handler;
            phone.StatusChanged += handler;
            tablet.StatusChanged += handler;


            laptop.IsSoftwareInstalled = true; laptop.IsConnectedToNetwork = true;
            phone.IsSoftwareInstalled = true; phone.IsConnectedToNetwork = true;
            tablet.IsSoftwareInstalled = true; tablet.IsConnectedToNetwork = true;

            Console.WriteLine("--- ТЕСТ ПРИСТРОЇВ (Варіант 5) ---");

            // Тест Ноутбука (Звичайний режим)
            laptop.TurnOn();
            laptop.SetUsageStrategy(new NormalUsageStrategy());
            laptop.ShowEstimatedTime();

            Console.WriteLine();

            // Тест Смартфона (Інтенсивний режим)
            phone.TurnOn();
            phone.SetUsageStrategy(new IntensiveUsageStrategy()); 
            phone.ShowEstimatedTime();

            Console.WriteLine();

            // Тест Планшета
            tablet.TurnOn();
            tablet.SetUsageStrategy(new NormalUsageStrategy());
            tablet.ShowEstimatedTime();

            Console.WriteLine("\nРоботу завершено. Натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}

