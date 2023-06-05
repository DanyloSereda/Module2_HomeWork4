using System.Text;

public class Randomizer
{
    public static Random random = new Random();

    private static string[] names = { "Simba", "Rajah", "Bagheera", "Mufasa", "Nala", "Shere Khan", "Aie", "Boba", "Maybach" };

    private static string[] colors = { "Green", "Blue", "Brown" };

    public static string GetRandomColor()
    {
        int index = random.Next(colors.Length);
        return colors[index];
    }

    public static string GetRandomName()
    {
        int index = random.Next(names.Length);
        return names[index];
    }

    public static int GetRandomStripeCount()
    {
        return random.Next(21);
    }

    public static int GetRandomPreyCount()
    {
        return random.Next(33);
    }

    public static int GetRandomAge()
    {
        return random.Next(1, 15);
    }
}