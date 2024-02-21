class Enclosure
{
    private int _capacity;
    private int _temperature;
    private List<Animal> _animals = new List<Animal>();

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public int GetTemperature()
    {
        return _temperature;
    }

    public void SetTemperature(int temperature)
    {
        _temperature = temperature;
    }

    public void AddAnimal(Animal animal)
    {
        if (_animals.Count < GetCapacity())
        {
            _animals.Add(animal);
            Console.WriteLine($"{animal.GetName()} added to the enclosure.");
        }
        else
        {
            Console.WriteLine("Enclosure is full, cannot add more animals.");
        }
    }

    public void DisplayEnclosureInfo()
    {
        Console.WriteLine($"Enclosure Capacity: {GetCapacity()}, Temperature: {GetTemperature()}°C");
        Console.WriteLine("Animals in the enclosure:");
        foreach (var animal in _animals)
        {
            animal.DisplayInfo();
        }
    }
}
