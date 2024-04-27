public class Entry {
    
    public string _date;
    public string _promptText;
    public string _entryText;

    publicGenerator promptGenerator = new publicGenerator ();

    public void Display() {

        _date = DateTime.Now.ToString("MM--dd--yyyy");
        _promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine(_promptText);
        Console.WriteLine(_date);
        _entryText = Console.ReadLine();
        
    }
}