using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Caja
    {
        public int Codigo;
        public string Descripcion;
        public double Peso;

        public override string ToString()
        {
            return $"-----------------------------\n" +
                   $"Código: {Codigo} \n" +
                   $"Descripción: {Descripcion} \n" +
                   $"Peso: {Peso} kg \n" + 
                   $"-----------------------------";
        }

    }
}
