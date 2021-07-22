
using System;


namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 50.9,
                Height = 35.1,
                Stories = 1,

            };
            Building TheCabin = new Building("1111 Banner Elk Hollow")
            {
                Width = 650.5,
                Height = 400.5,
                Stories = 5,

            };
            Building Rexmere = new Building("1 Laborde Way")
            {
                Width = 1150.5,
                Height = 275.5,
                Stories = 4,
            };

            FiveOneTwoEigth.Purchase("Myspace Tom");
            TheCabin.Purchase("Charles Macgowan");
            Rexmere.Purchase("The Labordes");
            City megalopolis = new City()
            {
                Name = "Megalopolis",
                Mayor = "Doug Dimmadome",
            };
            megalopolis.AddBuilding(FiveOneTwoEigth);
            megalopolis.AddBuilding(TheCabin);
            megalopolis.AddBuilding(Rexmere);

            foreach (Building building in megalopolis.Buildings)
            {
                Console.WriteLine($"{building.Address()}-------------\nDesigned by {building.Designer()}\nConstruced on {building.Construct()}\nOwned by {building.Owner()}\n{building.Volume} cubic meters of space");
                Console.WriteLine("");
            }
        }
    }
}
