namespace Program;

public class Car
{
    public string Name;
    public Car(string name)
    {
        Name = name;
    }
    public ThreadStart Drive(Action onDone)
    {
        return () =>
        {
            Console.WriteLine($"{Name} I'm driving throw...");
            Thread.Sleep(1000 * Random.Shared.Next(1, 3));
            Console.WriteLine($"{Name} I'm away");
            
            onDone();
        };
    }
}