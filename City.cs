using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>(); // Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.

        private int _yearEstablished = 1779;

        public void AddBuilding(Building building)
        {
            Buildings.Add(building); // Adds an object to the end of the list.
        }
        public int showYear() => _yearEstablished;

    }
}
