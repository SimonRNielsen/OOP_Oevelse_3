using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] personArray = new Person[10] 
            { 
                new Person("Kurt", 42) ,
                new Person("Svend", 40) ,
                new Person("Børge", 45) ,
                new Person("Ole", 41) ,
                new Person("Niels", 62) ,
                new Person("Egon", 56) ,
                new Person("Benny", 12) ,
                new Person("Kjeld", 78) ,
                new Person("Yvonne", 25) ,
                new Person("Bøffen", 34) 
            };
            Dictionary<string, int> personDictionary = new Dictionary<string, int>();
            LinkedList<Person> personLinkedList = new LinkedList<Person>();
            SortedList<string, Person> personSortedList = new SortedList<string, Person>();
            foreach (Person individual in personArray)
            {
                personDictionary.Add(individual.Name, individual.Age);
            }
            foreach (Person individual in personArray)
            {
                personLinkedList.AddFirst(individual);
            }
            foreach (Person individual in personArray)
            {
                personSortedList.Add(individual.Name, individual);
            }
            foreach (var person in personDictionary)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            foreach (var person in personLinkedList)
            {
                Console.WriteLine(person.Name + " " + person.Age);
            }
            Console.WriteLine();
            foreach (var person in personSortedList)
            {
                Console.WriteLine(person.Value.Name + " " + person.Value.Age);
            }
            Console.ReadKey();
        }
    }
}
