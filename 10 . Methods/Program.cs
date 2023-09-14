using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calls for the sayHi method
            sayHi();

            // Calls for the Addnumber method
            AddNumber();

            // You can switch the order
            //Freeze console
            Console.ReadLine();
        }

        static void sayHi()
        {
            Console.WriteLine("Your name: ");

            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name +"\n");
            Console.WriteLine("Hi " + name + ", sayHi is done \n");
        }

        static void AddNumber()
        {
            Console.WriteLine("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\n"+ "Hi, Add Number is done, you can now get results:");

            Console.WriteLine(num1 + num2 + "\n");
        }
    }
}
