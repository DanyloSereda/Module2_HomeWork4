public class Tiger : Feline
{
    public int StripeCount { get; }

    public Tiger(string name, string species, int age, string habitat, int preyCount, bool hasStripes, int stripeCount) 
        : base(name, species, age, habitat, preyCount, hasStripes)
    {
        StripeCount = stripeCount;
    }
}