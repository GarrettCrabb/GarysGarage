using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };
            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.CurrentChargePercentage();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.CurrentChargePercentage();
            }

            /***********************************************/

            Ram ram = new Ram();
            // Cessna cessna150 = new Cessna();

            List<IGasVehicles> gasVehicles = new List<IGasVehicles>()  {
                 ram
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicles gv in gasVehicles)
            {
                gv.CurrentTankPercentage();
            }

            foreach
            (IGasVehicles gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicles gv in gasVehicles)
            {
                gv.CurrentTankPercentage();
            }
        }
    }
}









// namespace Garage
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Zero fxs = new Zero();
//             Zero fx = new Zero();
//             Tesla modelS = new Tesla();
//             Cessna rrcc = new Cessna();


//             fxs.Drive();
//             modelS.Drive();
//             rrcc.Drive();

//         }
//     }
// }