public class Lion : Feline
{
    public int ManeSize { get; }

    public Lion(string name, string species, int age, string habitat, int preyCount, bool hasStripes, int maneSize)
        : base(name, species, age, habitat, preyCount, hasStripes)
    {
        ManeSize = maneSize;
    }
}