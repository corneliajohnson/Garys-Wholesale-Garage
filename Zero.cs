using System;

namespace GarysWholeGarage
{
  public class Zero : Vehicle  // Electric motorcycle
  {
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
      // method definition omitted
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Zero drives past. RRrrrrrummbbble!");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The vehicle carefully turns {direction}");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Zero quickly come to a stop");
    }
  }
}