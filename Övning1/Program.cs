using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Övning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many workers do you have?");
            int  numberOfWorkers ;
            numberOfWorkers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfWorkers; i++)
            {
                Console.WriteLine("Please enter the name: ");
                string name;
                name = Console.ReadLine();
                Console.WriteLine($"please enter the sallary of {name}: ");
                string sallary;
                sallary = Console.ReadLine();
                Console.WriteLine($"name//{name} sallary//{sallary}");
            }

            //Uppgift 1 Vilka klasser bör ingå i programmet?

            // here in my badly written but working programme only Program Class.
            // If I could I should be creating a class named Employee and add two attribut to this class. Name and Salary. Or maybe two classes? I cant decide.

            //Uppgift 2 Vilka attribut och metoder bör ingå i dessa klasser?

            //I do not know how to create arrays populated with objects so this end up being simple. If I could do I would create an array of objects and push each employee name and sallary
            //pair to this array. 

            //Uppgift 3 Skriv programmet

        }
        
    }
}