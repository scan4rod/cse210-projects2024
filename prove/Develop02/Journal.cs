public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("What is the filename?");
        string fNam = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fNam))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptDay},{entry._entryDay}");
            }
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptDay = parts[1];
            entry._entryDay = parts[2];
            _entries.Add(entry);
        }
    }
}
