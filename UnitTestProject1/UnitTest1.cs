using Exercise_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Student st4 = new Student("Georg", "Roskilde", Person.Gender.Male, 4);

        [TestMethod]
        public void StudentTest()
        {
            Student st = new Student("John","NotEmptyAddress",Person.Gender.Male,3);
            Assert.AreEqual("NotEmptyAddress", st.Address);
            Assert.AreEqual("John", st.Name);
            Assert.AreEqual(Student.Gender.Male, st.gender);
            Assert.AreEqual( 3, st.Semester);
        }
        [TestMethod]
        public void TeacherTest()
        {
            Teacher t = new Teacher("TeacherBoii","NotEmpty",-100.0,Teacher.Gender.Male);
            Assert.AreEqual("NotEmpty", t.Address);
            Assert.AreEqual("TeacherBoii", t.Name);
            Assert.AreEqual(Teacher.Gender.Male, t.gender);
            Assert.AreEqual(-100.0, t.Salary);
        }
        [TestMethod]
        public void StudentEquals()
        {
            Student st1 = new Student("Johnie", "NotEmptyAddress1", Person.Gender.Male, 4);
            Student st2 = new Student("JohnJohn", "NotEmptyAddress2", Person.Gender.Female, 2);
           // bool x = st1.Equals(st2);
            Assert.AreEqual(st1, st1);
        }
        [TestMethod]
        public void StudentToString()
        {
            Student st4 = new Student("Georg", "Roskilde", Person.Gender.Male, 4);
          
            Assert.AreEqual("GeorgRoskildeMale4" , st4.ToString());
        }
    }
}
