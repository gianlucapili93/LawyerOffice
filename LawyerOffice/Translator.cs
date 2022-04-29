namespace LawyerOffice
{
    public interface ITranslator
    {
        public string Translate(string text);
    }
    public class EnglishTranslator : ITranslator
    {
        public string Translate(string text)
        {
            return "Hi";
        }

    }
    public class SpanishTranslator : ITranslator
    {
        public string Translate(string text)
        {
            return "Hola";
        }
    }
    public class GermanTranslator : ITranslator
    {
        public string Translate(string text)
        {
            return "Hallo";
        }
    }
}
