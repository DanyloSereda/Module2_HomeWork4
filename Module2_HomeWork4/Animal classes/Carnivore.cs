public class Carnivore : Mammal, IPredator
{
    public int PreyCount { get; }

    public Carnivore(string name, string species, int age, string habitat, int preyCount)
        : base(name, species, age, habitat)
    {
        PreyCount = preyCount;
    }
}