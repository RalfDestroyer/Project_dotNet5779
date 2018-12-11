using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DAL
{
    public interface IDAL
    {
        #region Tester
        void AddTester(Tester tester);
        void RemoveTester(Tester tester);
        void UpdateTester(Tester tester);
        #endregion

        #region Trainee
        void AddTrainee(Trainee trainee);
        void RemoveTrainee(Trainee trainee);
        void UpdateTrainee(Trainee trainee);
        #endregion

        #region Test
        void AddTest(Test test);
        void RemoveTest(Test test);
        void UpdateTest(Test test);
        #endregion

        #region getLists
        BindingList<Tester> GetTestersList();
        BindingList<Trainee> GetTraineesList();
        BindingList<Test> GetTestsList();
        #endregion
    }
}