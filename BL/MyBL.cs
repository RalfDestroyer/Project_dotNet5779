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

            if ( ((DateTime.Now.Date - tester.BDay).TotalDays / Configuration.DAYS_IN_YEAR) < Configuration.MIN_OLD_TESTER)
                throw new Exception("The old of tester must to be bigger than 40 years");


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
            if (((DateTime.Now.Date - tester.BDay).TotalDays / Configuration.DAYS_IN_YEAR) < Configuration.MIN_OLD_TESTER)
                throw new Exception("The old of tester must to be bigger than 40 years");


            MyDal.UpdateTester(tester);
            return;
        }
        #endregion
        
        #region Trainee
        public void AddTrainee(Trainee trainee)
        {
            if (((DateTime.Now.Date - trainee.BDay).TotalDays / Configuration.DAYS_IN_YEAR) < Configuration.MIN_OLD_TRAINEE)
                throw new Exception("The old of tester must to be bigger than 40 years");


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
            if (((DateTime.Now.Date - trainee.BDay).TotalDays / Configuration.DAYS_IN_YEAR) < Configuration.MIN_OLD_TRAINEE)
                throw new Exception("The old of tester must to be bigger than 40 years");

            MyDal.UpdateTrainee(trainee);
            return;
        }
        #endregion

        #region Test
        public void AddTest(Test test)
        {
            if(getTreinee(test.IdTrainee) == null)
                throw new Exception("The trainee not found");
            if (getTester(test.IdTester) == null)
                throw new Exception("The tester not found");


            MyDal.AddTest(test);
            return;
        }

        public void RemoveTest(Test test)
        {
            throw new NotImplementedException();
        }

        public void UpdateTest(Test test)
        {
            throw new NotImplementedException();
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
        #endregion

    }

}
