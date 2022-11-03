namespace Program;

public class Invoice
{
    private readonly int account;
    private readonly string customer;
    private readonly string provider;

    private string article;
    public string Article
    {
        set
        {
            if (value.Length == 0)
            {
                    return;
            }
            
            article = value;
        }
    }
    private int quantity = 0;
    
    public Invoice(int account, string customer, string provider)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
    }

    public void SetQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    public double GetPrice()
    {
        return this.account;
    }
    
    public double GetPriceWithTax()
    {
        return this.account * 1.15;
    }

    public double GetAmount(bool withTax)
    {
        if (withTax)
        {
            return quantity * GetPriceWithTax();
        }

        return quantity * GetPrice();
    }

    public void Print()
    {
        string[] lines =
            { $"${provider} Invoice for ${customer}", $"Price for ${article} {GetPrice()}", $"Price for {article} with tax {GetPriceWithTax()}", $"Amount for {quantity} of {article} is ${GetAmount(false)}", $"Amount for {quantity} of {article} with tax is ${GetAmount(true)}" };

        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }
}