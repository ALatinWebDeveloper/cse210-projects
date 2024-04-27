using Microsoft.VisualBasic;

public class publicGenerator {
    
    public List<string> _prompts = new List<string>();
    

    public string GetRandomPrompt() {

        _prompts.Add("What memory from today would you treasure?");
        _prompts.Add("What made you smile today?");
        _prompts.Add("Was there someone you wanted to see or talk to today?");
        _prompts.Add("What did you do today that you are proud of?");
        _prompts.Add("What would you like to do today?");

        Random random = new Random();
        int randomNumber = random.Next(0, 5);

        string _prompt = _prompts[randomNumber];

        return _prompt;
    }
    
}