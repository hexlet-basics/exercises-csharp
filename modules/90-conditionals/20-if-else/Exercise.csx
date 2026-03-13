class App
{
    // BEGIN
    public static string NormalizeUrl(string site)
    {
        const string httpsPrefix = "https://";
        const string httpPrefix = "http://";

        if (site.StartsWith(httpsPrefix))
        {
            return site;
        }
        else
        {
            if (site.StartsWith(httpPrefix))
            {
                return httpsPrefix + site.Substring(httpPrefix.Length);
            }

            return httpsPrefix + site;
        }
    }
    // END
}
