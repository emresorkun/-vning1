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
           


        }
        
    }
}