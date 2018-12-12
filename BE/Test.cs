using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        #region fields
        private int _idTest;
        private int _idTester;
        private int _idTrainee;
        private DateTime _testDateAsked;
        private DateTime _testDateReal;
        private Adress _start;
        private List<TestArgs> _testArgs;
        private bool? _grade;
        private string _comment;
        private Configuration.eTypeVechicle _typeVechicle;

        public Test(int idTest, int idTester, int idTrainee, DateTime testDateAsked, DateTime testDateReal, Adress start, Configuration.eTypeVechicle typeVechicle, bool? grade, List<TestArgs> testArgs, string comment)
        {
            IdTest = idTest;
            IdTester = idTester;
            IdTrainee = idTrainee;
            TestDateAsked = testDateAsked;
            TestDateReal = testDateReal;
            Start = start;
            TypeVechicle = typeVechicle;
            Grade = grade;
            TestArgs = testArgs;
            Comment = comment;
        }

        #endregion

        //ctor


        #region get&set
        public int IdTest { get => _idTest; set => _idTest = value; }
        public int IdTester { get => _idTester; set => _idTester = value; }
        public int IdTrainee { get => _idTrainee; set => _idTrainee = value; }
        public DateTime TestDateAsked { get => _testDateAsked; set => _testDateAsked = value; }
        public DateTime TestDateReal { get => _testDateReal; set => _testDateReal = value; }
        public Adress Start { get => _start; set => _start = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public Configuration.eTypeVechicle TypeVechicle { get => _typeVechicle; set => _typeVechicle = value; }
        public bool? Grade { get => _grade; set => _grade = value; }
        public List<TestArgs> TestArgs { get => _testArgs; set => _testArgs = value; }
        #endregion


        #region Methods

        public override string ToString()
        {
            return "Id: " + IdTest + " Id tester: " + IdTester + " Id trainee " + IdTrainee;
        }
        #endregion
    }
}
