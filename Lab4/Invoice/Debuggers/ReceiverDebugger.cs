using System.Diagnostics;

namespace Program.Debuggers;

public class ReceiverDebugger: InvoiceDebugger
{
    public ReceiverDebugger(string receiver, int price, DateTime date) : base(receiver, price, date){}
    
    public override void DebugValue()
    {
        Debug.WriteLine(_receiver);
    }
}