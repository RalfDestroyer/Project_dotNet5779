using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ErrorsEventArgs: EventArgs
    {
        public string message;

        public ErrorsEventArgs(string message)
        {
            this.message = message;
        }
    }
}
