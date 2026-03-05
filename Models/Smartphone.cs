namespace SAD_lab1.Models
{
    public class Smartphone : BatteryDevice
    {
        public Smartphone(string name, int batteryCapacity) : base(name, batteryCapacity)
        {
            IsSoftwareInstalled = true;
            IsConnectedToNetwork = true;
            IsExternalDevicesConnected = true;
        }

        public override void Use()
        {
            base.Use();
            RaiseDeviceStatusChanged($"{Name} is used for chatting, gaming, music, and video.");
        }
    }
}