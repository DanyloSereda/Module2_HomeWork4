using System.Xml;

public class Mammal : Animal
{
    public override string Name { get; }
    public override string Species { get; }
    public override int Age { get; }

    public string Habitat { get; }

    public Mammal(string name, string species, int age, string habitat)
    {
        Name = name;
        Species = species;
        Habitat = habitat;
        Age = age;
    }
}