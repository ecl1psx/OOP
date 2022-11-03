namespace Program;

public class ApplicationLicense
{
    public enum AccessLevels: int
    {
        Free = 1,
        Trial = 2,
        Pro = 3
    }
    
    private string? _key;
    private Nullable<int> _accessLevel;

    public int AccessLevel
    {
        get
        {
            var accessLevel = _accessLevel;
                
            if (!accessLevel.HasValue)
            {
                accessLevel = _accessLevel = ReadKey();
            }
            
            return (int) accessLevel;
        }
    }
    
    public ApplicationLicense(string? key)
    {
        _key = key;
    }

    private int ReadKey()
    {
        switch (_key)
        {
            case "pro":
                return (int) AccessLevels.Pro;
            case "trial":
                return (int) AccessLevels.Trial;
            default:
                return (int)AccessLevels.Free;
        }
    }

    public void PrintLicense()
    {
        switch (AccessLevel)
        {
            case (int) AccessLevels.Free:
                Console.WriteLine("Free version");
                break;
            case (int) AccessLevels.Trial:
                Console.WriteLine("Trial version");
                break;
            case (int) AccessLevels.Pro:
                Console.WriteLine("Pro version");
                break;
        }
    }
}