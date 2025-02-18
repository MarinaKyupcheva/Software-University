﻿using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DefineAClassPerson
{
    public class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }
       public List<Person> Members { get; set; }

        public void AddMember (Person person)
        {
            Members.Add(person);
        }
        public Person GetOldestMember()
        {
            Person person = this.Members
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();
            return person;
        }


    }
}
