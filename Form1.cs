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
        double[] coordenadasx = new double[24];
        double[] coordenadasy = new double[24];
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
                    for (int i = 0; i < coordenadasx.Length; i++)
                    {
                        coordenadasx[i] = formulas.v0X((double)numericV0.Value, (double)numericTeta.Value) * tempo;
                        tempo += intervalo;
                    }

                    tempo = 0;

                    for (int i = 0; i < coordenadasy.Length; i++)
                    {
                        coordenadasy[i] = (formulas.v0Y((double)numericV0.Value, (double)numericTeta.Value) * tempo) - (double)numericG.Value * Math.Pow(tempo, 2) / 2;
                        tempo += intervalo;
                    }

                    cartesianChart2.Series = new SeriesCollection
                    {
                        new LineSeries
                    {
                        Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(coordenadasx[0], coordenadasy[0]),
                                new ObservablePoint(coordenadasx[1], coordenadasy[1]),
                                new ObservablePoint(coordenadasx[2], coordenadasy[2]),
                                new ObservablePoint(coordenadasx[3], coordenadasy[3]),
                                new ObservablePoint(coordenadasx[4], coordenadasy[4]),
                                new ObservablePoint(coordenadasx[5], coordenadasy[5]),
                                new ObservablePoint(coordenadasx[6], coordenadasy[6]),
                                new ObservablePoint(coordenadasx[7], coordenadasy[7]),
                                new ObservablePoint(coordenadasx[8], coordenadasy[8]),
                                new ObservablePoint(coordenadasx[9], coordenadasy[9]),
                                new ObservablePoint(coordenadasx[10], coordenadasy[10]),
                                new ObservablePoint(coordenadasx[11], coordenadasy[11]),
                                new ObservablePoint(coordenadasx[12], coordenadasy[12]),
                                new ObservablePoint(coordenadasx[13], coordenadasy[13]),
                                new ObservablePoint(coordenadasx[14], coordenadasy[14]),
                                new ObservablePoint(coordenadasx[15], coordenadasy[15]),
                                new ObservablePoint(coordenadasx[16], coordenadasy[16]),
                                new ObservablePoint(coordenadasx[17], coordenadasy[17]),
                                new ObservablePoint(coordenadasx[18], coordenadasy[18]),
                                new ObservablePoint(coordenadasx[19], coordenadasy[19]),
                                new ObservablePoint(coordenadasx[20], coordenadasy[20]),
                                new ObservablePoint(coordenadasx[21], coordenadasy[21]),
                                new ObservablePoint(coordenadasx[22], coordenadasy[22]),
                                new ObservablePoint(coordenadasx[23], coordenadasy[23]),
                            }
                    }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
