public static class ZooPark
{
    public static int CountDistinctSpecies(Animal[] animals)
    {
        string[] species = new string[animals.Length];
        int count = 0;

        for (int i = 0; i < animals.Length; i++)
        {
            string currentSpecies = animals[i].Species;

            if (!species.Contains(currentSpecies))
            {
                species[count] = currentSpecies;
                count++;
            }
        }

        return count;
    }

    public static int CountTotalAnimals(Animal[] animals)
    {
        return animals.Length;
    }

    public static void SortAnimalsByParameter(Animal[] animals, string parameter)
    {
        if (parameter == "Name")
        {
            Array.Sort(animals, (a1, a2) => a1.Name.CompareTo(a2.Name));
        }
        else if (parameter == "Species")
        {
            Array.Sort(animals, (a1, a2) => a1.Species.CompareTo(a2.Species));
        }
    }
}