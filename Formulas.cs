using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lançamento_Obliquo_Gráfico
{
    internal class Formulas
    {

        public double anguloMinimo(double h, double d)
        {
            return Math.Atan(h / d) * (180 / Math.PI);
        }

        //fix
        public double v0Minima(double g, double angulo, double y, double x)
        {
            double rad = anguloMinimo(y, x);

            double cima = g * Math.Pow(x, 2) * (1 + Math.Pow(rad, 2));

            double baixo = 2 * (y - x * Math.Tan(angulo));

            //MessageBox.Show(Math.Tan(30).ToString());

            return Math.Sqrt(cima / baixo);
        }
    }
}
