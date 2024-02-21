class Reptile : Animal
{
    private string _scaleColor;
    private bool _isVenomous;

    public Reptile()
    {
        _scaleColor = "";
        _isVenomous = false;
    }

    public string GetScaleColor()
    {
        return _scaleColor;
    }

    public void SetScaleColor(string scaleColor)
    {
        _scaleColor = scaleColor;
    }

    public bool GetIsVenomous()
    {
        return _isVenomous;
    }

    public void SetIsVenomous(bool isVenomous)
    {
        _isVenomous = isVenomous;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Scale Color: {GetScaleColor()}, Is Venomous: {GetIsVenomous()}");
    }
}
