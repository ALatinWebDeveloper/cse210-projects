public class Reference {

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse) {

        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference (string book, int chapter, int starVerse, int endVerse) {

        _book = book;
        _chapter = chapter;
        _verse = starVerse;
        _endVerse = endVerse;

    }

    public string GetDisplayVerse() {

        return string.Format("{0} {1}:{2}", _book, _chapter, _verse);
    }
}