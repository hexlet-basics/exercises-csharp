class App
{
    // BEGIN
    public static int GetCurrentYear()
    {
        var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        var currentYearAsString = currentDate.Substring(0, 4);
        var currentYear = int.Parse(currentYearAsString);
        return currentYear;
    }
    // END
}
