public class Scripture {

    Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text) {

        _reference = Reference;
        
        string[] scriptureIndex = text.Split(" ");
        
        foreach (var word in scriptureIndex)
        {
            _words.Add(new Word(word));
        }
    }

    public void listString() {

        List<string> pls = _words.ToString().Split(" ").ToList();
    }

    public void HideRandomWords() {


            Random rand = new Random();
            int censuredIndex = rand.Next(_words.Count);
            // 
            string wordToCensure = _words[censuredIndex].ToString();
            string censuredWord = new string('_', wordToCensure.Length);
            
            // 

            //

            _words[censuredIndex] = new Word(censuredWord);

    }

    public string GetDisplayText() {

        List<string> visibleWords = _words.Select(item => item.GetDisplayText()).ToList();
        string renderedText = string.Join(" ", visibleWords);

        return renderedText;
    }
    

    public bool IsCompletelyHidden() {

        bool found = false;

        List<string> palabras = new List<string>();
        
        foreach(Word word in _words)
        {
            foreach (var item in _words)
            {
                palabras.Add(item.ToString());
                if (item.Contains('_') == false)
                {
                    found = true;
                    break;
                }
            }

            
        }
        
        return found;
    }
}