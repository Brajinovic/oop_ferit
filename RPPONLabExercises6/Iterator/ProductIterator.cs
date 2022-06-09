using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ProductIterator:IBoxIterator
    {
        private Box shoppingCart;
        private int currentPosition;
        public ProductIterator(Box shoppingCart)
        {
            this.shoppingCart = shoppingCart;
            this.currentPosition = 0;
        }
        public bool IsDone { get { return this.currentPosition >= this.shoppingCart.Count; } }
        public Product Current { get { return this.shoppingCart[this.currentPosition]; } }
        public Product First() { return this.shoppingCart[0]; }
        public Product Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else
            {
                return this.shoppingCart[this.currentPosition];
            }
        }
    }
}
