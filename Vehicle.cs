using System;

namespace GarysWholeGarage
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
      Console.WriteLine("Vrooom!");
    }

    public virtual void Turn(string direction)
    {
      Console.WriteLine($"The vehicle carfully turns {direction}");
    }

    public virtual void Stop()
    {
      Console.WriteLine("The vehicle gently Rolls to a stop");
    }
  }
}