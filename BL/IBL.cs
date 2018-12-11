using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.ComponentModel;

namespace BL
{
    public interface IBL
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
        BindingList<Tester> getTesterList();
        BindingList<Trainee> getTraineeList();
        BindingList<Test> getTestList();
        #endregion
    }
}
