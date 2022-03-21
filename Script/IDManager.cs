using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{

    class IDManager
    {
        private static List<ID> listID = new List<ID>();

        public static ID CreateNewId(typeID _typeID, object obj)
        {
            ID newID = new ID(GetFreeID(_typeID), obj);

            listID.Add(newID);

            return newID;
        }


        public static double GetFreeID(typeID typeID) 
        {
            for (int i = 100000 * (int)typeID; i < 200000 * (int)typeID; i++) 
            {
                if (Contains(i) == false) 
                {
                    return i;
                }
            }

            return -1;
        }

        private static bool Contains(double _ID) 
        {
            for (int j = 0; j < listID.Count; j++)
            {
                if (listID[j].id == _ID) 
                {
                    return true;
                }
            }

            return false;
        }



    }


    public enum typeID
    {
        Default = 0,
        Student = 1,
        Teacher = 2,
        Work    = 3,
        Task    = 4,
    }
}
