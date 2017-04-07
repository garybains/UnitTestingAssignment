using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Choose one of following options");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        FirstOption();
                        break;
                    default:
                        break;
                }
            } while (choice != "2");
        }

        static void FirstOption()
        {
            int sideA = GetASide(1);
            int sideB = GetASide(2);
            int sideC = GetASide(3);
            string triangleType = TriangleSolver.Analyze(sideA, sideB, sideC);
            Console.WriteLine($"Your Traingle is : {triangleType}");
        }
        static int GetASide(int sideNum)
        {
            int sideLength = 0;
            bool sideIsNotValid = true;
            while (sideIsNotValid)
            {
                Console.WriteLine($"Enter length for side {sideNum} : ");
                string strSideLength = Console.ReadLine();
                try
                {
                    sideLength = Int32.Parse(strSideLength);
                    sideIsNotValid = false;
                }
                catch
                {
                    Console.WriteLine("Invalid integer try again");
                }
            }
            return sideLength;
        }
    }
}
