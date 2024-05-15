using System.IO;
public class Word {

    private string _text { get; set; }
    private bool _isHidden;

    public override string ToString()
    {
        return _text;
    }

    public Word(string text) {

        _text = text;
        _isHidden = false;
    }

    public void Hide() {

        _isHidden = true;
    }

    public void Show() {

        _isHidden = false;
    }

    public bool IsHidden() {

        return _isHidden;
    }

    public string GetDisplayText() {

        return _isHidden ? new string('_', _text.Length) : _text; 
    }
}