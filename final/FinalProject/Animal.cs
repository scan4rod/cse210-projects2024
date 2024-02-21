class Animal
{
    private string _name;
    private int _age;
    private string _gender;

    public Animal()
    {
        _name = "";
        _age = 0;
        _gender = "";
    }

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

    public string GetGender()
    {
        return _gender;
    }

    public void SetGender(string gender)
    {
        _gender = gender;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {GetName()}, Age: {GetAge()}, Gender: {GetGender()}");
    }
}
