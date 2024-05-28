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
        //variáveis principais do projeto
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

        //esta funcao executa as principais funcionalidades do projeto
        public void calcular()
        {
            try
            {
                //aqui as variaveis principais recebem os valores das caixas numéricas
                v0 = (double)numericV0.Value;
                angulo = (double)numericTeta.Value;
                v0Y = formulas.v0Y((double)numericV0.Value, angulo);
                v0X = formulas.v0X((double)numericV0.Value, angulo);
                g = (double)numericG.Value;
                alvoX = (double)numericAlvoX.Value;
                alvoY = (double)numericAlvoY.Value;

                //aqui são as variáveis utilizadas nos cálculos para o cenário/situação atual
                double tempoTotalVoo = formulas.tempoTotal(alvoX, v0X);
                double tempoAtingirAlvo = formulas.tempoAtingirAlvo(alvoX, v0X);
                double distancia = formulas.alcanceHorizontal((double)numericV0.Value, (double)numericG.Value, (double)numericTeta.Value);
                double tempoDeVoo = formulas.tempoDeSubida(v0Y, g) * 2;
                double alturaMaxima = formulas.hMax(v0Y, g);

                //as listas de coordenadas X e Y são zeradas para se executar o cálculo novamente conforme os valores mudam
                coordenadasx.Clear();
                coordenadasy.Clear();

                //essa condicional foi implementada para que caso o X seja igual a 0 o gráfico gerado seja reto
                //portanto o ângulo mínimo aqui é delimitado para 90°
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

                    //este incrimento representa 10% da trajetória de Y do alvo,
                    //portanto serão gerados 10 pontos para o eixo Y
                    double incremento = alvoY * 0.1;
                    double alturaPercorrida = 0;

                    //loop para adicionar os pontos nas listas de X e Y
                    do
                    {
                        coordenadasy.Add(Math.Round(alturaPercorrida, 2));
                        //obs que nesta condicional as coordenadas de X sempre serão 0
                        coordenadasx.Add(0);
                        alturaPercorrida += incremento;
                    } while (alturaPercorrida < alvoY);
                    //função que recebe as duas listas como parâmetros e gera o respectivo gráfico
                    gerarGrafico(coordenadasx, coordenadasy, 0);
                }
                //caso contrário o gráfico gerado será uma parábola
                else
                {
                    //aqui o incremento para o loop funciona da msm forma, a cada 10% do trajeto de X
                    double incremento = distancia * 0.1;
                    double metroPercorrido = 0;

                    do
                    {
                        double altura = formulas.trajetoria(metroPercorrido, g, angulo, v0);
                        coordenadasy.Add(Math.Round(altura, 2));
                        coordenadasx.Add(Math.Round(metroPercorrido, 2));
                        metroPercorrido += incremento;
                    } while (metroPercorrido < distancia);
                    //após geradas as coordenadas, a função que gera o gráfico é chamada
                    gerarGrafico(coordenadasx, coordenadasy, distancia);
                }

                //as labels de informações recebem seus respectivos textos com suas respectivas casas decimais e unidades de medidas
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

        //função que recebe como parâmetros as respectivas listas de coordenadas de X e Y, além da distância máxima do percurso
        public void gerarGrafico(List<double> eixoX, List<double> eixoY, double distanciaMax)
        {
            //se existir distância X do alvo, o gráfico gerado será oblíquo,
            //portanto aqui serão utilizadas as coordenadas de X e Y
            if(alvoX != 0)
            {
                cartesianChart2.Series = new SeriesCollection
                    {
                        //inserção dos valores de X e Y
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
                            //configurações de estilização
                            StrokeThickness = 2,
                            LineSmoothness = 1,
                            DataLabels = true,
                            Stroke=new SolidColorBrush(System.Windows.Media.Color.FromRgb(0,0,0)),
                        },
                        //inserção da posição do alvo
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(alvoX, alvoY)
                            },
                            //configurações de estilização
                            StrokeThickness = 5,
                            LineSmoothness= 5,
                            Title = "ALVO",
                            PointGeometrySize = 12,
                        }
                    };
            }
            else
            {
                //caso NÃO haja distância de X do alvo o gráfico gerado será reto em 90°
                cartesianChart2.Series = new SeriesCollection
                    {   
                        //inserção dos valores de X e Y
                        //aqui como não há valores de X, os X sempre serão 0, pois é um gráfico reto de 90°
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
                            //configurações de estilização
                            StrokeThickness = 1,
                            LineSmoothness = 1,
                            DataLabels = true,
                            Stroke=new SolidColorBrush(System.Windows.Media.Color.FromRgb(0,0,0)),
                        },
                        //inserção da posição do alvo
                        new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(alvoX, alvoY)
                            },
                            //configurações de estilização
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
            //aqui os valores do ângulo são recalculados sempre que há uma mudança na ALTURA do alvo
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
            //aqui os valores do ângulo são recalculados sempre que há uma mudança na DISTÂNCIA do alvo
            try
            {
                numericTeta.Minimum = (decimal)formulas.anguloMinimo((double)numericAlvoY.Value, (double)numericAlvoX.Value);
                numericTeta.Value = (decimal)formulas.anguloMinimo((double)numericAlvoY.Value, (double)numericAlvoX.Value);
                if(alvoX > 0)
                {
                    //aqui limita-se o ângulo máximo para 89.99°,
                    //caso contrário o objetivo de acertar o alvo seria impossível
                    numericTeta.Maximum = 89.99m;
                }
                calcular();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void numericTeta_ValueChanged(object sender, EventArgs e)
        {
            //sempre que o ângulo é alterado a velocidade inicial é recalculada
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
            //sempre que a gravidade é alterada a velocidade inicial é recalculada
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
            //exibe-se o form dos alunos
            Alunos alunos = new Alunos();
            alunos.ShowDialog();
        }
    }
}
