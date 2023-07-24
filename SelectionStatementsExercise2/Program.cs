using System.Globalization;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject to study?");

            string subject = Console.ReadLine();

            

            switch(subject)
            {
                case "Math":
                case "math":
                    Console.WriteLine("Oh, so you like numbers, eh?  Me too!");
                    break;
                case "Science":
                case "science":
                    Console.WriteLine("Well, what about science?  The weather?  Rocks?  Physics??");
                    break;
                case "English" or "english":
                    Console.WriteLine("A grammar expert i see.  Like what I did their?");
                    break;
                case "Recess" or "recess":
                    Console.WriteLine("Me tooooooo");
                    break;
                case "Social studies" or "social studies":
                    Console.WriteLine("You like to learn about society... oh boy");
                    break;
                default:
                    Console.WriteLine("INVALID!!!!");
                    break;
                    

            }
        }
    }
}