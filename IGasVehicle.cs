namespace GarysWholeGarage
{
  public interface IGasVehicle
  {
    double FuelCapacity { get; set; }
    void RefuelTank();
    decimal CurrentTankPercentage { get; set; }
  }
}