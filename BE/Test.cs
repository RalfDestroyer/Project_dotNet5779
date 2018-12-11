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
        private string _testArgs;
        private int _grade;
        private string _comment;
        #endregion

        //ctor
        public Test(int idTest, int idTester, int idTrainee, DateTime testDateAsked, DateTime testDateReal, Adress start, string testArgs, int grade, string comment)
        {
            IdTest = idTest;
            IdTester = idTester;
            IdTrainee = idTrainee;
            TestDateAsked = testDateAsked;
            TestDateReal = testDateReal;
            Start = start;
            TestArgs = testArgs;
            Grade = grade;
            Comment = comment;
        }

        #region get&set
        public int IdTest { get => _idTest; set => _idTest = value; }
        public int IdTester { get => _idTester; set => _idTester = value; }
        public int IdTrainee { get => _idTrainee; set => _idTrainee = value; }
        public DateTime TestDateAsked { get => _testDateAsked; set => _testDateAsked = value; }
        public DateTime TestDateReal { get => _testDateReal; set => _testDateReal = value; }
        public Adress Start { get => _start; set => _start = value; }
        public string TestArgs { get => _testArgs; set => _testArgs = value; }
        public int Grade { get => _grade; set => _grade = value; }
        public string Comment { get => _comment; set => _comment = value; }
        #endregion


        #region Methods

        public override string ToString()
        {
            return "Id: " + IdTest + " Id tester: " + IdTester + " Id trainee " + IdTrainee;
        }
        #endregion
    }
}
