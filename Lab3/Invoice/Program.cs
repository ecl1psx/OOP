namespace Program
{
    class App
    {
        public static void Main()
        {
            var invoice = new Invoice(50, "Lilia", "KFC");
            invoice.Article = "Chiken";
            invoice.SetQuantity(5);
            
            invoice.Print();
        }
    }
}