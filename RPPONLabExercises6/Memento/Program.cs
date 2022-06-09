using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Memento record1 = new Memento("jedan", "", DateTime.Now, DateTime.Now);
            Memento record2 = new Memento("dva", "", DateTime.Now, DateTime.Now);
            Memento record3 = new Memento("tli", "", DateTime.Now, DateTime.Now);

            CareTaker careTaker = new CareTaker();
            careTaker.StoreMemento(record1);
            careTaker.StoreMemento(record2);
            careTaker.StoreMemento(record3);
            Console.WriteLine(careTaker.GetMemento(1).Title);

            BankMemento account1 = new BankMemento("john", "rico", (decimal)0.000000001);
            BankMemento account2 = new BankMemento("jovan", "osijek bb", (decimal)999.03234);

            Accountant accountant = new Accountant();
            accountant.StoreAccount(account1);
            accountant.StoreAccount(account2);

            Console.WriteLine(accountant.GetAccount(0).Ballance);
            Console.ReadKey();
        }
    }
}
