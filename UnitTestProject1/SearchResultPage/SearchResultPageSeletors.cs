using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class SerchResultPageSeletors : Google
    {
        public static String LinkNumberSelector(int linknumber)
        {
            String linkSelector = (".//*[@id='rso']/div/div/div[" + linknumber + "]/div/h3/a");
            return linkSelector;
        }
    }
}
