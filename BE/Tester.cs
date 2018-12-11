using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester: ICloneable
    {
        public enum eSex { Male, Female };


        #region fields
        private string _firstName;
        private string _lastName;
        private int _id;
        DateTime _bDay;
        private eSex _sex;
        private int _phoneNum;
        private Adress _adress;
        private int _experience;
        private int _maxTests;
        private Configuration.eTypeVechicle _typeVechicle;
        private bool[,] _timeToWork = new bool[6, 5]; // rows 6 => 9:00-15:00, cells 5=> SUN-THU
        private int _maxRouge;
        #endregion

        #region get&set
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Id { get => _id; set => _id = value; }
        public eSex Sex { get => _sex; set => _sex = value; }
        public int PhoneNum { get => _phoneNum; set => _phoneNum = value; }
        public Adress Adress { get => _adress; set => _adress = value; }
        public int Experience { get => _experience; set => _experience = value; }
        public int MaxTests { get => _maxTests; set => _maxTests = value; }
        public bool[,] TimeToWork { get => _timeToWork; set => _timeToWork = value; }
        public int MaxRouge { get => _maxRouge; set => _maxRouge = value; }
        public DateTime BDay { get => _bDay; set => _bDay = value; }
        public Configuration.eTypeVechicle TypeVechicle { get => _typeVechicle; set => _typeVechicle = value; }
        #endregion

        //ctor
        public Tester(string firstName, string lastName, int id, DateTime bday, eSex sex, int phoneNum, Adress adress, int experience, int maxTests, Configuration.eTypeVechicle typeVechicle, int maxRouge)
        {
            FirstName = firstName;
            LastName = lastName;
            _bDay = bday;
            Id = id;
            Sex = sex;
            PhoneNum = phoneNum;
            Adress = adress;
            Experience = experience;
            MaxTests = maxTests;
            TypeVechicle = typeVechicle;
            TimeToWork = new bool[5,6]; // default is false;
            MaxRouge = maxRouge;
        }


        #region Methods

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + FirstName + " " + LastName;
        }

        public object Clone()
        {
            return new Tester(_firstName,_lastName,_id, _bDay, _sex,_phoneNum,_adress,_experience,_maxTests,TypeVechicle,_maxRouge);
        }
        #endregion
    }
}