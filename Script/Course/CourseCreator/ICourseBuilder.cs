using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    interface ICourseBuilder
    {
        public void Reset();

        public ICourse GetResult();
    }
}
