using System;
using System.IO;
using Modul2HW6.Configs;
using Modul2HW6.Models.Appliances.ComputingDevices;
using Modul2HW6.Models.Appliances.ComputingDevices.Stations;
using Modul2HW6.Models.Appliances.KitchenDevices.ShreddingDevices;
using Newtonsoft.Json;

namespace Modul2HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var starter = new AppStarter();
            starter.Run();
        }
    }
}
