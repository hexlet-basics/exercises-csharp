class App
{
    // BEGIN
    public static string ConvertString(string str)
    {
        return char.IsUpper(str[0]) ? str : Functions.StringReverse(str);
    }
    // END
}
