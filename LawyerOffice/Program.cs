using System;

namespace LawyerOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LawyerOffice lawyerOffice = new LawyerOffice();

            lawyerOffice.startTanslation(LANGUAGE.ENG, "Hola");
            lawyerOffice.BuyFood(RESTAURANT.Pizzeria, "Voglia la pizza!");
        }
    }
    public class LawyerOffice
    {
        public TranslationOffice _translationOffice { get; set; }   
        public DeliveryOffice _deliveryOffice { get; set; }
        public LawyerOffice() 
        {
            this._translationOffice = new TranslationOffice();
            this._deliveryOffice = new DeliveryOffice();
        }
        public void startTanslation(LANGUAGE lang, string text)
        {
            string textTranslated = _translationOffice.Translate(lang,text);
            Console.WriteLine(textTranslated);
        }
        public void BuyFood(RESTAURANT where, string what)
        {
            string food = _deliveryOffice.BuyFood(where, what);
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
    public class DeliveryOffice
    {
        DeliveryStore _deliveryStore = new DeliveryStore();
        public string BuyFood(RESTAURANT type, string what)
        {
            return _deliveryStore.Sell(type, what);
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
