namespace TextFileToRegSz
{
    public interface ICanRegistry
    {
        bool PrüfeObGültigerSchlüsselIst(string value);

        void Schreibe(string schlüssel, string zeichenfolgeName, string zeichenfolgeWert);
    }
}