public static class ZooParkExtensions
{
    public static Animal[] FindAnimalsByCriteria(this Animal[] animals, Predicate<Animal> criteria)
    {
        int count = 0;

        foreach (Animal animal in animals)
        {
            if (criteria(animal))
            {
                count++;
            }
        }

        Animal[] foundAnimals = new Animal[count];
        int index = 0;

        foreach (Animal animal in animals)
        {
            if (criteria(animal))
            {
                foundAnimals[index] = animal;
                index++;
            }
        }

        return foundAnimals;
    }
}