using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class BankMemento
    {
        public string OwnerName { get; set;}
        public string OwnerAddress { get; set; }
        public decimal Ballance { get; set; }
        public BankMemento(string ownerName, string ownerAddress, decimal accountBallance)
        {
            OwnerName = ownerName;
            OwnerAddress = ownerAddress;
            Ballance = accountBallance;
        }
    }
}
