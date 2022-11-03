namespace Program;

public class Book
{
    private List<BookProperty> properties = new List<BookProperty>();
    
    public void AddProperty(BookProperty property)
    {
        var index = properties.FindIndex(bookProperty => bookProperty.EqualName(property));
        
        if(index != -1)
        {
            properties.RemoveRange(index, 1);
        }
        
        properties.Add(property);
    }

    public void Show()
    {
        foreach (var property in properties)
        {
            property.Show();
        }
    }
}