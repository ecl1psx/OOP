using System.Diagnostics;

namespace Program.Debuggers;

public class DateDebugger: InvoiceDebugger
{
    public DateDebugger(string receiver, int price, DateTime date) : base(receiver, price, date){}
    
    public override void DebugValue()
    {
        Debug.WriteLine(_date.ToLongTimeString());
    }
}