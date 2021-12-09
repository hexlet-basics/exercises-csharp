class App
{
    // BEGIN
    public static string Truncate(string str, int count = 10)
    {
        return $"{str.Substring(0, count)}...";
    }
    // END
}
