class App
{
    // BEGIN
    public static bool IsLannisterSoldier(string color, string shield)
    {
        return (color == "red" && shield == null) || shield == "lion";
    }
    // END
}
