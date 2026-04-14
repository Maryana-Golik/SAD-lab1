using System;

namespace SAD_lab1.Models
{
    public abstract class Device
    {
        public string Name { get; set; }
        public bool IsPowerOn { get; protected set; }
        public bool IsSoftwareInstalled { get; set; }
        public bool IsConnectedToNetwork { get; set; }


        public event EventHandler<DeviceEventArgs> StatusChanged;

        public Device(string name) => Name = name;

        protected void Notify(string message) 
            => StatusChanged?.Invoke(this, new DeviceEventArgs(message));

        public virtual void TurnOn()
        {
            if (IsSoftwareInstalled && IsConnectedToNetwork)
            {
                IsPowerOn = true;
                Notify($"{Name} увімкнено.");
            }
            else Notify($"Помилка: {Name} потребує ПЗ та мережі.");
        }

        public abstract void PerformAction(string action);
    }
}
