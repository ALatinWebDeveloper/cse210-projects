using System;

public class Assignment {

    private string _topic;
    private string _studentName;

    public string GetName()
    {
        
        return _studentName;
    }

    public Assignment(string topic, string studentName) {

        _topic = topic;
        _studentName = studentName;
    }

    public string GetSummary() {

        string summary = $"{_studentName} - {_topic}";

        return summary;
    }
    
}