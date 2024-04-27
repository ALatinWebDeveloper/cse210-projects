using System.IO;
public class Journail {

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry _newEntry) {

        _entries.Add(_newEntry);
    }

    public void DisplayAll() {

        foreach (Entry item in _entries) {

            Console.WriteLine($"Here are all your entries:");
            Console.WriteLine($"Date: {item._date}");
            Console.WriteLine($"Question: {item._promptText}");
            Console.WriteLine($"You answered: {item._entryText}");
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Input any key to continue");
        }
    }

    public void SaveToFile(string filename) {

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {   
            if (filename.EndsWith(".csv"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
            }
            else
            {
            
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry._date);
                    outputFile.WriteLine(entry._promptText);
                    outputFile.WriteLine(entry._entryText);
                    outputFile.WriteLine();

                }
            }
        }
    }

    public void LoadFromFile(string filename) {

        if (filename.EndsWith(".csv"))
        {
            string[] entryItem = System.IO.File.ReadAllLines(filename);
            foreach (string item in entryItem)
            {
                string[] entryPart = item.Split(",");
                string date = entryPart[0];
                string prompt = entryPart[1];
                string response = entryPart[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"{response}");
                Console.WriteLine($"---------------------------------------");
                Console.WriteLine($"Input any key to continue");
            }
        }
        else{

            using (StreamReader reader = new StreamReader(filename))
            {
                String journalEntry = reader.ReadToEnd();
                Console.Write(journalEntry);
                Console.WriteLine($"---------------------------------------");
                Console.WriteLine($"Input any key to continue");
            }

        }
    }
}