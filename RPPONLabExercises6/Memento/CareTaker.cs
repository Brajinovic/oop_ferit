using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class CareTaker
    {
        private List<Memento> mementos;

        public CareTaker()
        {
            mementos = new List<Memento>();
        }
        public Memento GetMemento(int index)
        {
            return mementos[index];
        }
    
        public void StoreMemento(Memento memento)
        {
            mementos.Add(memento);
        }
    }
}
