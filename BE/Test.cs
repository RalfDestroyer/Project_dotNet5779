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
        private DateTime _testDate;
        private DateTime _testDateReal;
        private Adress _start;
        private string _testArgs;
        private int _grade;
        private string _comment;
        #endregion

        //ctor
        public Test(int idTest, int idTester, int idTrainee, DateTime testDate, DateTime testDateReal, Adress start, string testArgs, int grade, string comment)
        {
            IdTest = idTest;
            IdTester = idTester;
            IdTrainee = idTrainee;
            TestDate = testDate;
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
        public DateTime TestDate { get => _testDate; set => _testDate = value; }
        public DateTime TestDateReal { get => _testDateReal; set => _testDateReal = value; }
        public Adress Start { get => _start; set => _start = value; }
        public string TestArgs { get => _testArgs; set => _testArgs = value; }
        public int Grade { get => _grade; set => _grade = value; }
        public string Comment { get => _comment; set => _comment = value; }
        #endregion
    }
}
