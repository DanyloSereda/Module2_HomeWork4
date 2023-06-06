public class Panther : Feline
{
    public string EyeColor { get; }

    public Panther(string name, string species, int age, string habitat, int preyCount, bool hasStripes, string eyeColor) 
        : base(name, species, age, habitat, preyCount, hasStripes)
    {
        EyeColor = eyeColor;
    }
}