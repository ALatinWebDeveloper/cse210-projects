using System;

public class MathAssignment : Assignment
{
    private string _textBook;
    private string _problems;

    public MathAssignment (string textBook, string problems, string studentName, string topic) : base(studentName, topic){

        _textBook = textBook;
        _problems = problems;

    }

    public string GetHomeworkList() {

        return $"{_textBook} - {_problems}";
    }
}