using System;
using System.Security.Cryptography;
using System.Text;

namespace Exercise_1
{
    public class Student : Person
    {
        private int _semester;
     
        public int Semester
        {
            get => _semester;
            set { if (1 <= value && value <= 8) _semester = value; else throw new ArgumentOutOfRangeException(); }
        }
       
        public Student(string name, string address, Gender gender, int semester) : base(name, address, gender)
        {
            _semester = semester;
        }
        public override string ToString()
        {
            return Name + Address + gender + Semester;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)

            {

                return false;

            }

            Student personObj = obj as Student;

            if (personObj == null)

            {

                return false;

            }

            return Equals(personObj);
        }
        public override int GetHashCode()
        {

            return this.Name.GetHashCode() ;
        }
        public static string SHA256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        #region Not used duplicated code solved by inheritance
        //private string _address;
        //private string _name;
        //public enum Gender { Male, Female }

        //public string Name
        //{
        //    get => _name;
        //    set {if(value.Length >= 2)  _name = value; }
        //}
        //public string Address
        //{
        //    get => _address;
        //    set { if (value != String.Empty) _address = value; else throw new Exception(); }
        //}
        //public Gender gender { get; set; }

        //public Student(string name, string address, int semester, Gender gender)
        //{
        //    Name = name;
        //    Address = address;
        //    Semester = semester;
        //    this.gender = gender;
        //}
        #endregion
    }
}
    