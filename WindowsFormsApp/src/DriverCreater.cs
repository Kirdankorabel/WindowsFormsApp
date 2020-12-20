using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.NewFolder1;

namespace WindowsFormsApp.src
{
    public class DriverCreater
    {
        public static string[] Types = { "Mouse", "MemoryCard", "CD/DVD",
                      "Monitor", "Printer", "Scanner", "LANСard", "motherboard", 
                      "processor", "video card", "RAM", "hard drive", "keyboard" };
        private static char[] letters = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();

        public static void CreateDrivers()
        {
            for (int i = 0; i < 9; i++)
            {
                System.Threading.Thread.Sleep(50);
                Random rnd = new Random();
                string type = Types[rnd.Next(Types.Length)];
                int numLetters = rnd.Next(3, 12);
                string name = "";
                for (int j = 1; j <= numLetters; j++)
                {
                    int letterNum = rnd.Next(0, letters.Length - 1);
                    name += letters[letterNum];
                }
                int versiom = rnd.Next(10, 5000);
                string os = DriverManeger.OS;
                Driver driver = new Driver(name, type, versiom, os);
                DriverManeger.drivers.Add(driver.Version, driver.Name);
            }
        }
    }
}
