using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            phoneBook.Add("Gjurgica", 077123456);
            phoneBook.Add("Mario", 076123456);
            phoneBook.Add("Violeta", 071456654);
            phoneBook.Add("Nikola", 077897987);
            phoneBook.Add("Vasil", 078765432);
            Console.WriteLine("Enter a name");
            string answer = Console.ReadLine();
            if (phoneBook.ContainsKey(answer))
            {
                Console.WriteLine($"The number of {answer} is {phoneBook[answer]}");
            }
            else
            {
                Console.WriteLine("This name don't exist in this phoneBook");
            }
            Console.ReadLine();
        }
    }
}
