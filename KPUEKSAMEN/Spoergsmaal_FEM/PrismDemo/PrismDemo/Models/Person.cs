using System;
using System.Collections.Generic;
using System.Text;

namespace PrismDemo.Models
{
    public class Person : IPerson
    {
        public Person(string name, int age, string sex )
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        public string name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
    }
}
