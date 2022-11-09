using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1._7
{
    class Temperatura
    {
        private double _dblGradosCentigrados;

        public double GradosCentigrados
        {
            get { return _dblGradosCentigrados; }
            set { _dblGradosCentigrados = value; }
        }

        public double ConvertirAFarenheit()
        {
            return (((GradosCentigrados*9)/5)+32);
        }
    }
}
