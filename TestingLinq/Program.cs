using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            People peeps = new People();

            List<People> myPeople = new List<People>();

            myPeople.Add(new People() { City = "Eliot", Name = "Frank" });
            myPeople.Add(new People() { City = "Nashville", Name = "Samuel" });
            myPeople.Add(new People() { City = "Berwick", Name = "Tracy" });
            myPeople.Add(new People() { City = "Eliot", Name = "Carolyn" });
            myPeople.Add(new People() { City = "Nashville", Name = "Wayne" });
            myPeople.Add(new People() { City = "St. Augustine", Name = "Shirley" });
            myPeople.Add(new People() { City = "Sandwich", Name = "Ellyn" });
            myPeople.Add(new People() { City = "Berwick", Name = "Rory" });
            myPeople.Add(new People() { City = "Nashville", Name = "Jill" });
            myPeople.Add(new People() { City = "Sandwich", Name = "Bob" });
            myPeople.Add(new People() { City = "Nashville", Name = "Hope" });
            myPeople.Add(new People() { City = "Berwick", Name = "Cindy" });

            foreach (People person in myPeople)
            {
                Console.WriteLine("Name: {0}, City: {1}", person.Name, person.City);
            }

            Console.WriteLine();

            var queryByCity = from person in myPeople group person by person.City;

            foreach (var cityGroup in queryByCity)
            {
                Console.WriteLine("Contacts in " + cityGroup.Key);
                foreach (People person in cityGroup)
                {
                    Console.WriteLine(person.Name);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int last = numbers.Last();
            var evens = from n in numbers where n % 2 == 0 select n;
            foreach (int num in evens)
            {
                Console.WriteLine(num + " ");
            }

            Console.WriteLine("Last number is {0}", last);
            Console.WriteLine();
            Console.ReadKey();

            string[] words = { "This", "movie", "was", "the", "best", "one", "yet" };

            var threeLetterWords = from word in words where word.Length == 3 select word;

            foreach (var word in threeLetterWords)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
