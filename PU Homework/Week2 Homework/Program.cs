using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Homework
{
    class Program
    {
        //Earths gravity
        private const float g = 9.81f;

        static void Main(string[] args)
        {
            int value;
            do
            {
                Console.WriteLine("1 ProblemOne\n2 ProblemTwo\n3 ProblemThree\n4 ProblemFour\n5 ProblemFive\n6 ProblemSix");
                Console.Write("Enter a digit 1-6 to choose a problem or 0 for END:");
                value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 0: Console.WriteLine("Goodbye!"); break;
                    case 1:
                        Console.WriteLine("-----------------------------------------------------------------\n"+
                                          "Problem One\n"
                                          +"-----------------------------------------------------------------\n");
                        ProblemOne();
                        Console.WriteLine("-----------------------------------------------------------------\n");
                        break;
                    case 2:
                        Console.WriteLine("-----------------------------------------------------------------\n" +
                                         "Problem Two\n"
                                         + "-----------------------------------------------------------------\n");
                        ProblemTwo();
                        Console.WriteLine("-----------------------------------------------------------------\n");
                        break;
                    case 3:
                        Console.WriteLine("-----------------------------------------------------------------\n" +
                                         "Problem Threen"
                                         + "-----------------------------------------------------------------\n");
                        ProblemThree();
                        Console.WriteLine("-----------------------------------------------------------------\n");
                        break;
                    case 4:
                        Console.WriteLine("-----------------------------------------------------------------\n" +
                                         "Problem Four\n"
                                         + "-----------------------------------------------------------------\n");
                        ProblemFour();
                        Console.WriteLine("-----------------------------------------------------------------\n");
                        break;
                    case 5:
                        Console.WriteLine("-----------------------------------------------------------------\n" +
                                         "Problem Five\n"
                                         + "-----------------------------------------------------------------\n");
                        ProblemFive();
                        Console.WriteLine("-----------------------------------------------------------------\n");
                        break;
                    case 6:
                        Console.WriteLine("-----------------------------------------------------------------\n" +
                                         "Problem Six\n"
                                         + "-----------------------------------------------------------------\n");
                        ProblemSix();
                        Console.WriteLine("-----------------------------------------------------------------\n");
                        break;
                    default:
                        Console.WriteLine("Invalid command!\n");
                        break;
                }
            } while (value != 0);
        }

        public static void ProblemOne()
        {
            int a = 5, b = 8, c = 3, temp = 0;
            temp = a;
            a = b;
            b = c;
            c = temp;
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }

        public static void ProblemTwo()
        {

            float weight = 0.0f, mass = 0.0f;
            float moonsG = g * 17 / 100;
            Console.Write("Enter persones weight: ");
            weight = float.Parse(Console.ReadLine());
            mass = weight / g;
            Console.WriteLine("That person weights {0} kg. on the moon.", mass * moonsG);
        }

        public static void ProblemThree()
        {
            int a, b;
            Console.WriteLine("Enter two int values!");
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            }
            else
            {
                Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            }
        }

        public static void ProblemFour()
        {
            string a = "";

            do
            {
                Console.WriteLine("Entera a six-digit number!");
                a = Console.ReadLine();
            } while (a.Length == 5);
            if (a[a.Length - 3] == '6')
            {
                Console.WriteLine("Hundreds digit is 6.");
            }
            else
            {
                Console.WriteLine("Hundreds digit is not 6.");
            }
        }

        public static void ProblemFive()
        {
            double a;
            bool b;

            Console.WriteLine("Enter a random number!");
            a = double.Parse(Console.ReadLine());
            if (a == 3 || (a > 7 && a != 10))
            {
                b = true;
                Console.WriteLine(b);
            }
            else
            {
                b = false;
                Console.WriteLine(b);
            }
        }

        public static void ProblemSix()
        {
            int max = 0;
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter 5 numbers!");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("\nThe biggest number is: {0}", max);

        }
    }
}
