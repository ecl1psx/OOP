namespace Program;

public class CoffeeMachine
{
    public Coffee CookCoffee(CoffeeIngredient ingredient1, CoffeeIngredient ingredient2)
    {
        CoffeeIngredient[] coffeeIngredients = { new WaterAndCoffeeSeeds(), ingredient1, ingredient2 }; 
        
        return new Coffee(coffeeIngredients);
    }
    
    public Coffee CookCoffee(CoffeeIngredient ingredient1, CoffeeIngredient ingredient2, CoffeeIngredient ingredient3)
    {
        CoffeeIngredient[] coffeeIngredients = { new WaterAndCoffeeSeeds(), ingredient1, ingredient2, ingredient3 }; 
        
        return new Coffee(coffeeIngredients);
    }
}