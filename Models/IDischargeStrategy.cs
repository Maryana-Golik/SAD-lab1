namespace SAD_lab1.Models
{

    public interface IDischargeStrategy
    {
        int CalculateHours(int capacity);
    }

    public class IntensiveUsageStrategy : IDischargeStrategy
    {
        public int CalculateHours(int capacity) => (capacity >= 5000) ? 4 : 16;
    }

    public class NormalUsageStrategy : IDischargeStrategy
    {
        public int CalculateHours(int capacity) => (capacity >= 5000) ? 12 : 48;
    }
}