using System;
using System.Collections.Generic;
using System.Text;

namespace PrismDemo.Models
{
    public interface ILocation
    {
        string country { get; set; }
        string city { get; set; }
        string street { get; set; }
        string number { get; set; }
    }
}
