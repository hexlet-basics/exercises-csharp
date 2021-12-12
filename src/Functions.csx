using System.Linq;

class Functions
{
    public static double Random()
    {
        return new Random().Next();
    }

    public static double RandomDouble()
    {
        return new Random().NextDouble();
    }

    public static string StringReverse(string str)
    {
        return string.Concat(str.Reverse());
    }
}
