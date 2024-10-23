using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool guessing = true;
            string input;
            HashSet<string> ord = new HashSet<string>();
            AddWord("Kat", ord);
            AddWord("Kanin", ord);
            AddWord("Hund", ord);
            AddWord("Slange", ord);
            AddWord("Gris", ord);
            AddWord("Ko", ord);
            AddWord("Får", ord);
            AddWord("Bjørn", ord);
            AddWord("Løve", ord);
            AddWord("Tiger", ord);
            Console.WriteLine();
            while (guessing)
            {
                input = Console.ReadLine();
                if (input == "exit")
                {
                    guessing = false;
                }
                else
                {
                    if (ord.Contains(input))
                    {
                        ord.Remove(input);
                        Console.WriteLine($"{input} blev slettet fra listen");
                    }
                    else
                    {
                        Console.WriteLine("Ordet fandtes ikke i hashlisten");
                    }
                }
            }

        }
        static void AddWord(string name, HashSet<string> set)
        {
            if (set.Contains(name))
            {
                Console.WriteLine($"{name} kunne ikke tilføjes til listen da den allerede findes");
            }
            else
            {
                set.Add(name);
                Console.WriteLine($"{name} blev tilføjet til listen");
            }
        }
    }
}
