namespace SAD_lab1.Models
{
    public class BatteryDevice : Device
    {
        public int BatteryCapacity { get; set; }  

        public BatteryDevice(string name, int batteryCapacity) : base(name)
        {
            BatteryCapacity = batteryCapacity;
        }

        public void CheckBatteryStatus()
        {
            if (BatteryCapacity > 0)
            {
                RaiseDeviceStatusChanged($"Battery capacity: {BatteryCapacity}mAh.");
            }
            else
            {
                RaiseDeviceStatusChanged($"Battery is empty! Please recharge.");
                TurnOff();
            }
        }

        public void CalculateUsageTime(bool isIntensiveUse)
        {
            int hoursOfUse;
            if (isIntensiveUse)
            {
                hoursOfUse = (BatteryCapacity >= 5000) ? 4 : 16;
            }
            else
            {
                hoursOfUse = (BatteryCapacity >= 5000) ? 12 : 48;
            }

            RaiseDeviceStatusChanged($"The device will last for {hoursOfUse} hours of use.");
        }
    }
}
