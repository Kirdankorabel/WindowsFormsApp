using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.NewFolder1;

namespace WindowsFormsApp
{
    public class Device
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Driver Driver { get; set; }
        public bool ReadyToWork { get; set; }

        public Device(string name, string type)
        {
            Name = name;
            Type = type;
            ReadyToWork = false;
        }
        public bool CheckCompatibility (Driver driver)
        {
            if (driver.Type == Type)
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            string s = $"{Type} {Name}";
            return s;
        }
    }
}
