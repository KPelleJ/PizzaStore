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

        public Store(string name, string address, string phoneNr) 
        { 
            _name = name;
            _address = address;
            _phoneNr = phoneNr;
        }

        public string Name
        { get { return _name; } }

        public string Address
        { get { return _address; } }

        public string PhoneNr 
        { get { return _phoneNr;} }
    }
}
