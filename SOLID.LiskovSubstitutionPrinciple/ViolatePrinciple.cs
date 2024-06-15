namespace SOLID.LiskovSubstitutionPrinciple;

/// <summary>
/// 
/// </summary>
public class ViolatePrinciple
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();
        public abstract void StopEngine();
    }
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting the car engine.");
            // Code to start the car engine
        }
        public override void StopEngine()
        {
            Console.WriteLine("Stopping the car engine.");
            // Code to stop the car engine
        }
    }
    public class ElectricCar : Vehicle
    {
        public override void StartEngine()
        {
            throw new InvalidOperationException("Electric cars do not have engines.");
        }
        public override void StopEngine()
        {
            throw new InvalidOperationException("Electric cars do not have engines.");
        }
    }
}
