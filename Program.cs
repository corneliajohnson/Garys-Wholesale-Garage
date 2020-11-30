using System;

namespace GarysWholeGarage
{
  class Program
  {
    static void Main(string[] args)
    {
      //Create an instance of each vehicle.
      //Define a different value for each vehicle's properties.
      var myCessna = new Cessna()
      {
        MainColor = "white",
        MaximumOccupancy = 24,
        FuelCapacity = 75.8
      };
      var myRam = new Ram()
      {
        MainColor = "gray",
        MaximumOccupancy = 5,
        FuelCapacity = 26.2
      };
      var myTesla = new Tesla()
      {
        MainColor = "red",
        MaximumOccupancy = 5,
        BatteryKWh = 12.5
      };
      var myZero = new Zero()
      {
        MainColor = "black",
        MaximumOccupancy = 2,
        BatteryKWh = 6.5
      };

      //Create a Drive() method in the Vehicle class.
      myCessna.Drive();
      myRam.Drive();
      myTesla.Drive();
      myZero.Drive();
    }
  }
}
