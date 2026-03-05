using SAD_lab1.Models;

namespace SAD_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення пристроїв з необхідними параметрами
            var laptop = new Laptop("Laptop", 5000);
            var smartphone = new Smartphone("Smartphone", 3000);  // Передаємо параметри
            var tablet = new Tablet("Tablet", 7000);  // Передаємо параметри

            // Підписка на події для пристроїв
            laptop.OnDeviceStatusChanged += (message) => Console.WriteLine(message);
            smartphone.OnDeviceStatusChanged += (message) => Console.WriteLine(message);
            tablet.OnDeviceStatusChanged += (message) => Console.WriteLine(message);

            // Перевірка запуску пристроїв
            laptop.TurnOn();
            smartphone.TurnOn();
            tablet.TurnOn();
            laptop.Use();
            smartphone.Use();
            tablet.Use();
            laptop.TurnOff();
            smartphone.TurnOff();
            tablet.TurnOff();
        }
    }
}

