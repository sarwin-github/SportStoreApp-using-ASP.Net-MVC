using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Product product, int quantity)
        {
            //check for record
            CartLine line = lineCollection.Where
                            (p => p.Product.ProductID == product.ProductID)
                            .FirstOrDefault();
            //if record is null proceed to adding new record otherwise add quantity only
            if (line == null)
            {
                //linq query
                lineCollection.Add(
                        new CartLine
                        { Product = product, Quantity = quantity }
                    );
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        
        public void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(l => l.Product.ProductID == product.ProductID);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(s => s.Product.Price * s.Quantity); 
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }



    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
