using Microsoft.VisualBasic;

public class publicGenerator {
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt(){

        _prompts.Add("Lunes");
        _prompts.Add("Martes");
        _prompts.Add("Miercoles");
        _prompts.Add("Jueves");
        _prompts.Add("Viernes");

        Random random = new Random();
        int randomNumber = random.Next(0, 5);

        string question = _prompts[randomNumber];

        return question;
    }
}