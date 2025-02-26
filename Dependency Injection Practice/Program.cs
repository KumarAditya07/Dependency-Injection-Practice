/*public interface IEngine
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
}*/


// we have created seprate  Services for above classes 
/*public class Car
{
    private readonly IEngine _engine;

    public Car(IEngine engine) // ✅ Injecting Engine via Constructor
    {
        _engine = engine;
    }

    public void Start() => _engine.Run();
}*/

// created seprated car class for above class



using Dependency_Injection_Practice;
using Dependency_Injection_Practice.Services;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main()
    {
        // Create a DI Container
        var serviceProvider = new ServiceCollection()
            .AddTransient<IEngine, PetrolEngine>()
             .AddTransient<Car>().
            BuildServiceProvider();

        //  Resolve Car instance from DI
        var car = serviceProvider.GetRequiredService<Car>();

        //  Start the Car
        car.Run();
    }
}