class App
{
    public static string Reverse(string str)
    {
        // BEGIN
        var i = str.Length - 1;
        var result = "";
        while (i >= 0)
        {
            result = result + str[i];
            i = i - 1;
        }

        return result;
        // END
    }
}
