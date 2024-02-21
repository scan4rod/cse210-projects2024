class Bird : Animal
{
    private string _featherColor;
    private double _wingspan;

    public Bird()
    {
        _featherColor = "";
        _wingspan = 0.0;
    }

    public string GetFeatherColor()
    {
        return _featherColor;
    }

    public void SetFeatherColor(string featherColor)
    {
        _featherColor = featherColor;
    }

    public double GetWingspan()
    {
        return _wingspan;
    }

    public void SetWingspan(double wingspan)
    {
        _wingspan = wingspan;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Feather Color: {GetFeatherColor()}, Wingspan: {GetWingspan()} meters");
    }
}

