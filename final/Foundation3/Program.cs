using System;

class Program
{
    static void Main(string[] args)
    {
        //Set Lecture
        Address addressLecture = new Address("Calle de San Jose 21, Playa Muro, Mallorca, Spain");
        Lecture lecture = new Lecture("Blood Angels Lecture", "Reading the the first book of the blood angels saga", "12/05/24", "16:00", addressLecture);

        //Display Lecture
        lecture.StandardDetails();
        lecture.FullDetails();
        lecture.ShortDetails();

        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine();

        //Set Reception
        Address addressReception = new Address("Calle de Saint Johan 21, Alcudia, Mallorca, Spain");
        Reception reception = new Reception("Web Designe Course", "Introductory course of Web Designe", "05/09/24", "09:00", addressReception);

        //Display Reception
        reception.StandardDetails();
        reception.FullDetails();
        reception.ShortDetails();

        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine();

        //Set Gathering
        Address addressGathering = new Address("Alicante st. 1, Alicant city, Alicant, Spain");
        Gathering gathering = new Gathering("Anime Expo 2024", "Anime expo, contests and cosplay competitions", "01/10/24", "14:00", addressGathering);

        //Display Gathering
        gathering.StandardDetails();
        gathering.FullDetails();
        gathering.ShortDetails();
    }
}