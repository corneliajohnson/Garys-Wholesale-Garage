using System;

namespace GarysWholeGarage
{
  public class Cessna : Vehicle  // Propellor light aircraft
  {
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
      // method definition omitted
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Cessna flys by. Zzzzooooooommm!");
    }
  }
}