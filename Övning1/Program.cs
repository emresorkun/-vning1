using System.Xml.Linq;

namespace Övning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < length; i++)
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