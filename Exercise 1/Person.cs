using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
   public  class Person
    {
        public enum Gender { Male, Female }
        private string _address;
        private string _name;

        public Person(string name, string address, Gender gender)
        {
            Name = name;
            Address = address;
            this.gender = gender;
        }

        public string Name
        {
            get => _name;
            set { if (value.Length >= 2) _name = value; else throw new Exception(); }
        }
        public string Address
        {
            get => _address;
            set { if (value != String.Empty) _address = value; else throw new Exception(); }
        }
        public Gender gender { get; set; }

        public virtual bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public virtual int GetHashCode()
        {
            return base.GetHashCode();
        }

        public virtual string ToString()
        {
            return base.ToString();
        }
    }
}
