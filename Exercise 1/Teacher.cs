using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class Teacher : Person
    {
        private double _salary;

        public double Salary
        {
            get => _salary;
            set { if (value <= 0) _salary = value; else throw new Exception(); }
        }

        public Teacher(string name, string address, double salary , Gender gender) : base(name, address, gender)
        {
            _salary = salary;
        }

        #region Not used duplicated code solved by inheritance
        //private string _address;
        //private string _name;

        //public Teacher(string name, string address, double salary, Gender gender)
        //{
        //    Name = name;
        //    Address = address;
        //    Salary = salary;
        //    this.gender = gender;
        //}

        //public enum Gender { Male, Female }

        //public string Name
        //{
        //    get => _name;
        //    set { if (value.Length >= 2) _name = value; else throw new Exception(); }
        //}
        //public string Address
        //{
        //    get => _address;
        //    set { if (value != String.Empty) _address = value; else throw new Exception(); }
        //}

        //public Gender gender { get; set; }
        #endregion
    }
}
