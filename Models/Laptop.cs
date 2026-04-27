namespace SAD_lab1.Models
{
    public class Laptop : BatteryDevice
    {
        public Laptop(string name, int capacity) : base(name, capacity) { }
        
        public void PrintOnPrinter() => Notify($"{Name} друкує документ...");
    }
}