public interface IEngine
{
    void Run();
}

public class PetrolEngine : IEngine
{
    public void Run() => Console.WriteLine("Petrol engine is running...");
}

public class DieselEngine : IEngine
{
    public void Run() => Console.WriteLine("Diesel engine is running...");
}

public class Car
{
    private readonly IEngine _engine;

    public Car(IEngine engine) // ✅ Injecting Engine via Constructor
    {
        _engine = engine;
    }

    public void Start() => _engine.Run();
}

public class Program
{
    public static void Main()
    {
        var car = new Car(new DieselEngine());
        car.Start();  // Output: Petrol engine is running...
    }
}