using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Box: IAbstractBox
    {
        private List<Product> products;
        public Box() { 
            this.products = new List<Product>(); 
        }
        public Box(List<Product> products)
        {
            this.products = new List<Product>(products.ToArray());
        }
        public void AddProduct(Product product) { this.products.Add(product); }
        public void RemoveProduct(Product product) { this.products.Remove(product); }
        public void Clear()
        {
            products.Clear();
        }
        public int Count { get { return this.products.Count; } }
        public Product this[int index] { get { return this.products[index]; } }
        public IBoxIterator GetIterator() { return new BoxIterator(this); }
    }
}
