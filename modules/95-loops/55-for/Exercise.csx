class App
{
    public static string Encrypt(string str)
    {
        // BEGIN
        var result = "";
        for (var i = 0; i < str.Length; i += 2)
        {
            if (i == str.Length - 1)
            {
                result += str[i];
            }
            else
            {
                var firstChar = str[i];
                var secondChar = str[i + 1];
                result = result + secondChar +  firstChar;
            }
        }

        return result;
        // END
    }
}
