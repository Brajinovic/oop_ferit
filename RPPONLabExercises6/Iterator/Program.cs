using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook(new List<Note>() { new Note("to do", "exam KM"), new Note("exam", "RPPON") });
            Iterator iterator = new Iterator(notebook);

            Console.WriteLine(iterator.Current.Text);
            Console.WriteLine(iterator.Next().Text);
            Console.ReadKey();
            
        }
    }
}
