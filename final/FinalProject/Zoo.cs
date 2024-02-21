class Zoo
{
    private List<Enclosure> _enclosures = new List<Enclosure>();
    private List<ZooKeeper> _zooKeepers = new List<ZooKeeper>();
    private List<Veterinarian> _veterinarians = new List<Veterinarian>();
    private List<Animal> _animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
        Console.WriteLine("Animal added to the zoo.");
        Enclosure enclosure = new Enclosure();
        enclosure.AddAnimal(animal);

    }

    public void AddEnclosure(Enclosure enclosure)
    {
        _enclosures.Add(enclosure);
        Console.WriteLine("Enclosure added to the zoo.");
    }

    public void AddZooKeeper(ZooKeeper zooKeeper)
    {
        _zooKeepers.Add(zooKeeper);
        Console.WriteLine("ZooKeeper added to the zoo.");
    }

    public void AddVeterinarian(Veterinarian veterinarian)
    {
        _veterinarians.Add(veterinarian);
        Console.WriteLine("Veterinarian added to the zoo.");
    }

    public void DisplayZooInfo()
    {
        Console.WriteLine("Zoo Information:");
        Console.WriteLine("Enclosures:");
        foreach (var enclosure in _enclosures)
        {
            enclosure.DisplayEnclosureInfo();
        }

        Console.WriteLine("ZooKeepers:");
        foreach (var zooKeeper in _zooKeepers)
        {
            Console.WriteLine($"Name: {zooKeeper.GetName()}, Age: {zooKeeper.GetAge()}");
        }

        Console.WriteLine("Veterinarians:");
        foreach (var veterinarian in _veterinarians)
        {
            Console.WriteLine($"Name: {veterinarian.GetName()}, Specialization: {veterinarian.GetSpecialization()}");
        }

        Console.WriteLine("Animals:");
        foreach (var animal in _animals)
        {
            Console.WriteLine($"Name: {animal.GetName()}, Age: {animal.GetAge()}, Gender:{animal.GetGender()}");
        }
    }
}
