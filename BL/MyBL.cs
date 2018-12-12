using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BE;
using DAL;


namespace BL
{
    public class MyBL: IBL
    {
        #region Singleton
        private static readonly MyBL instance = new MyBL();

        public static MyBL Instance
        {
            get { return instance; }
        }
        #endregion

        #region MyDAL = DAL in fact!
        static IDAL MyDal;

        static MyBL()
        {
            MyDal = DAL_List.Instance;
        }
        #endregion

        #region Tester
        public void AddTester(Tester tester)
        {
            if (logicTester(tester) == true)
                MyDal.AddTester(tester);

            return;
        }

        public void RemoveTester(Tester tester)
        {
            MyDal.RemoveTester(tester);
            return;
        }

        public void UpdateTester(Tester tester)
        {
            if (logicTester(tester) == true)
                MyDal.UpdateTester(tester);

            return;
        }
        #endregion
        
        #region Trainee
        public void AddTrainee(Trainee trainee)
        {
            if (logicTrainee(trainee) == true)
                MyDal.AddTrainee(trainee);

            return;
        }

        public void RemoveTrainee(Trainee trainee)
        {
            MyDal.RemoveTrainee(trainee);
            return;
        }

        public void UpdateTrainee(Trainee trainee)
        {
            if (logicTrainee(trainee) == true)
                MyDal.UpdateTrainee(trainee);
            
            return;
        }
        #endregion

        #region Test
        public void AddTest(Test test)
        {
            if (logicTest(test) == true)
                MyDal.AddTest(test);


            //else need to update tester and treinee
            return;
        }

        public void RemoveTest(Test test)
        {
            MyDal.RemoveTest(test);
            return;
        }

        public void UpdateTest(Test test)
        {
            if (logicTest(test) == true)
                MyDal.UpdateTest(test);
          
            return;
        }
        #endregion

        #region getLists
        public BindingList<Tester> getTesterList()
        {
            return MyDal.GetTestersList();
        }
        public BindingList<Trainee> getTraineeList()
        {
            return MyDal.GetTraineesList();
        }
        public BindingList<Test> getTestList()
        {
            return MyDal.GetTestsList();
        }
        private Trainee getTreinee(int id)
        {
            return MyDal.GetTrainee(id);
        }
        private Tester getTester(int id)
        {
            return MyDal.GetTester(id);
        }
        public BindingList<Tester> getTesterListInXRouge(Adress adress)
        {
            Random randRouge = new Random();
            int rouge = randRouge.Next();
            return new BindingList<Tester>(MyDal.GetTestersList().ToList().FindAll(tstr => tstr.MaxRouge == rouge));
        }
        public BindingList<Tester> getTesterListFreeInDate(DateTime dateTime)
        {
            return new BindingList<Tester>(MyDal.GetTestersList().ToList().FindAll
                (tstr => tstr.TimeToWork[cell(dateTime.DayOfWeek.ToString()), row(dateTime.Hour.ToString())] == false));
        }
        public BindingList<Test> getTesterListInMonth(DateTime dateTime)
        {
            return new BindingList<Test>(MyDal.GetTestsList().ToList().FindAll
                (tst => tst.TestDateReal.Month == dateTime.Month));
        }
        public BindingList<Test> getTesterListInDay(DateTime dateTime)
        {
            return new BindingList<Test>(MyDal.GetTestsList().ToList().FindAll
                (tst => tst.TestDateReal.Day == dateTime.Day));
        }

        #endregion

        #region METHODS
        private int cell(string day)
        {
            switch (day)
            {
                case "Sunday": return 0;
                case "Monday": return 1;
                case "Tuesday": return 2;
                case "Wednesday": return 3;
                case "Thursday": return 4;
                case "Friday": return 5;
                case "Saturday": return 6;
                default: return 7;
            }
        }
        private int row(string time)
        {
            switch (time)
            {
                case "9": return 0;
                case "10": return 1;
                case "11": return 2;
                case "12": return 3;
                case "13": return 4;
                case "14": return 5;
                case "15": return 6;
                default: return 7;
            }
        }
        public bool acceptDrivingLicence(Trainee trainee)
        {
            return MyDal.GetTestsList().ToList().Exists(tst => ((tst.Grade == true) && (tst.TypeVechicle == trainee.TypeVechicle)));
        }
        public int sumOfTests(Trainee trainee)
        {
            BindingList<Test> list = new BindingList<Test>(MyDal.GetTestsList().ToList().FindAll(tst => tst.IdTrainee == trainee.Id));
            return list.Count;
        }
        public bool mostArgsTrue(Test test)
        {
            int couterTrue = 0, counterFalse = 0;
            foreach (var item in test.TestArgs)
            {
                if (item.Pass == true)
                    couterTrue++;
                else
                    counterFalse++;
            }
            if (couterTrue > counterFalse)
                return true;
            else
                return false;
        }
        private bool logicTest(Test test)
        {
            Tester tester = getTester(test.IdTester);
            Trainee trainee = getTreinee(test.IdTrainee);

            if (tester == null)
            {
                throw new Exception("The trainee not found");
            }
            if (trainee == null)
            {
                throw new Exception("The tester not found");
                
            }

            if (trainee.TypeVechicle != tester.TypeVechicle) { 
                throw new Exception("The testers and trainee type vechicle are not same");
                
            }
            if (((DateTime.Now.Date - trainee.LastTest).TotalDays) < Configuration.MIN_DAYS_BETWEEN_TESTS)
            {
                throw new Exception("Test can`t be so close to previous");
                
            }
            if (tester.TimeToWork[cell(test.TestDateAsked.DayOfWeek.ToString()), row(test.TestDateAsked.Hour.ToString())] == true)
            { 
                throw new Exception("Test in this day is catched in this Tester");
                
            }
            if (trainee.LastTest == test.TestDateAsked)
            { 
                throw new Exception("Trainee have test in this time already");
                
            }
            if (test.TestDateAsked == trainee.LastTest)
            { 
                throw new Exception("Test in this day is catched in this Trainee");
                
            }
            if (tester.CounterTests >= Configuration.MAX_TESTS_IN_WEEK)
            {
                throw new Exception("this tester have a lot of tests, he is busy");
                
            }
            if (MyDal.GetTestsList().ToList().Exists(stud => ((stud.IdTrainee == trainee.Id) && (stud.TypeVechicle == trainee.TypeVechicle)))) { 
                throw new Exception("Trainee finish this test before");
                
            }

            return true;
        }
        private bool logicTrainee(Trainee trainee)
        {
            if (((DateTime.Now.Date - trainee.BDay).TotalDays / Configuration.DAYS_IN_YEAR) < Configuration.MIN_OLD_TRAINEE) {
                throw new Exception("The old of tester must to be bigger than 40 years");
            }
            if (trainee.NLessons < Configuration.MIN_COUTN_OF_LESSONS) {
                throw new Exception("The count of lessons too small");
            }

            return true;
        }
        private bool logicTester(Tester tester)
        {
            if (((DateTime.Now.Date - tester.BDay).TotalDays / Configuration.DAYS_IN_YEAR) < Configuration.MIN_OLD_TESTER) {
                throw new Exception("The old of tester must to be bigger than 40 years");
            }

            return true;
        }
        #endregion
    }

}
