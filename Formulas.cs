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

        public double v0X(double v0, double teta)
        {
            return v0 * Math.Cos(teta * Math.PI / 180);
        }

        public double v0Y(double v0, double teta)
        {
            return v0 * Math.Sin(teta * Math.PI / 180);
        }

        public double deslocamentoX(double x0, double vx, double tempo)
        {
            return x0 + vx * tempo;
        }

        public double deslocamentoY(double y0, double v0y, double tempo, double gravidade)
        {
            return y0 + v0y * tempo - (gravidade / 2) * Math.Pow(tempo, 2);
        }

        public double vY(double v0Y, double gravidade, double tempo)
        {
            return v0Y - gravidade * tempo;
        }

        public double torricelliVY(double v0Y, double gravidade, double y)
        {
            return Math.Sqrt(Math.Pow(v0Y, 2) - 2 * gravidade * y);
        }

        public double tempoDeSubida(double v0Y, double gravidade)
        {
            return v0Y / gravidade;
        }

        public double tempoDeDescida(double v0Y, double gravidade)
        {
            return v0Y / gravidade;
        }

        public double tempoTotal(double x, double v0X)
        {
            return x / v0X;
        }

        public double hMax(double v0Y, double gravidade)
        {
            return Math.Pow(v0Y, 2) / (2 * gravidade);
        }

        public double alcanceHorizontal(double v0, double gravidade, double teta)
        {
            return (Math.Pow(v0, 2) / gravidade) * Math.Sin(teta * Math.PI / 180 * 2);
        }

        public double trajetoria(double x, double g, double angulo, double v0)
        {
            double dividendo = g * (1 + Math.Pow(Math.Tan(angulo * Math.PI / 180), 2));
            double divisor = 2 * Math.Pow(v0, 2);

            double resultado = x * Math.Tan(angulo * Math.PI / 180) - (dividendo / divisor) * Math.Pow(x, 2);

            return resultado;
        }

        public double anguloMinimo(double y, double x)
        {
            if (y > 0)
            {
                return Math.Atan(y / x) * (180 / Math.PI);
            }

            return 0;
        }

        public double v0(double g, double angulo, double y, double x)
        {

            double tan = Math.Round(Math.Tan(angulo * Math.PI / 180), 5);

            double dividendo = g * Math.Pow(x, 2) * (1 + Math.Pow(tan, 2));

            double divisor = 2 * (y - x * tan);

            if (divisor < 0)
                divisor *= -1;

            if(divisor == 0)
                return Math.Sqrt(dividendo);

            double resultado = dividendo / divisor;

            return Math.Sqrt(resultado);
        }

        public string ascendenteDescendente(double v0Y, double g, double tempo)
        {
            double valor = v0Y - g * tempo;

            if (valor > 0)
                return "ascendente";
            else if (valor < 0)
                return "descendente";

            return "-";
        }

        public double velocidadeTorricelli(double g, double alvoY)
        {
            return Math.Sqrt(2 * g * alvoY);
        }

        public double tempoDeVooReto(double g, double alvoY)
        {
            return Math.Sqrt(alvoY / (g / 2)) * 2;
        }
    }
}
