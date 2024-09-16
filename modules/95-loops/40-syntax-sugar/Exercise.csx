class App
{
    public static string FilterString(string str, char ch)
    {
        // BEGIN
        var i = 0;
        var result = "";
        while (i < str.Length)
        {
            var currentChar = str[i];
            if (currentChar != ch)
            {
                result += currentChar;
            }

            i += 1;
        }

        return result;
        // END
    }
}
