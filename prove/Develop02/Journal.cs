using System.IO;
public class Journail {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry){
        Journail items = new Journail();

        //Get the random prompt
        publicGenerator prompt = new publicGenerator();
        string question = prompt.GetRandomPrompt();

        //Writes prompt
        Console.WriteLine(question);
        newEntry._promptText = question;
        
        //Gets Entry text and stores it
        newEntry._entryText = Console.ReadLine();

        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }

    public void SaveToFile(string file){
        string fileName = file;
        Console.WriteLine("Saving");

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        
        {
            outputFile.WriteLine(_entries);
            outputFile.Flush();
        }
    }

    public void LoadFromFile(string file){

    }
}