public class Starter
{
    public void Start()
    {
        Animal[] animals = new Animal[]
        {
            new Lion(Randomizer.GetRandomName(), "Lion", Randomizer.GetRandomAge(), "Grasslands", Randomizer.GetRandomPreyCount(), false, Randomizer.GetRandomStripeCount()),
            new Tiger(Randomizer.GetRandomName(), "Tiger", Randomizer.GetRandomAge(), "Forests", Randomizer.GetRandomPreyCount(), true, Randomizer.GetRandomStripeCount()),
            new Panther(Randomizer.GetRandomName(), "Panther", Randomizer.GetRandomAge(), "Jungles", Randomizer.GetRandomPreyCount(), false, Randomizer.GetRandomColor()),
            new Lion(Randomizer.GetRandomName(), "Lion", Randomizer.GetRandomAge(), "Grasslands", Randomizer.GetRandomAge(), false, Randomizer.GetRandomStripeCount()),
            new Tiger(Randomizer.GetRandomName(), "Tiger", Randomizer.GetRandomAge(), "Forests", Randomizer.GetRandomPreyCount(), true, Randomizer.GetRandomStripeCount()),
            new Panther(Randomizer.GetRandomName(), "Panther", Randomizer.GetRandomAge(), "Jungles", Randomizer.GetRandomPreyCount(), false, Randomizer.GetRandomColor())
        };

        int totalAnimalCount = ZooPark.CountTotalAnimals(animals);
        Console.WriteLine($"Total animal count: {totalAnimalCount}");
        int distinctSpeciesCount = ZooPark.CountDistinctSpecies(animals);
        Console.WriteLine($"Distinct species count: {distinctSpeciesCount}");
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"\n{animal.Name} - {animal.Species}");

            if (animal is Mammal mammal)
            {
                Console.WriteLine($"Habitat: {mammal.Habitat}");
            }

            if (animal is Animal animalAge)
            {
                Console.WriteLine($"Age: {animalAge.Age}");
            }

            if (animal is Feline feline)
            {
                Console.WriteLine($"HasStripes: {feline.HasStripes}");
            }

            if (animal is Lion lion)
            {
                Console.WriteLine($"ManeSize: {lion.ManeSize}");
            }
            else if (animal is Tiger tiger)
            {
                Console.WriteLine($"StripeCount: {tiger.StripeCount}");
            }
            else if (animal is Panther panther)
            {
                Console.WriteLine($"EyeColor: {panther.EyeColor}");
            }
        }

        ZooPark.SortAnimalsByParameter(animals, "Name");
        Console.WriteLine("\nAnimals sorted by name:");
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"{animal.Name} - {animal.Species}");
        }

        Animal[] foundAnimals = animals.FindAnimalsByCriteria(animal => animal.Age < 7);
        if (foundAnimals.Length > 0)
        {
            Console.WriteLine("\nFound animals, age less than 7:");
            foreach (Animal animal in foundAnimals)
            {
                Console.WriteLine($"{animal.Name} : {animal.Age} ");
            }
        }
        else
        {
            Console.WriteLine("No animals found, age less than 7");
        }
    }
}