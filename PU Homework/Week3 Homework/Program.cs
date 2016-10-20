using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            do
            {
                Console.WriteLine("1 ProblemOne\n2 ProblemTwo\n3 ProblemThree");
                Console.Write("Enter a digit 1-3 to choose a problem or 0 for exit:");
                value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 0: Console.WriteLine("Goodbye!"); break;
                    case 1:
                        Console.WriteLine("-----------------------------------------------------------------\n" +
                                          "Problem One\n"
                                          + "-----------------------------------------------------------------\n");
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
                        break;
                    default:
                        Console.WriteLine("Invalid input!\n");
                        break;
                }
            } while (value != 0);

            Console.WriteLine();
        }

        public static void ProblemOne()
        {
            string choice;
            Console.Write("Enter your coffee choice: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "small coffee":
                    Console.WriteLine("140mg caffeine");
                    break;
                case "medium coffee":
                    Console.WriteLine("196mg caffeine");
                    break;
                case "large coffee":
                    Console.WriteLine("280mg caffeine");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        public static void ProblemTwo()
        {
            string function, choice;
            double fst, snd, res;
            do
            {
                Console.Write("Enter a number: ");
                fst = double.Parse(Console.ReadLine());
                Console.Write("+\n-\n*\n/\n^\nsqrt\nChoose a function: ");
                function = Console.ReadLine();
                switch (function)
                {
                    case "+":
                        Console.Write("Enter a number: ");
                        snd = double.Parse(Console.ReadLine());
                        res = fst + snd;
                        Console.WriteLine("\n{0}+{1}={2}", fst, snd, res);
                        break;
                    case "-":
                        Console.Write("Enter a number: ");
                        snd = double.Parse(Console.ReadLine());
                        res = fst - snd;
                        Console.WriteLine("\n{0}-{1}={2}", fst, snd, res);
                        break;
                    case "*":
                        Console.Write("Enter a number: ");
                        snd = double.Parse(Console.ReadLine());
                        res = fst * snd;
                        Console.WriteLine("\n{0}*{1}={2}", fst, snd, res);
                        break;
                    case "/":
                        Console.Write("Enter a number: ");
                        snd = double.Parse(Console.ReadLine());
                        res = fst / snd;
                        Console.WriteLine("\n{0}/{1}={2}", fst, snd, res);
                        break;
                    case "^":
                        Console.Write("Enter degree: ");
                        snd = double.Parse(Console.ReadLine());
                        res = Math.Pow(fst, snd);
                        Console.WriteLine("\n{0}^{1}={2}", fst, snd, res);
                        break;
                    case "sqrt":
                        res = Math.Sqrt(fst);
                        Console.WriteLine(" SQRT({0})={1}", fst, res);
                        break;
                    default:
                        Console.WriteLine("Invalid entrance!");
                        break;
                }
                Console.Write("\ny(continue) | n(exit) ");
                choice = Console.ReadLine();
            } while (choice != "n");
        }

        public static void ProblemThree()
        {
            string num;
            string[] hund = { "", "sto", "dvesta", "trista", "chetiristotin", "petstotin", "shestotin", "sedemstotin", "osemstotin", "devetstotin" };
            string[] dec = { "", "", "dvaise", "triise", "chetirese", "pedese", "sheise", "sedemdese", "osemdese", "devedese" };
            string[] decTens = { "deset", "edinaise", "dvanaise", "trinaise", "chetirinaise", "petnaise", "shesnaise", "sedemnaise", "osemnaise", "devetnaise" };
            string[] dig = { "", "edno", "dve", "tri", "chetiri", "pet", "shest", "sedem", "osem", "devet" };
            Console.Write("Enter a number: ");
            num = Console.ReadLine();
            if (num.Length == 3)
            {
                Console.Write(hund[int.Parse(num[0].ToString())]);
                if (num[1] != '1')
                {
                    if (num[2] != '0')
                    {
                        Console.Write(" " + dec[int.Parse(num[1].ToString())]);

                        Console.WriteLine(" i " + dig[int.Parse(num[2].ToString())]);
                    }
                    else
                    {
                        Console.WriteLine(" i " + dec[int.Parse(num[1].ToString())]);
                    }

                }
                else
                {
                    Console.WriteLine(" i " + decTens[int.Parse(num[2].ToString())]);
                }
            }
            else if (num.Length == 2)
            {
                if (num[0] != '1')
                {
                    Console.Write(dec[int.Parse(num[0].ToString())]);

                    Console.WriteLine(" i " + dig[int.Parse(num[1].ToString())]);
                }
                else
                {
                    Console.WriteLine(decTens[int.Parse(num[1].ToString())]);
                }
            }
            else
            {
                Console.WriteLine(dig[int.Parse(num[0].ToString())]);
            }

        }
    }
}
