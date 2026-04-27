namespace SAD_lab1.Models
{
    public class Tablet : BatteryDevice
    {
        public Tablet(string name, int capacity) : base(name, capacity) { }

        public void WatchVideo() => Notify($"{Name} відтворює відео у високій якості...");
    }
}