namespace PrismDemo.Models
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
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string number { get; set; }
    }
}
