using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class PracticalWorkBuilder : WorkBuilder
    {
        public PracticalWorkBuilder()
        {
            work = new PracticalWork();
        }

        public void Reset()
        {
            work = new PracticalWork();
        }
    }
}
