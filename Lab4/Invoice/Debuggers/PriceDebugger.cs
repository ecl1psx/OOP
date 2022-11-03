using System.Diagnostics;

namespace Program.Debuggers;

public class PriceDebugger: InvoiceDebugger
{
    public PriceDebugger(string receiver, int price, DateTime date) : base(receiver, price, date){}
    
    public override void DebugValue()
    {
        Debug.WriteLine(_price.ToString());
    }
}