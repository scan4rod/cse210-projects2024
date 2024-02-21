class Veterinarian
{
    private string _name;
    private string _specialization;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetSpecialization()
    {
        return _specialization;
    }

    public void SetSpecialization(string specialization)
    {
        _specialization = specialization;
    }

    public void ExamineAnimal(Animal animal)
    {
        Console.WriteLine($"{GetName()} is examining {animal.GetName()} for {GetSpecialization()}.");
    }
}
