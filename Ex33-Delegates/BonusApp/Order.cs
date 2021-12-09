using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public delegate double BonusProvider(double amount);

    public class Order
    {
        List<Product> prod = new List<Product>();
        //public BonusProvider Bonus;
        public BonusProvider Bonus { get; set; }
        
        public void AddProduct(Product p)
        {
            prod.Add(p);
        }
        public double GetValueOfProducts()
        {
            double total = prod.Sum(x => x.Value); //Finder den totale Værdi af product.
            return total;
        }
        public double GetBonus()
        {
            //benytter ordrens delegate til at udregne bonus af den samlede værdi af de tilknyttede Product-objekter
            return Bonus(GetValueOfProducts());
        }
        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }

    }
}
