using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {
        public enum eGearBox { Manual, Automatic }

        #region fields
        string _firstName;
        string _lastName;
        int _id;
        DateTime _bDay;
        Configuration.eSex _sex;
        int _phoneNum;
        Adress _adress;
        Configuration.eTypeVechicle _typeVechicle;
        eGearBox _gearBox;
        string _schoolName;
        string _teacherName;
        int _nLessons;
        DateTime _lastTest;
        string[] _testComplete;
        #endregion

        #region ctors
        public Trainee(string firstName, string lastName, int id, DateTime bDay, Configuration.eSex sex, int phoneNum, Adress adress, Configuration.eTypeVechicle typeVechicle, eGearBox gearBox, string schoolName, string teacherName, int nLessons)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            BDay = bDay;
            Sex = sex;
            PhoneNum = phoneNum;
            Adress = adress;
            TypeVechicle = typeVechicle;
            GearBox = gearBox;
            SchoolName = schoolName;
            TeacherName = teacherName;
            NLessons = nLessons;
            TestComplete = new string[Configuration.SUM_OF_eTypeVechicle];
        }

        // with last test
        public Trainee(string firstName, string lastName, int id, DateTime bDay, Configuration.eSex sex, int phoneNum, Adress adress, Configuration.eTypeVechicle typeVechicle, eGearBox gearBox, string schoolName, string teacherName, int nLessons, DateTime lastTest)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            BDay = bDay;
            Sex = sex;
            PhoneNum = phoneNum;
            Adress = adress;
            TypeVechicle = typeVechicle;
            GearBox = gearBox;
            SchoolName = schoolName;
            TeacherName = teacherName;
            NLessons = nLessons;
            LastTest = lastTest;
            TestComplete = new string[Configuration.SUM_OF_eTypeVechicle];
        }
        #endregion

        #region Methods
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime BDay { get => _bDay; set => _bDay = value; }
        public Configuration.eSex Sex { get => _sex; set => _sex = value; }
        public int PhoneNum { get => _phoneNum; set => _phoneNum = value; }
        public Adress Adress { get => _adress; set => _adress = value; }
        public eGearBox GearBox { get => _gearBox; set => _gearBox = value; }
        public string SchoolName { get => _schoolName; set => _schoolName = value; }
        public string TeacherName { get => _teacherName; set => _teacherName = value; }
        public int NLessons { get => _nLessons; set => _nLessons = value; }
        public int Id { get => _id; set => _id = value; }
        public DateTime LastTest { get => _lastTest; set => _lastTest = value; }
        public Configuration.eTypeVechicle TypeVechicle { get => _typeVechicle; set => _typeVechicle = value; }
        public string[] TestComplete { get => _testComplete; set => _testComplete = value; }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + FirstName + "  " + LastName;
        }
        #endregion
    }
}
