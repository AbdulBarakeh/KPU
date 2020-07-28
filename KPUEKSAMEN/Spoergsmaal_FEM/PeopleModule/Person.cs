using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleModule
{
    public class Person : IPerson
    {
        public Person(string name, int age, string sex )
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public List<IPerson> GetAll()
        {
            var people = new List<IPerson>
            {
                new Person("Dan Sigel", 36, "Male"),
                new Person("Emma", 26, "Female"),
                new Person("Martin Fowler", 48, "Male")
            };
            return people;
        }
        public string name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
    }
}
