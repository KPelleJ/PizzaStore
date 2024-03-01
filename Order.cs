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
        private string _customerName;
        private string _customerEmail;
        private string _customerPhone;
        private double _totalPrice;
        Pizza pizza1;

        private static int _idCounter = 1;

        public Order(string customerName, string customerEmail, string customerPhone)
        {
            _customerName = customerName;
            _customerEmail = customerEmail;
            _customerPhone = customerPhone;
            _idCounter++;
        }

        public int Id
        { get { return _id; } }

        public string CustomerName
        { get { return _customerName; } }

        public double TotalPrice
        { get { return _totalPrice; } }


        public double CalculateTotalPrice()
        {
            return _totalPrice = pizza1.Price ;
        }

        public override string ToString()
        {
            return $"N{CustomerName} \n E{_customerEmail} \nP{_customerPhone}";
        }
    }

    

    
}
