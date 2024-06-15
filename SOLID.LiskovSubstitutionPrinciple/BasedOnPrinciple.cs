namespace SOLID.LiskovSubstitutionPrinciple;

public class BasedOnPrinciple
{
    public abstract class Vehicle
    {
        // Common vehicle behavior and properties.
    }
    public interface IEnginePowered
    {
        void StartEngine();
        void StopEngine();
    }
    public class Car : Vehicle, IEnginePowered
    {
        public void StartEngine()
        {
            Console.WriteLine("Starting the car engine.");
            // Code to start the car engine.
        }
        public void StopEngine()
        {
            Console.WriteLine("Stopping the car engine.");
            // Code to stop the car engine.
        }
    }
    public class ElectricCar : Vehicle
    {
        // Specific behavior for electric cars.
    }
}
