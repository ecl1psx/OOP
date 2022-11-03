namespace Program;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type license key: ");
        var key = Console.ReadLine();
        
        var license = new ApplicationLicense(key);

        if (license.AccessLevel >= (int) ApplicationLicense.AccessLevels.Pro)
        {
            Console.WriteLine("Pro feature is available");
        }
        
        if (license.AccessLevel >= (int) ApplicationLicense.AccessLevels.Trial)
        {
            Console.WriteLine("Trial feature is available");
        }
        
        if (license.AccessLevel >= (int) ApplicationLicense.AccessLevels.Free)
        {
            Console.WriteLine("Free feature is available");
        }
    }
}

