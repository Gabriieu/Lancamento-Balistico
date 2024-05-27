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
using System.Windows.Media;
using System.Windows.Shapes;
using Brushes = System.Windows.Media.Brushes;


namespace Lançamento_Obliquo_Gráfico
{
    public partial class Form1 : Form
    {

        Formulas formulas = new Formulas();
        List<double> coordenadasx = new List<double>();
        List<double> coordenadasy = new List<double>();
        double v0, v0Y, v0X, angulo, g, alvoY, alvoX;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
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
                alvoX = (double)numericAlvoX.Value;
                alvoY = (double)numericAlvoY.Value;

                double tempoTotalVoo = formulas.tempoTotal(alvoX, v0X);
                double tempoAtingirAlvo = formulas.tempoAtingirAlvo(alvoX, v0X);
                double distancia = formulas.alcanceHorizontal((double)numericV0.Value, (double)numericG.Value, (double)numericTeta.Value);
                double tempoDeVoo = formulas.tempoDeSubida(v0Y, g) * 2;
                double alturaMaxima = formulas.hMax(v0Y, g);

                coordenadasx.Clear();
                coordenadasy.Clear();

                if (numericAlvoX.Value == 0)
                {
                    labelAtingido.Text = "-";
                    angulo = 90;
                    v0 = formulas.velocidadeTorricelli(g, alvoY);
                    numericTeta.Value = (decimal)angulo;
                    numericV0.Value = (decimal)v0;
                    alturaMaxima = alvoY;
                    tempoDeVoo = formulas.tempoDeVooReto(g, alvoY);
                    tempoAtingirAlvo = tempoDeVoo / 2;

                    double incremento = alvoY * 0.1;
                    double alturaPercorrida = 0;

                    do
                    {
                        coordenadasy.Add(Math.Round(alturaPercorrida, 2));
                        coordenadasx.Add(0);
                        alturaPercorrida += incremento;
                    } while (alturaPercorrida < alvoY);
                    gerarGrafico(coordenadasx, coordenadasy, 0);
                }
                else
                {
                    numericTeta.Maximum = 89.9m;
                    double incremento = distancia * 0.1;
                    double metroPercorrido = 0;

                    do
                    {
                        double altura = formulas.trajetoria(metroPercorrido, g, angulo, v0);
                        coordenadasy.Add(Math.Round(altura, 2));
                        coordenadasx.Add(Math.Round(metroPercorrido, 2));
                        metroPercorrido += incremento;
                    } while (metroPercorrido < distancia);
                    gerarGrafico(coordenadasx, coordenadasy, distancia);
                }

                labelAtingido.Text = formulas.ascendenteDescendente(v0Y, g, tempoTotalVoo).ToUpper();
                labelDistanciaVoo.Text = distancia.ToString("F3") + " m";
                labelTempoVoo.Text = tempoDeVoo.ToString("F2") + " s";
                labelTempoAtingir.Text = tempoAtingirAlvo.ToString("F2") + " s";
                labelAlturaMaxima.Text = alturaMaxima.ToString("F3") + " m";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void gerarGrafico(List<double> eixoX, List<double> eixoY, double distanciaMax)
        {
            if(alvoX != 0)
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
                            StrokeThickness = 2,
                            LineSmoothness = 1,
                            DataLabels = true,
                            Stroke=new SolidColorBrush(System.Windows.Media.Color.FromRgb(0,0,0)),
                        },
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(alvoX, alvoY)
                            },
                            StrokeThickness = 5,
                            LineSmoothness= 5,
                            Title = "ALVO",
                            PointGeometrySize = 12,
                        }
                    };
            }
            else
            {
                cartesianChart2.Series = new SeriesCollection
                    {
                        new LineSeries
                        {
                        Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(0, eixoY[0]),
                                new ObservablePoint(0, eixoY[1]),
                                new ObservablePoint(0, eixoY[2]),
                                new ObservablePoint(0, eixoY[3]),
                                new ObservablePoint(0, eixoY[4]),
                                new ObservablePoint(0, eixoY[5]),
                                new ObservablePoint(0, eixoY[6]),
                                new ObservablePoint(0, eixoY[7]),
                                new ObservablePoint(0, eixoY[8]),
                                new ObservablePoint(0, eixoY[9]),
                                new ObservablePoint(0, alvoY)
                            },
                            StrokeThickness = 1,
                            LineSmoothness = 1,
                            DataLabels = true,
                            Stroke=new SolidColorBrush(System.Windows.Media.Color.FromRgb(0,0,0)),
                        },
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(alvoX, alvoY)
                            },
                            StrokeThickness = 5,
                            LineSmoothness= 5,
                            Title = "ALVO",
                            PointGeometrySize = 12,
                        }
                    };
            }
        }
        private void numericAlvoH_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                numericTeta.Minimum = (decimal)formulas.anguloMinimo((double)numericAlvoY.Value, (double)numericAlvoX.Value);
                numericTeta.Value = (decimal)formulas.anguloMinimo((double)numericAlvoY.Value, (double)numericAlvoX.Value);
                calcular();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numericAlvoD_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                numericTeta.Minimum = (decimal)formulas.anguloMinimo((double)numericAlvoY.Value, (double)numericAlvoX.Value);
                numericTeta.Value = (decimal)formulas.anguloMinimo((double)numericAlvoY.Value, (double)numericAlvoX.Value);
                calcular();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numericTeta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                numericV0.Value = (decimal)formulas.v0((double)numericG.Value, (double)numericTeta.Value, (double)numericAlvoY.Value, (double)numericAlvoX.Value);
                calcular();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numericG_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                numericV0.Value = (decimal)formulas.v0((double)numericG.Value, (double)numericTeta.Value, (double)numericAlvoY.Value, (double)numericAlvoX.Value);
                calcular();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Alunos alunos = new Alunos();
            alunos.ShowDialog();
        }
    }
}
