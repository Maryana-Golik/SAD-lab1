namespace SAD_lab1.Models
{
    public class Laptop : BatteryDevice
    {
        public Laptop(string name, int batteryCapacity) : base(name, batteryCapacity)
        {
            IsSoftwareInstalled = true;  // Встановлене ПЗ за умовчанням
            IsConnectedToNetwork = true;  // Підключення до мережі
            IsExternalDevicesConnected = true;  // Підключені зовнішні пристрої
        }

        public override void Use()
        {
            base.Use();
            RaiseDeviceStatusChanged($"{Name} is used for working, gaming, chatting, music, and video.");
        }
    }
}