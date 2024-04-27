public class Entry {
    
    public string _date;
    public string _promptText;
    public string _entryText;

    publicGenerator promptGenerator = new publicGenerator ();

    public void Display() {

        _date = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine("Remember to answer sincerely.");
        _promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine(_promptText);
        Console.WriteLine(_date);
        _entryText = Console.ReadLine();
        
    }
}