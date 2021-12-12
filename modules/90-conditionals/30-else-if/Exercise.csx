class App
{
    // BEGIN
    public static string WhoIsThisHouseToStarks(string houseName)
    {
        if (houseName == "Karstark" || houseName == "Tally")
        {
            return "friend";
        }
        else if (houseName == "Lannister" || houseName == "Frey")
        {
            return "enemy";
        }

        return "neutral";
    }
    // END
}
