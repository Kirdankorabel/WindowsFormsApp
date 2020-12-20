using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.NewFolder1;

namespace WindowsFormsApp.src
{
    public class DriverManeger
    {
        public static bool RedyToWork { get; set; }

        public static Dictionary<int, string> drivers = new Dictionary<int, string>();
        public static string OS { get; set; }
        //public static List<Driver> drivers = new List<Driver>();
        public static List<Device> devices = new List<Device>();

        public static void InstallDriver(Driver driver, Device device)
        {
            if (device.CheckCompatibility(driver) == true)
            {
                device.Driver = driver;
            }
            //создание исключения
        }

        public static void DeleteDriver(Device device)
        {
            device.Driver = null;
        }

        public static bool CheckedReadyToWork ()
        {
            if (FindInDevices("motherboard") != null &&
                FindInDevices("processor") != null &&
                FindInDevices("video card") != null &&
                FindInDevices("RAM") != null &&
                FindInDevices("hard drive") != null &&
                FindInDevices("keyboard") != null)
            {
                if (FindInDevices("motherboard").ReadyToWork == true &&
                FindInDevices("processor").ReadyToWork == true &&
                FindInDevices("video card").ReadyToWork == true &&
                FindInDevices("RAM").ReadyToWork == true &&
                FindInDevices("hard drive").ReadyToWork == true &&
                FindInDevices("keyboard").ReadyToWork == true)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        private static Device FindInDevices (string type)
        {
            foreach (Device device in devices)
            {
                if (device.Type == type)
                {
                    return device;
                }
            }
            return null;
        }
    }
}
