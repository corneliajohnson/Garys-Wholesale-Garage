using System;

namespace GarysWholeGarage
{
  public class Ram : Vehicle // Gas powered truck
  {
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
      // method definition omitted
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Ram races past. Yeeeeeeoooowww");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The vehicle squeals around the {direction} turn");
    }

    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Ram decends to a stop");
    }
  }
}
