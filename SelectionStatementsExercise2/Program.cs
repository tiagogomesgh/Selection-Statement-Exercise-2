using System.Diagnostics;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What was your favorite subject in High School?");
            var favSubject = Console.ReadLine();
            switch(favSubject)
            {
                case "History":
                    //  favSubject == "History";
                    Console.WriteLine("History! Welcome!!!");
                    break;
                case "Math":
                    //  favSubject == "History";
                    Console.WriteLine("Math! Welcome!!!");
                    break;
                case "Science":
                    //  favSubject == "History";
                    Console.WriteLine("Science! Welcome!!!");
                    break;
                case "Lunch":
                    //  favSubject == "History";
                    Console.WriteLine("Hahaha Lunch! Welcome!!!");
                    break;
                
                default:
                    Console.WriteLine("Hmmmm... What can I do for you?");
                    break;
            }
        }


       
    }


}