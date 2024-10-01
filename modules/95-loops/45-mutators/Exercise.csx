class App
{
    public static string MakeItFunny(string str, int n)
    {
        // BEGIN
        var i = 0;
        var result = "";
        while (i < str.Length)
        {
            var currentChar = str[i];
            if ((i + 1) % n == 0)
            {
                result += char.ToUpper(currentChar);
            }
            else
            {
                result += currentChar;
            }

            i++;
        }

        return result;
        // END
    }
}
