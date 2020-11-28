using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeShallowTest
{
    class Animal: ICloneable
    {
        public string Nombre { get; set; }
        public int Patas { get; set; }

        public Animal()
        {

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
