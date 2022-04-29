namespace LawyerOffice
{
    internal class Factory
    { 
       /// La factory può generare piu tipi di oggetti  
        public static ITranslator GetTranlator(LANGUAGE lang)
        {
            switch(lang)
            {
                case LANGUAGE.ENG:
                    return new EnglishTranslator();
                case LANGUAGE.SPA:
                    return new SpanishTranslator();
                case LANGUAGE.DE:
                    return new GermanTranslator();

                default:
                    return null;
            }
        }

        public static IRestaurant GetFood(RESTAURANT food)
        {
            switch(food)
            {
                case RESTAURANT.Fastfood:
                    return new McDonal();
                case RESTAURANT.CoffeShop:
                    return new CoffeeBar();
                case RESTAURANT.Pizzeria:
                    return new PizzaNapoli();

                default:
                    return null;
            }
        }
    }
}