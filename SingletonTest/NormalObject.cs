using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    class NormalObject
    {
        private static SingletonObject instance;
        public DateTime inicializacion = DateTime.Now;

        public NormalObject()
        {

        }

        public static SingletonObject Instance
        {
            get
            {
                instance = new SingletonObject();

                return instance;
            }
        }
    }
}
