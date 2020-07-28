using System.Collections.Generic;

namespace LocationModule
{
    class Location : ILocation
    {
        public Location(string country, string city, string street, string number)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.number = number;
        }

        public List<string> GetAll()
        {
            var locations = new List<string>
            {
                "Denmark, Aarhus, Svanevej, 65)"
                //new Location("Denmark", "Aarhus", "Svanevej", "65"),
                //new Location("Denmark", "Aarhus", "Andevej", "64"),
                //new Location("Denmark", "Aarhus", "duevej", "63")
            };
            return locations;
        }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string number { get; set; }
    }
}
