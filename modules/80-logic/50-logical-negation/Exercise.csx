class App
{
    public static bool IsLannisterSoldier(string color, string shield)
    {
        return (color == "red" && shield == null) || shield == "lion";
    }

    // BEGIN
    public static bool IsNotLannisterSoldier(string color, string shield)
    {
        return !IsLannisterSoldier(color, shield);
    }
    // END
}
