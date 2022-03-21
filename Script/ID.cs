using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{

    public class ID
    {
        public double id { get; private set; }
        private object ptr;

        public ID(double _id, object _ptr) 
        {
            id = _id;
            ptr = _ptr;
        }

        public override string ToString()
        {
            return ptr.ToString();
        }
    }
}
