using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDH1.Students.Evgeny
{
    class Evgeny
    {
        private string _fname = "Evgeny";
        private string _lname = "Karpov";


        public string GetFullName()
        {
            return String.Concat(_fname, " ", _lname);
        }
    }
}
