using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Editor.Classes
{
    class Filtro_Paramentros
    {
        public int filtroSize { get; private set; }
        public double[,] filtroMask { get; private set; }
        public double filtroMod { get; private set; }

        public Filtro_Paramentros(int filtroSize, double[,] filtroMask, double filtroMod)
        {
            this.filtroSize = filtroSize;
            this.filtroMask = filtroMask;
            this.filtroMod = filtroMod;
        }
    }
}
