public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Journal()
    {

    }

    // A method that returns a random Journal from the list of Journals
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    public void SaveToFile(string file)
    {
        string fileExt = file.Split('.').Last().ToLower();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                if (fileExt == "csv")
                {
                    outputFile.WriteLine($"\"{e._date}\",\"{e._promptText}\",\"{e._entryText}\"");
                }
                else
                {
                    outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
                }
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string fileExt = file.Split('.').Last().ToLower();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts;
            if (fileExt == "csv")
            {
                parts = line.Split("\",\"");
            }
            else
            {
                parts = line.Split("|");
            }

            Entry entry = new Entry();
            entry._date = parts[0].TrimStart("\"".ToCharArray());
            entry._promptText = parts[1];
            entry._entryText = parts[2].TrimEnd("\"".ToCharArray());
            AddEntry(entry);

        }
    }
}