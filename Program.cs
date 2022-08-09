using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter start num: ");
            double first_num = double.Parse(Console.ReadLine());

            for (int i = 0; ; i++)
            {
                Console.WriteLine("Enter + or - or * or /");
                string action = Console.ReadLine();

                Console.WriteLine("Enter num: ");
                double second_num = double.Parse(Console.ReadLine());

                switch (action)
                {
                    case "+":
                        first_num = first_num + second_num;
                        Console.WriteLine(first_num);
                        break;
                    case "-":
                        first_num = first_num - second_num;
                        Console.WriteLine(first_num);
                        break;
                    case "*":
                        first_num = first_num * second_num;
                        Console.WriteLine(first_num);
                        break;
                    case "/":
                        first_num = first_num / second_num;
                        Console.WriteLine(first_num);
                        break;

                    default:
                        Console.WriteLine("LOX");
                        break;
                        
                }
                Console.WriteLine();
            }
            


        }
    }
}
