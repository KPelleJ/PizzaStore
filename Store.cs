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
        private Menu menu1;
        private Customer customer1;
        private Customer customer2;
        private Customer customer3;
        private Order order1;
        private Order order2;
        private Order order3;

        public Store(string name, string address, string phoneNr)
        {
            _name = name;
            _address = address;
            _phoneNr = phoneNr;
            menu1 = new Menu("Big Mammas Pizza");
        }

        public string Name
        { get { return _name; } }

        public string Address
        { get { return _address; } }

        public string PhoneNr
        { get { return _phoneNr; } }

        public void start()
        {
            customer1 = new Customer("Benny", "Benny@mail.com", "72939281");
            customer2 = new Customer("Yvonne", "Egon.er.dum@mail.com", "78972733");
            customer3 = new Customer("Bøffen", "Hard_Knock_life@mail.com", "87293388");
            order1 = new Order(customer1,menu1.Pizza1);
            order2 = new Order(customer2,menu1.Pizza3);
            order3 = new Order(customer3,menu1.Pizza4);
        }

        public override string ToString()
        {
            return $"{menu1}";
        }

        public string CustomerInfo(int id)
        {
            if (id == 1)
            { return $"{customer1}"; }
            else if (id == 2)
            { return $"{customer2}"; }
            else if (id == 3)
            { return $"{customer3}"; }
            else
            { return "There is no customer with that ID"; }
        }

        public string OrderInfo()
        {
            return $"{order1} \n \n {order2} \n \n {order3}";
        }
    }

}
