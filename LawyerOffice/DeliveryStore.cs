namespace LawyerOffice
{
    public class DeliveryStore 
    {
        public DeliveryStore() { }
        public string Sell(RESTAURANT type, string what) 
        { 
            var food = Factory.GetFood(type);
            return food.SellFood(what);
        }
    }
}