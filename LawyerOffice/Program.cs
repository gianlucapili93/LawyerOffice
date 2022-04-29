using System;

namespace LawyerOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LawyerOffice lawyerOffice = new LawyerOffice();
            TranslationOffice translationOffice = new TranslationOffice();
            DeliveryStore foodstore = new DeliveryStore();
            lawyerOffice._translationOffice = translationOffice;
            lawyerOffice._deliveryOffice = foodstore;

            lawyerOffice.startTanslation(LANGUAGE.ENG, "Hola");
            lawyerOffice.BuyFood(RESTAURANT.Pizzeria, "Voglia la pizza!");
        }
    }
    public class LawyerOffice
    {
        public TranslationOffice _translationOffice { get; set; }   
        public DeliveryStore _deliveryOffice { get; set; }
        public LawyerOffice() { }
        public void startTanslation(LANGUAGE lang, string text)
        {
            string textTranslated = _translationOffice.Translate(lang,text);
            Console.WriteLine(textTranslated);
        }
        public void BuyFood(RESTAURANT where, string what)
        {
            string food = _deliveryOffice.Sell(where, what);
            Console.WriteLine(food);
        }
    } 
    public class TranslationOffice
    {   
        TranslationOnlineStore _onlineStore = new TranslationOnlineStore();
        public string Translate(LANGUAGE lang, string text)
        {
            return _onlineStore.Translate(lang, text);
        }
    }
    public enum LANGUAGE
    {
        ENG,
        DE,
        SPA  
    }
    public enum RESTAURANT
    {
        CoffeShop,
        Pizzeria,
        Fastfood
    }
}
