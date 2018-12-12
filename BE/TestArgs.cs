using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TestArgs
    {
        bool? _pass;
        string _arg;

        public TestArgs(bool? pass, string arg)
        {
            Pass = pass;
            Arg = arg;
        }

        public bool? Pass { get => _pass; set => _pass = value; }
        public string Arg { get => _arg; set => _arg = value; }
    }
}
