using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    class SingletonObject
    {
        private static SingletonObject instance = null;
        public DateTime inicializacion = DateTime.Now;

        public SingletonObject()
        {

        }

        public static SingletonObject Instance
        {
            get
            {
                if (instance == null) instance = new SingletonObject();

                return instance;
            }
        }
    }
}
