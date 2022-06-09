using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Accountant
    {
        private List<BankMemento> mementos;

        public Accountant()
        {
            mementos = new List<BankMemento>();
        }
        public BankMemento GetAccount(int index)
        {
            return mementos[index];
        }

        public void StoreAccount(BankMemento bankMemento)
        {
            mementos.Add(bankMemento);
        }
    }
}
