using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class LabWorkBuilder : WorkBuilder
    {
        public LabWorkBuilder()
        {
            work = new LabWork();
        }

        public void Reset()
        {
            work = new LabWork();
        }

    }
}
