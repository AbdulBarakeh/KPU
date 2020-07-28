using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleModule
{
    public interface IPerson
    {
        string name { get; set; }
        int age { get; set; }
        string sex { get; set; }
        List<IPerson> GetAll();

    }
}
