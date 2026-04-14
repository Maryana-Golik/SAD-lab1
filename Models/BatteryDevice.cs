namespace SAD_lab1.Models
{
    public class BatteryDevice : Device
    {
        public int BatteryCapacity { get; set; }
        private IDischargeStrategy _dischargeStrategy;

        public BatteryDevice(string name, int capacity) : base(name)
        {
            BatteryCapacity = capacity;
            _dischargeStrategy = new NormalUsageStrategy(); 
        }

        public void SetUsageStrategy(IDischargeStrategy strategy) 
            => _dischargeStrategy = strategy;

        public void ShowEstimatedTime()
        {
            int hours = _dischargeStrategy.CalculateHours(BatteryCapacity);
            Notify($"Орієнтовний час роботи: {hours} год.");
        }

        public override void PerformAction(string action)
        {
            if (!IsPowerOn) { Notify("Пристрій вимкнено."); return; }
            Notify($"Виконується дія: {action}");
        }
    }
}
