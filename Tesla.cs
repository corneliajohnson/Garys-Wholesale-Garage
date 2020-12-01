using System;

namespace GarysWholeGarage
{
  public class Tesla : Vehicle, IElectricVehicle // Electric car
  {
    public double BatteryKWh { get; set; }

    public decimal CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
      CurrentChargePercentage = 1;
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Telsa lasers by. Mmmmmmmmmmmm!");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The vehicle make a {direction} turn");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Telsa come to a slow stop");
    }
  }
}