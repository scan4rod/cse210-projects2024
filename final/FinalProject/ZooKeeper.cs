class ZooKeeper
{
    private string _name;
    private int _age;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public int GetAge()
    {
        return _age;
    }

    public void SetAge(int age)
    {
        _age = age;
    }

    public void FeedAnimal(Animal animal)
    {
        Console.WriteLine($"{GetName()} is feeding {animal.GetName()}.");
    }
}