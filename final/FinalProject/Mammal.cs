class Mammal : Animal
{
    private string _furColor;
    private string _typeOfMammal;

    public Mammal()
    {
        _furColor = "";
        _typeOfMammal = "";
    }

    public string GetFurColor()
    {
        return _furColor;
    }

    public void SetFurColor(string furColor)
    {
        _furColor = furColor;
    }

    public string GetTypeOfMammal()
    {
        return _typeOfMammal;
    }

    public void SetTypeOfMammal(string typeOfMammal)
    {
        _typeOfMammal = typeOfMammal;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fur Color: {GetFurColor()}, Type of Mammal: {GetTypeOfMammal()}");
    }
}