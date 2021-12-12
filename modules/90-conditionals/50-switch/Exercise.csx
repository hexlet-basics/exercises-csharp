class App
{
    // BEGIN
    public static string GetNumberExplanation(int number)
    {
        switch (number)
        {
            case 666:
                return "devil number";
            case 7:
                return "prime number";
            case 42:
                return "answer for everything";
            default:
                return null;
        }
    }
    // END
}
