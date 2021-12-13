class App
{
    public static int CountChars(string str, char ch)
    {
        // BEGIN
        var i = 0;
        var count = 0;
        while (i < str.Length)
        {
            var currentChar = char.ToLower(str[i]);
            if (currentChar == char.ToLower(ch))
            {
                count = count + 1;
            }

            i = i + 1;
        }

        return count;
        // END
    }
}
