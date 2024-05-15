using System.IO;
public class Library {
    private List<Word> _words = new List<Word>();

    public List<string> createList()
    {
        List<string> words = new List<string>();
        foreach (var item in _words)
            {
                words.Add(item.ToString());
            }

        return words;
    }
}