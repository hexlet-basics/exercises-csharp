class App
{
    public static string Truncate(string str, int count)
    {
        // BEGIN
        return $"{str.Substring(0, count)}...";
        // END
    }
}
