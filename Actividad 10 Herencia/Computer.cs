using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10_Herencia
{
    internal class Computer : Devices
    {
        public Computer(string nombre, string marca, string tipo) : base(nombre, marca, tipo)
        {
        }
    }
}
