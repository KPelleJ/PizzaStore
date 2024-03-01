using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Order
        {
        private int _id;
        private double _totalPrice;
        private double _salesTax;
        private double _delivery;
        Pizza _pizza; 
        Customer _customer;

        private static int _idCounter = 1000;

        public Order(Customer customer, Pizza pizza)
        {
            _id = _idCounter++;
            _customer = customer;
            _pizza = pizza;
            _salesTax = 0.05;
            _delivery = 20;
            CalculateTotalPrice();
        }

        public double TotalPrice
        { get { return _totalPrice; } }

        public double CalculateTotalPrice()
        {
            return _totalPrice =((_pizza.Price)*(1+_salesTax))+_delivery;
        }

        public override string ToString()
        {
            return $"Order number {_id} \n {_pizza.Name} \n Price: {_totalPrice}kr";
        }
    }

    

    
}
