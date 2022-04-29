namespace LawyerOffice
{
    public class TranslationOnlineStore
    {
        
        public TranslationOnlineStore() { }
        public string Translate(LANGUAGE lang, string text)
        {
            var translator = Factory.GetTranlator(lang);
            return translator.Translate(text);
        }
    }
}
