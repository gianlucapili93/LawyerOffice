namespace LawyerOffice
{
    public interface IRestaurant
    {
        public string SellFood(string food);
    }
    public class Fastfood : IRestaurant
    {
        public string SellFood(string food)
        {
            return "Hamburger";
        }
    }

    public class CoffeeBar : IRestaurant
    {
        public string SellFood(string food)
        {
            return "Coffee";
        }
    }

    public class Pizzeria : IRestaurant
    {
        public string SellFood(string food)
        {
            return "Pizzaaa";
        }
    }
}
