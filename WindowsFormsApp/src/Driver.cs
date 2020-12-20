using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.NewFolder1
{
    public class Driver
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Version { get; set; }
        public string OS { get; set; }

        public Driver(string name, string type, int version, string os)
        {
            Name = name;
            Type = type;
            Version = version;
            OS = os;
        }

        public bool CheckCompatibility(Device device )
        {
            if (device.Type == Type)
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            string s = $"{Type} {Name} {Version}";
            return s;
        }

        public static bool operator !=(Driver driver1, Driver driver2)
        {
            if (driver1.Type == driver2.Type 
                && driver1.Version == driver2.Version 
                && driver1.OS == driver2.OS)
            {
                return false;
            }
            else return true;
        }

        public static bool operator ==(Driver driver1, Driver driver2)
        {
            if (driver1.Type == driver2.Type
                && driver1.Version == driver2.Version
                && driver1.OS == driver2.OS)
            {
                return true;
            }
            else return false;
        }
    }
}
