public class Entry
{
    public string _date = "";
    public string _entryDay = "";
    public string _promptDay = "";

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_promptDay}");
        Console.WriteLine(_entryDay);
    }
}