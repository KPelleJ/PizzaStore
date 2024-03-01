using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        private int _number;
        private string _name;
        private string _topping;
        private double _price;

        public Pizza(int number, string name, string topping, double price)
        {
            _name = name;
            _topping = topping;
            _price = price;
            _number = number;
        }

        public string Name 
        { get { return _name;} }
    
        public string Topping
        { get { return _topping;} }

        public double Price
        { get { return _price;} }

        public int Number
        { get { return _number;} }

        public override string ToString()
        {
            return $"Nr. {Number} {Name} \n {Topping} \n {Price}kr \n";
        }

    }
}
