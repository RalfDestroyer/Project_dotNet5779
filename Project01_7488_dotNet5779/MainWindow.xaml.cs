using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using BL;
using BE;

namespace Project01_7488_dotNet5779
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyBL bl;
        private List<Tester> _list;

        public MainWindow()
        {
            InitializeComponent();
            bl = MyBL.Instance;
            CreateDemoEntites();
            LoadNannyListOnWindow();
        }

        private void CreateDemoEntites()
        {
            Tester testerYossi = new Tester("Yossi", "abutbul", 123, new DateTime(1964, 10, 12), Configuration.eSex.Male, 050939393, new Adress("Avraham", 65, "Jesusalem"), 21, 4, Configuration.eTypeVechicle.PrivateCar, 31);
            Tester testerMoshe = new Tester("Moshe", "satbul", 321, new DateTime(1974, 12, 10), Configuration.eSex.Male, 050943493, new Adress("Moshe Boshe", 15, "Jesusalem"), 24, 1, Configuration.eTypeVechicle.MediumTrack, 11);
            bl.AddTester(testerMoshe);
            bl.AddTester(testerYossi);
            

            Trainee traineeAvraham = new Trainee("Avraham", "Buzaglo", 434, new DateTime(1994, 7, 10), Configuration.eSex.Male, 0578847, new Adress("her", 76, "Ashkelon"), Configuration.eTypeVechicle.MediumTrack, Trainee.eGearBox.Manual, "heyhey drive", "Moshe", 25);
            Trainee traineeRivka = new Trainee("rivka", "Afaglo", 4464, new DateTime(1984, 4, 20), Configuration.eSex.Female, 057884547, new Adress("her", 66, "Sderot"), Configuration.eTypeVechicle.MediumTrack, Trainee.eGearBox.Manual, "heyhey drive", "Moshe", 21);
            bl.AddTrainee(traineeAvraham);
            bl.AddTrainee(traineeRivka);

            List<TestArgs> lst = new List<TestArgs>();
            lst.Add(new TestArgs(true, "bla"));
            lst.Add(new TestArgs(false, "bla"));
            lst.Add(new TestArgs(true, "bla"));

            Test testFirst = new Test(1, 321, 434, new DateTime(2018, 7, 4, 10, 20, 0), new DateTime(2018, 7, 4, 10, 20, 0), new Adress("her", 66, "Sderot"), Configuration.eTypeVechicle.PrivateCar, true, lst, "blabla");
            bl.AddTest(testFirst);
            return;
        }


        private void LoadNannyListOnWindow()
        {
            //listView.DataContext = bl.getTesterList();
            //listView.DataContext = bl.getTraineeList();
            listView.DataContext = bl.getTestList();

        }
    }
}
