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
        private Pizza pizza1;
        private Pizza pizza2;
        private Pizza pizza3;
        private Pizza pizza4;
        
        public Menu(string name)
        {
            _name = name;
            pizza1 = new Pizza(1, "Pepito", "Cheese, Ham, French Fries", 65);
            pizza2 = new Pizza(2, "Senioritã", "Tomato, Mozzarella, Prosciutto Cotto, Portobello & Thyme", 82);
            pizza3 = new Pizza(3, "Sloppy Joe", "Mozzarella, Bolognese, Parmigiano Reggiano & Red Irish Cheddar.", 115);
            pizza4 = new Pizza(4, "Don Corleone", "Mozzarella, Ham italiano, Chorizo", 105);
        }

        public string Name
        { get { return _name; } }

        public override string ToString()
        {
            return $"Welcome to Big mammas pizza \n THE MENU \n \n {pizza1} \n {pizza2} \n {pizza3} \n {pizza4}  ";
        }
    }
}
