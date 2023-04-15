using System;
using System.Collections;
namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelve Shelve1 = new Shelve("A");
            Sector Sector1 = new Sector ("1");
            Shelve Shelve2 = new Shelve("B");
            Shelve1.agregarlibro (book1);
            Shelve2.agregarlibro(book2);        
            Sector1.agregarshelve(Shelve1);
            Sector1.agregarshelve(Shelve2);
        Console.WriteLine(Sector1.ToString());
        }
    }
}