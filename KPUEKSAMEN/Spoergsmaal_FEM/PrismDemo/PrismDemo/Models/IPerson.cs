using System;
using System.Collections.Generic;
using System.Text;

namespace PrismDemo.Models
{
    public interface IPerson
    {
        string name { get; set; }
        int age { get; set; }
        string sex { get; set; }
    }
}
