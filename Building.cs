using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        //Private Fields
        // Fields typically store the data that must be accessible to more than one class method and must be stored for longer than the lifetime of any single method.
        // an underscore denotes private fields.
        private string _designer = "Holly Parsons";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address = "123 electric avenue, nashville, tn, 37206";
        private string _owner = "Holly Parsons";

        public int Stories { get; set; } = 2; // REMINDER: A get property accessor is used to return the property value, and a set property accessor is used to assign a new value. 
        public double Width { get; set; } = 50.2;
        public double Height { get; set; } = 65.5;
        public double Volume
        {
            get => Width * Height * (3 * Stories); // read-only
        }
        public Building(string address) // REMINDER: Constructors set default values & limit instantiation
        {
            _address = address;
        }
        public DateTime Construct()
        {
            _dateConstructed = DateTime.Now;
            return _dateConstructed;
        }
        public string Purchase(string newOwner)
        {
            _owner = newOwner;
            return _owner;
        }
        public string Designer() => _designer; // REMINDER: If a constructor can be implemented as a single statement, you can use an expression body definition
        public string Address() => _address;
        public string Owner() => _owner;

    }
}
