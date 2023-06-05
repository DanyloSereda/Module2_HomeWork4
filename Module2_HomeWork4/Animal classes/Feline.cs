public class Feline : Carnivore
{
    public bool HasStripes { get; }

    public Feline(string name, string species, int age, string habitat, int preyCount, bool hasStripes)
        : base(name, species, age, habitat, preyCount)
    {
        HasStripes = hasStripes;
    }
}