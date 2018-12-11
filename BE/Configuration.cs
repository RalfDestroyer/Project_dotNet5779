using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Configuration
    {
        private const int _DAYS_IN_YEAR = 365;
        private const int _MIN_OLD_TESTER = 40;
        private const int _MIN_OLD_TRAINEE = 18;

        public static int DAYS_IN_YEAR => _DAYS_IN_YEAR;

        public static int MIN_OLD_TESTER => _MIN_OLD_TESTER;

        public static int MIN_OLD_TRAINEE => _MIN_OLD_TRAINEE;
    }
}
