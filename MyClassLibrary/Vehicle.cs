using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public abstract class Vehicle
    {
        string _name;

        protected Vehicle(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"{GetType()} - {_name}";
        }

        
    }
}
