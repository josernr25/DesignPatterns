using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDeepTest
{
    class Animal: ICloneable
    {
        public string Nombre { get; set; }
        public int Patas { get; set; }
        public Detalles Detalles { get; set; }

        public Animal()
        {

        }

        public object Clone()
        {
            Animal clonado = this.MemberwiseClone() as Animal;
            Detalles detallesClon = new Detalles();
            detallesClon.Color = this.Detalles.Color;
            detallesClon.Raza = this.Detalles.Raza;
            clonado.Detalles = detallesClon;
            return clonado;
        }
    }

    class Detalles
    {
        public string Color { get; set; } 
        public string Raza { get; set; }

        public Detalles()
        {

        }
    }
}
