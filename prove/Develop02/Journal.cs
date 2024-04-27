using System.IO;
public class Journail {

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry _newEntry) {

        _entries.Add(_newEntry);
    }

    public void DisplayAll() {

        foreach (Entry item in _entries) {

            Console.WriteLine($"Date: {item._date}");
            Console.WriteLine($"Prompt: {item._promptText}");
            Console.WriteLine($"Answer: {item._entryText}");
            Console.WriteLine($"");
        }
    }

    public void SaveToFile(string filename) {

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            int entryNumber = 0;
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine();

                entryNumber += + 1;
                Console.WriteLine($"Entry Number ${entryNumber} saved");
            }
        }
    }

    public void LoadFromFile(string filename) {

        string[] lines = System.IO.File.ReadAllLines(filename);

        using (StreamReader reader = new StreamReader(filename))
            {
                String journalEntry = reader.ReadToEnd();
                Console.Write(journalEntry);
            }
    }
}