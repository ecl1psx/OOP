namespace Program;

class Program
{
    static void Main()
    {
        var coffeeMachine = new CoffeeMachine();

        var coffee1 = coffeeMachine.CookCoffee(new Milk(), new Syrup());

        var coffee2 = coffeeMachine.CookCoffee(new Sugar(), new Syrup(), new Milk());
        
        Console.WriteLine(coffee1);
        Console.WriteLine(coffee2);
    }
}