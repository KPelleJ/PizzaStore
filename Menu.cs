using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Menu
    {
        private string _name;
        private Pizza _pizza1;
        private Pizza _pizza2;
        private Pizza _pizza3;
        private Pizza _pizza4;
        
        public Menu(string name)
        {
            _name = name;
            _pizza1 = new Pizza(1, "Pepito", "Cheese, Ham, French Fries", 65);
            _pizza2 = new Pizza(2, "Senioritã", "Tomato, Mozzarella, Prosciutto Cotto, Portobello & Thyme", 82);
            _pizza3 = new Pizza(3, "Sloppy Joe", "Mozzarella, Bolognese, Parmigiano Reggiano & Red Irish Cheddar.", 115);
            _pizza4 = new Pizza(4, "Don Corleone", "Mozzarella, Ham italiano, Chorizo", 105);
        }

        public string Name
        { get { return _name; } }

        public Pizza Pizza1
            { get { return _pizza1; } }

        public Pizza Pizza2
        {  get { return _pizza2; } }

        public Pizza Pizza3
        { get { return _pizza3; } }

        public Pizza Pizza4
        {  get { return _pizza4; } }
       

        public override string ToString()
        {
            return $"Welcome to Big mammas pizza \n THE MENU \n \n {_pizza1} \n {_pizza2} \n {_pizza3} \n {_pizza4} \n Sales tax 5% \n Delivery 20kr \n ";
        }
    }
}
