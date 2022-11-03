namespace Program;

public class TypeDebugger: ValueDebugger
{
    internal override void WriteInDebug(string stringParam, int intParam)
    {
        var prevColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("String Parameter: " + stringParam.GetType());
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("String Parameter: " + intParam.GetType());
        
        Console.ForegroundColor = prevColor;
    }
}