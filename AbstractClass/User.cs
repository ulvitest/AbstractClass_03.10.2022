using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public  class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public User()
        {

        }

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void Info()
        {
            Console.WriteLine(Name + " " + Surname);
        }
    }
}
