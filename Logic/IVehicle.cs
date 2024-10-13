
namespace Logic
{
    public interface IVehicle
    {
        string GetImagePath();
    }
}

namespace Logic
{
    public class Car : IVehicle
    {
        public string GetImagePath()
        {
            return "car";
        }
    }
}

namespace Logic
{
    public class Bus : IVehicle
    {
        public string GetImagePath()
        {
            return "bus";
        }
    }
}

namespace Logic
{
    public class FireTruck : IVehicle
    {
        public string GetImagePath()
        {
            return "firetruck";
        }
    }
}
namespace Logic
{
    public class Taxi : IVehicle
    {
        public string GetImagePath()
        {
            return "taxi";
        }
    }
}
