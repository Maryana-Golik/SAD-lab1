namespace SAD_lab1.Models
{
    public abstract class Device
    {
        public string Name { get; set; }
        public bool IsPowerOn { get; set; }
        public bool IsSoftwareInstalled { get; set; }
        public bool IsConnectedToNetwork { get; set; }
        public bool IsExternalDevicesConnected { get; set; }

        // Подія для сповіщення про зміни стану пристрою
        public event Action<string> OnDeviceStatusChanged = delegate { };

        // Конструктор для ініціалізації значень
        public Device(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null");
            OnDeviceStatusChanged = delegate { }; // Ініціалізація події
        }

        // Метод для включення пристрою
        public virtual void TurnOn()
        {
            if (IsSoftwareInstalled && IsConnectedToNetwork && IsExternalDevicesConnected)
            {
                IsPowerOn = true;
                RaiseDeviceStatusChanged($"{Name} is now ON (No power required).");
            }
            else
            {
                RaiseDeviceStatusChanged($"Cannot turn on {Name}. Check the software, network connection, and external devices.");
            }
        }

        // Метод для вимкнення пристрою
        public virtual void TurnOff()
        {
            IsPowerOn = false;
            RaiseDeviceStatusChanged($"{Name} is now OFF.");
        }

        // Метод для використання пристрою
        public virtual void Use()
        {
            if (IsPowerOn)
            {
                RaiseDeviceStatusChanged($"{Name} is in use.");
            }
            else
            {
                RaiseDeviceStatusChanged($"{Name} cannot be used. It is powered off.");
            }
        }

        // Метод для виклику події зміни статусу
        protected void RaiseDeviceStatusChanged(string message)
        {
            OnDeviceStatusChanged?.Invoke(message);
        }
    }
}
