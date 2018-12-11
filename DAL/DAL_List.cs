using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;
using System.ComponentModel;

namespace DAL
{
    public class DAL_List: IDAL
    {
        #region Singleton
        private static readonly DAL_List instance = new DAL_List();

        public static DAL_List Instance
        {
            get { return instance; }
        }

        static DAL_List()
        {
        }
        private DAL_List() { }
        #endregion

        #region Methods

        public void AddTest(Test addingTest)
        {
            if (!(DataSource.testsList.ToList().Exists(testInList => testInList.IdTest == addingTest.IdTest)))
            {
                DataSource.testsList.Add(addingTest);
            }
            return;
        }

        public void AddTester(Tester addingTester)
        {
            if (!(DataSource.testersList.ToList().Exists(testersInList => testersInList.Id == addingTester.Id)))
            {
                DataSource.testersList.Add(addingTester);
            }
            return;
        }

        public void AddTrainee(Trainee addingTrainee)
        {
            if (!(DataSource.traineesList.ToList().Exists(traineeInList => traineeInList.Id == addingTrainee.Id)))
            {
                DataSource.traineesList.Add(addingTrainee);
            }
            return;
        }

        public BindingList<Tester> GetTestersList()
        {
            return new BindingList<Tester>(DataSource.testersList);
        }

        public BindingList<Test> GetTestsList()
        {
            return new BindingList<Test>(DataSource.testsList);
        }

        public BindingList<Trainee> GetTraineesList()
        {
            return new BindingList<Trainee>(DataSource.traineesList);
        }

        public void RemoveTest(Test test)
        {
            throw new NotImplementedException();
        }

        public void RemoveTester(Tester tester)
        {
            throw new NotImplementedException();
        }

        public void RemoveTrainee(Trainee trainee)
        {
            throw new NotImplementedException();
        }

        public void UpdateTest(Test test)
        {
            throw new NotImplementedException();
        }

        public void UpdateTester(Tester tester)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrainee(Trainee trainee)
        {
            throw new NotImplementedException();
        }

        public Trainee GetTrainee(int id)
        {
            return DataSource.traineesList.ToList().Find(stud => stud.Id == id);
        }
        public Tester GetTester(int id)
        {
            return DataSource.testersList.ToList().Find(tester => tester.Id == id);
        }
        #endregion
    }
}
