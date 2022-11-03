namespace Program
{
    class App
    {
        public static void Main()
        {
            var book = new Book();

            BookProperty[] props = { new Title("Hary Potter"), new Author("J. K. Rolling"), new Content("It was on ...")};

            foreach (var property in props)
            {
                book.AddProperty(property);
            }
            
            book.Show();
        }
    }
}