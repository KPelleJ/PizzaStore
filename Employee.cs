using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Employee
    {
        private string _name;
        private int _workerId;
        private string _title;

        public Employee(string name, int workderId, string title)
        {
            _name = name;
            _workerId = workderId;
            _title = title;
        }

        public string Name 
        { get { return _name; } }

        public int WorkerId 
        { get { return _workerId; } }

        public string Title
        { get { return _title; } }
    }
}
