namespace LawyerOffice
{
    public interface IRestaurant
    {
        public string SellFood(string food);
    }
    public class McDonal : IRestaurant
    {
        public string SellFood(string food)
        {
            return "Mc Burger";
        }
    }

    public class CoffeeBar : IRestaurant
    {
        public string SellFood(string food)
        {
            return "Coffee";
        }
    }

    public class PizzaNapoli : IRestaurant
    {
        public string SellFood(string food)
        {
            return "Pizzaaa";
        }
    }
}
