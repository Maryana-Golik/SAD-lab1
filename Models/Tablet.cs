namespace SAD_lab1.Models
{
    public class Tablet : BatteryDevice
    {
        public Tablet(string name, int batteryCapacity) : base(name, batteryCapacity)
        {
            IsSoftwareInstalled = true; // Встановлене ПЗ за умовчанням
            IsConnectedToNetwork = true; // Підключення до мережі
            IsExternalDevicesConnected = true; // Підключені зовнішні пристрої
        }

        // Використання планшету
        public override void Use()
        {
            base.Use();
            RaiseDeviceStatusChanged($"{Name} is used for watching videos, browsing, and gaming.");
        }
    }
}