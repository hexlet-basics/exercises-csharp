class App
{
    // BEGIN
    public static string ConvertString(string str)
    {
        if (str == "")
        {
            return "";
        }

        return char.IsUpper(str[0]) ? str : Functions.StringReverse(str);
        // Alternative:
        // if (char.IsUpper(str[0]))
        // {
        //     return str;
        // }
        // else
        // {
        //     return Functions.StringReverse(str);
        // }
    }
    // END
}
