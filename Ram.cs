namespace Garage
{
    public class Ram : Vehicle, IGasVehicles
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            System.Console.WriteLine("this should completely refuel the gas tank");    // method definition omitted
        }

        public void CurrentTankPercentage()
        {
            System.Console.WriteLine("This should fuel up the vehicle to 100%");
        }
    }
}