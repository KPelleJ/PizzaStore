using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        private string _name;
        private string _email;
        private string _phoneNr;

        public Customer(string name, string email, string phoneNr)
        { 
            _name = name;
            _email = email;
            _phoneNr = phoneNr;
        }
        
        public string Name 
        { get { return _name; } }

        public string Email
        { get { return _email; } }

        public string PhoneNr
        { get { return _phoneNr; } }
    }
}
