class App
{
    // BEGIN
    public static string GetSentenceTone(string sentence)
    {
        if (sentence.ToUpper() == sentence)
        {
            return "scream";
        }

        return "normal";
    }
    // END
}
