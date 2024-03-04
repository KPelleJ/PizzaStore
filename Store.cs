using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {
        private string _name;
        private string _address;
        private string _phoneNr;
        private Menu _menu1;
        private Customer? _customer1;
        private Customer? _customer2;
        private Customer? _customer3;
        private Order? _order1;
        private Order? _order2;
        private Order? _order3;

        public Store(string name, string address, string phoneNr)
        {
            _name = name;
            _address = address;
            _phoneNr = phoneNr;
            _menu1 = new Menu("Big Mammas Pizza");
        }

        public string Name
        { get { return _name; } }

        public string Address
        { get { return _address; } }

        public string PhoneNr
        { get { return _phoneNr; } }

        public void start()
        {
            _customer1 = new Customer("Benny", "Benny@mail.com", "72939281");
            _customer2 = new Customer("Yvonne", "Egon.er.dum@mail.com", "78972733");
            _customer3 = new Customer("Bøffen", "Hard_Knock_life@mail.com", "87293388");
            _order1 = new Order(_customer1,_menu1.Pizza1);
            _order2 = new Order(_customer2,_menu1.Pizza3);
            _order3 = new Order(_customer3,_menu1.Pizza4);
        }

        public override string ToString()
        {
            return $"{_menu1}";
        }

        public string CustomerInfo(int id)
        {
            if (id == 1)
            { return $"{_customer1}"; }
            else if (id == 2)
            { return $"{_customer2}"; }
            else if (id == 3)
            { return $"{_customer3}"; }
            else
            { return "There is no customer with that ID"; }
        }

        public string OrderInfo()
        {
            return $"{_order1} \n \n {_order2} \n \n {_order3}";
        }
    }

}
