﻿using System;
using System.Collections.Generic;

namespace GarysWholeGarage
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
        Console.WriteLine($"{ev.CurrentChargePercentage * 100}%");
      }

      foreach (IElectricVehicle ev in electricVehicles)
      {
        // This should charge the vehicle to 100%
        ev.ChargeBattery();
      }

      foreach (IElectricVehicle ev in electricVehicles)
      {
        Console.WriteLine($"{ev.CurrentChargePercentage * 100}%");
      }

      // /***********************************************/

      // Ram ram = new Ram();
      // Cessna cessna150 = new Cessna();

      // List <???> gasVehicles = new List<???> () {
      //   ram, cessna150
      //       };

      // Console.WriteLine("Gas Vehicles");
      // foreach (??? gv in gasVehicles)
      // {
      //   Console.WriteLine($"{gv.CurrentTankPercentage}");
      // }

      // foreach (??? gv in gasVehicles)
      // {
      //   // This should completely refuel the gas tank
      //   gv.RefuelTank();
      // }

      // foreach (??? gv in gasVehicles)
      // {
      //   Console.WriteLine($"{gv.CurrentTankPercentage}");
      // }
    }
  }
}
