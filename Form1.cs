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
        static double v0x(double vo, double teta)
        {
            return vo * Math.Cos(teta);
        }
        static double v0y(double vo, double teta)
        {
            return vo * Math.Sin(teta);
        }
        static double tempoSubida(double Voy, double g)
        {
            return (Voy / g);
        }
        static double tempoDescida(double Hmax, double g)
        {
            return Math.Sqrt((2 * Hmax) / g);
        }
        static double hMax(double Voy, double g, double yo)
        {
            return Math.Pow(Voy, 2) / (2 * g) + yo;
        }
        static double alcance(double vo, double teta, double g)
        {
            return (Math.Pow(vo, 2)) * Math.Sin(2 * teta) / g;
        }
        public Form1()
        {
            InitializeComponent();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Formulas formulas = new Formulas();
            double[] coordenadasx = new double[12];
            double[] coordenadasy = new double[12];
            double intervalo, v0, teta, g, h, alvoH, alvoD;
            double tempo = 0;

            v0 = (double) numericV0.Value;
            teta = (double) numericTeta.Value * (Math.PI / 180);
            g = (double) numericG.Value;
            h = (double) numericH.Value;
            alvoH = (double) numericAlvoH.Value;
            alvoD = (double) numericAlvoD.Value;
            
            label10.Text = formulas.anguloMinimo(alvoH, alvoD).ToString();
            double novoAngulo = double.Parse(label10.Text);
            label11.Text = formulas.v0Minima(g, novoAngulo, alvoH, alvoD).ToString();

            double alcance = Form1.alcance(v0, teta, g) + ((tempoDescida(hMax(v0y(v0, teta), g, h), g) - Form1.tempoSubida(v0y(v0, teta), g)) * v0x(v0, teta));
            lblAlcance.Text = Convert.ToString(Math.Round(alcance, 2)) + "m";
            lblAlcance.Visible = true;

            double tempoSubida = Form1.tempoSubida(v0y(v0, teta), g) + tempoDescida(hMax(v0y(v0, teta), g, h), g);
            lblTt.Text = Convert.ToString(Math.Round(tempoSubida, 2)) + "s";   
            lblTt.Visible = true;

            lblHmax.Text = Convert.ToString(Math.Round((hMax(v0y(v0, teta), g, h)), 2)) + "m"; 
            lblHmax.Visible = true;

            if (h == 0)
            {
                intervalo = (Form1.tempoSubida(v0y(v0, teta), g) + tempoDescida(hMax(v0y(v0, teta), g, h), g)) / 10;
            }
            else
            {
                intervalo = (Form1.tempoSubida(v0y(v0, teta), g) + tempoDescida(hMax(v0y(v0, teta), g, h), g)) / 11;
            }

            for(int i = 0; i < coordenadasx.Length; i++)
            {
                coordenadasx[i] = v0x(v0, teta) * tempo;
                tempo = tempo + intervalo;
            }

            tempo = 0;

            for (int i = 0; i < coordenadasy.Length; i++)  //Ponto a melhorar na versão 2
            {
                coordenadasy[i] = h + (v0y(v0, teta) * tempo) - g * Math.Pow(tempo, 2) / 2;
                tempo += intervalo;

            }
            if (h == 0)
            {
               
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
                        }
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
                    }
                }
            };
            }
        }
    }
}
