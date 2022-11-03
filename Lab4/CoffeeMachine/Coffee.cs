namespace Program;

public class Coffee
{
    private CoffeeIngredient[] _ingredients;
    public CoffeeIngredient[] Ingredients
    {
        get
        {
            return _ingredients;
        }
    }

    public int Price
    {
        get
        {
            var totalPrice = 0;

            foreach (var ingredient in _ingredients)
            {
                totalPrice += ingredient.Price;
            }
            
            return totalPrice;
        }
    }
    
    public Coffee(CoffeeIngredient[] ingredients)
    {
        _ingredients = ingredients;
    }

    public override string ToString()
    {
        var lines = new List<string>();
        
        foreach (var ingredient in _ingredients)
        {
            lines.Add($"{ingredient.Name} --- {ingredient.Price}$");
        }
        
        lines.Add($"Total price --- {Price}$\n");
        
        return String.Join("\n", lines);
    }
}