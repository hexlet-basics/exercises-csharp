class App
{
    public static string MakeItFunny(string str, int n)
    {
        // BEGIN
        var i = 0;
        var result = "";
        while (i < str.Length)
        {
            var current = str[i];
            if ((i + 1) % n == 0)
            {
                result = result + char.ToUpper(current);
            }
            else
            {
                result = result + current;
            }

            i++;
        }

        return result;
        // END
    }
}
