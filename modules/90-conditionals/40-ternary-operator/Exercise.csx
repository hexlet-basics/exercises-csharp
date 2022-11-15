class App
{
    // BEGIN
    public static string ConvertString(string str)
    {
        if (str == "") {
            return "";
        }

        return char.IsUpper(str[0]) ? str : Functions.StringReverse(str);
    }
    // END
}
