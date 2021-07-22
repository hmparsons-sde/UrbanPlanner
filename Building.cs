using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        //Private Fields
        private string _designer = "Holly Parsons";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address = "123 electric avenue, nashville, tn, 37206";
        private string _owner = "Holly Parsons";

        public int Stories { get; set; } = 2;
        public double Width { get; set; } = 50.2;
        public double Height { get; set; } = 65.5;
        public double Volume
        {
            get => Width * Height * (3 * Stories);
        }
        public Building(string address)
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
        public string Designer() => _designer;
        public string Address() => _address;
        public string Owner() => _owner;

    }
}
