namespace SAD_lab1.Models
{
    public class Smartphone : BatteryDevice
    {
        public Smartphone(string name, int capacity) : base(name, capacity) { }

        public void Chat() => Notify($"{Name} використовується для чату...");
    }
}