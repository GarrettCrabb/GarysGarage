using System;
namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }


        public void ChargeBattery()
        {
            Console.WriteLine("This should charge the vehicle to 100%");
        }

        public void CurrentChargePercentage()
        {
            Console.WriteLine("current 20% charge");
        }
    }
}