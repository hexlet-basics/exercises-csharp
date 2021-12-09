class App
{
    // BEGIN
    public static string Truncate(string str, int count)
    {
        return $"{str.Substring(0, count)}...";
    }
    // END
}
