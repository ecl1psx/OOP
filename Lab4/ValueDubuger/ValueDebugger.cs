using System.Diagnostics;

namespace Program;

public class ValueDebugger
{
    virtual internal void WriteInDebug(string stringParam, int intParam)
    {
        Debug.WriteLine("String Parameter: " + stringParam);
        Debug.Write("Integer Parameter: "+ intParam);
    }
}