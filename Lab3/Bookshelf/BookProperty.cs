namespace Program;

public abstract class BookProperty
{
    public readonly string Name;
    protected string value;
    protected ConsoleColor color;

    public BookProperty(string value, string name, ConsoleColor color)
    {
        this.value = value;
        this.Name = name;
        this.color = color;
    }
    
    public void Show()
    {
        var prevColor = Console.BackgroundColor;
        Console.BackgroundColor = this.color;
        
        Console.WriteLine($"{Name} is {value}");

        Console.BackgroundColor = prevColor;
    }

    public bool EqualName(BookProperty property)
    {
        return Name == property.Name;
    }
}