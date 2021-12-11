class App
{
    // BEGIN
    public static string NormalizeUrl(string site)
    {
        if (site.StartsWith("https://"))
        {
            return site;
        }

        return "https://" + site;
    }
    // END
}
