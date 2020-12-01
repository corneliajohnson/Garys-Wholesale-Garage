namespace GarysWholeGarage
{
  public interface IElectricVehicle
  {
    void ChargeBattery();
    double BatteryKWh { get; set; }
    decimal CurrentChargePercentage { get; set; }
  }
}