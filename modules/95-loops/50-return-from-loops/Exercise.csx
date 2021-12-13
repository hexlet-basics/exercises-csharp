class App
{
    public static bool HasChar(string str, char ch)
    {
        // BEGIN
        var i = 0;
        while (i < str.Length)
        {
            if (str[i] == ch)
            {
                return true;
            }

            i += 1;
        }

        return false;
        // END
    }
}
