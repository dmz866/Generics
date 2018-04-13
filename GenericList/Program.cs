using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(1);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<int, string>();
            dictionary.Add(1, "David");

            //NET Framework has already System.Nullable<>
            var n = new Nullable<int>(5);
            Console.WriteLine("Has Value? " + n.HasValue);
            Console.WriteLine("Value: " + n.GetValueOrDefault());
        }
    }
}
