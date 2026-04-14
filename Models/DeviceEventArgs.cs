using System;

namespace SAD_lab1.Models
{

    public class DeviceEventArgs : EventArgs
    {
        public string Message { get; }
        public DateTime Timestamp { get; }

        public DeviceEventArgs(string message)
        {
            Message = message;
            Timestamp = DateTime.Now;
        }
    }
}