using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            InstructionsHeader();
            InstructionsGetNumbers();

            int typeLottery = int.Parse(Console.ReadLine());
            List<int> lottoNumbers = new List<int>();

            if (typeLottery == 49) // 6 of 49
            {
                while (true)
                {
                    if (lottoNumbers.Count >= 6)
                    {
                        break;
                    }

                    int number = GetRandomNumber(49);

                    if (!lottoNumbers.Contains(number))
                    {
                        lottoNumbers.Add(number);
                    }
                }
            }
            else if (typeLottery == 35) // 5 of 35
            {
                while (true)
                {
                    if (lottoNumbers.Count >= 5)
                    {
                        break;
                    }

                    int number = GetRandomNumber(45);

                    if (!lottoNumbers.Contains(number))
                    {
                        lottoNumbers.Add(number);
                    }
                }
            }
            else // 6 of 42
            {
                while (true)
                {
                    if (lottoNumbers.Count >= 6)
                    {
                        break;
                    }

                    int number = GetRandomNumber(42);

                    if (!lottoNumbers.Contains(number))
                    {
                        lottoNumbers.Add(number);
                    }
                }
            }

            Console.Write("\nYour winning numbers are: ");

            foreach (var number in lottoNumbers.OrderBy(x => x))
            {
            Console.Write(number + " ");
            }
            Console.WriteLine("\n");

            InstructionsFooter();
        }

        static int GetRandomNumber(int x)
        {
            Random rand = new Random();
            int result = rand.Next(1, x);
            return result;
        }

        static void InstructionsHeader()
        {
            Console.WriteLine("The Bulgarian National Lottery (Sport-Toto) is the only \nstate-franchised lottery in the country. It has started \nback in 1957 and it has been the \"legitimate\" way \nto become rich in Bulgaria ever since. Over the years, \nhundreds of bulgarians have won big prizes, but what was \ntheir secret? Here is your opportunity to get your lucky \nnumbers right now.\n========================================================\n");
        }

        static void InstructionsGetNumbers()
        {
            Console.WriteLine("There are 3 different games you can participate in:\n- 5 of 35\n- 6 of 42\n- 6 of 49\nIt is obvious that you need to guess several numbers \nout of a total. Please enter 35, 42 or 49 for the game \nyou want to participate in and press Enter/Return:\n========================================================\n");
        }

        static void InstructionsFooter()
        {
            Console.WriteLine("Remember, the next winner can be you. \nBelieve in your luck and it will pay off. ");
        }
    }
}
