using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Diagnostics;
using System.Windows.Forms;
using System.Windows.Shapes;


namespace Lançamento_Obliquo_Gráfico
{
    public partial class Form1 : Form
    {

        Formulas formulas = new Formulas();
        List<double> coordenadasx = new List<double>();
        List<double> coordenadasy = new List<double>();
        double intervalo, v0, v0Y, v0X, angulo, g, alvoY, alvoX, tempo = 0;


        Dictionary<string, decimal> gravidades = new Dictionary<string, decimal>()
        {
            {"Terra", 9.807m},
            {"Lua", 1.622m},
            {"Sol", 274.13m},
            {"Mercúrio", 3.7m},
            {"Vênus", 8.87m},
            {"Marte", 3.711m},
            {"Júpiter", 24.79m},
            {"Saturno", 10.44m},
            {"Urano", 8.69m},
            {"Netuno", 11.15m},
        };



        public Form1()
        {
            InitializeComponent();
            //comboBox1.Text = "Terra";
            //numericG.Value = gravidades["Terra"];
        }

        public string ascendenteDescendente(double v0Y, double g, double tempo)
        {
            double valor = v0Y - g * tempo;

            if (valor > 0)
                return "ascendente";

            return "descendente";
        }

        public void calcular()
        {
            try
            {
                v0 = (double)numericV0.Value;
                angulo = (double)numericTeta.Value;
                v0Y = formulas.v0Y((double)numericV0.Value, angulo);
                v0X = formulas.v0X((double)numericV0.Value, angulo);
                g = (double)numericG.Value;
                alvoX = (double)numericAlvoD.Value;
                alvoY = (double)numericAlvoH.Value;
                double tempoAtingirAlvo = formulas.tempoTotal(alvoX, v0X);
                double distancia = formulas.alcanceHorizontal((double)numericV0.Value, (double)numericG.Value, (double)numericTeta.Value);
                double tempoDeVoo = formulas.tempoDeSubida(v0Y, g) * 2;
                double alturaMaxima = formulas.hMax(v0Y, g);

                labelAtingido.Text = ascendenteDescendente(v0Y, g, tempoAtingirAlvo).ToUpper();
                labelDistanciaVoo.Text = distancia.ToString("F2") + " m";
                labelTempoVoo.Text = tempoDeVoo.ToString("F2") + " s";
                labelAlturaMaxima.Text = alturaMaxima.ToString("F2") + " m";
                intervalo = 1;



                if (numericV0.Value > 0 && numericG.Value > 0 && numericV0.Value > 0)
                {
                    coordenadasx.Clear();
                    coordenadasy.Clear();
                    double incremento = distancia * 0.1;
                    double metroPercorrido = 0;

                    do
                    {
                        double altura = formulas.trajetoria(metroPercorrido, g, angulo, v0);
                        coordenadasy.Add(Math.Round(altura,2));
                        coordenadasx.Add(Math.Round(metroPercorrido,2));
                        metroPercorrido += incremento;
                    } while (metroPercorrido < distancia);
                    gerarGrafico(coordenadasx, coordenadasy, distancia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void gerarGrafico(List<double> eixoX, List<double> eixoY, double distanciaMax)
        {
            cartesianChart2.Series = new SeriesCollection
                    {
                        new LineSeries
                    {
                        Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(eixoX[0], eixoY[0]),
                                new ObservablePoint(eixoX[1], eixoY[1]),
                                new ObservablePoint(eixoX[2], eixoY[2]),
                                new ObservablePoint(eixoX[3], eixoY[3]),
                                new ObservablePoint(eixoX[4], eixoY[4]),
                                new ObservablePoint(eixoX[5], eixoY[5]),
                                new ObservablePoint(eixoX[6], eixoY[6]),
                                new ObservablePoint(eixoX[7], eixoY[7]),
                                new ObservablePoint(eixoX[8], eixoY[8]),
                                new ObservablePoint(eixoX[9], eixoY[9]),
                                new ObservablePoint(distanciaMax, 0),
                            },
                        StrokeThickness = 1,
                        LineSmoothness = 1,
                        DataLabels = true,
                    }
                    };
        }
        private void numericAlvoH_ValueChanged(object sender, EventArgs e)
        {
            numericTeta.Minimum = (decimal)formulas.anguloMinimo((double)numericAlvoH.Value, (double)numericAlvoD.Value);
            numericTeta.Value = (decimal)formulas.anguloMinimo((double)numericAlvoH.Value, (double)numericAlvoD.Value);
            calcular();
        }
        private void numericAlvoD_ValueChanged(object sender, EventArgs e)
        {
            numericTeta.Minimum = (decimal)formulas.anguloMinimo((double)numericAlvoH.Value, (double)numericAlvoD.Value);
            numericTeta.Value = (decimal)formulas.anguloMinimo((double)numericAlvoH.Value, (double)numericAlvoD.Value);
            calcular();
        }
        private void numericTeta_ValueChanged(object sender, EventArgs e)
        {
            numericV0.Value = (decimal)formulas.v0((double)numericG.Value, (double)numericTeta.Value, (double)numericAlvoH.Value, (double)numericAlvoD.Value);
            calcular();
        }
        private void numericG_ValueChanged(object sender, EventArgs e)
        {
            numericV0.Value = (decimal)formulas.v0((double)numericG.Value, (double)numericTeta.Value, (double)numericAlvoH.Value, (double)numericAlvoD.Value);
            calcular();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string planeta = comboBox1.Text;

            //numericG.Value = gravidades[planeta];
        }
    }
}
