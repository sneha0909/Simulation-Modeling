using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double[] Statistics1 = new double[500];
        double[] Statistics2 = new double[500];

        double[] RelativeFrequencies = new double[5]; //initializing an empty array

        double Alpha1;
        double Alpha2;

        double RV1;
        double RV2;

        Random random = new Random();
        public double RandomDoubleInclusive() //We are using this method because random.NextDouble() method gives random number 
                                              //between 0 and 1 where 0 is inclusive and 1 is exclusive. 
                                              //Since the value of probability lies between 0 and 1, both inclusive that's why we need 
                                              //to use this method.
        {
            double d = 0.0;
            int i = 0;

            do
            {
                d = random.NextDouble();
                i = random.Next(2);
            }
            while (i == 1 && d > 0);

            return d + i;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int i,j;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SampleSize = Convert.ToInt32(textBox3.Text);
            

            for ( i = 0; i<500;)
            {
                for (j = 0; j < 500;)
                {
                    Alpha1 = RandomDoubleInclusive();
                    Alpha2 = RandomDoubleInclusive();

                    double LnPart = Math.Log(Alpha1);

                    double part1 = (-2) * LnPart;

                    double part2 = 2 * 3.14159 * Alpha2;

                    double CosPart = Math.Cos(part2);

                    double SinPart = Math.Sin(part2);


                    RV1 = Math.Sqrt(part1) * CosPart;
                    Statistics1[i] = RV1;

                    RV2 = Math.Sqrt(part1) * SinPart;
                    Statistics2[j] = RV2;


                    i++;
                    j++;
                }

            }

            var myList = new List<double>();
            myList.AddRange(Statistics1);
            myList.AddRange(Statistics2);
            double[] arr3 = myList.ToArray();

            
            double Max = arr3.Max();

            double Min = arr3.Min();
            

            int ClosestIntMin = (int )Math.Round(Min);
          
            int ClosestIntMax = (int)Math.Round(Max);
            

            double differenceofMaxMin = Max - Min;

            double k;

            k = Math.Log(SampleSize,2) + 1;



            int[,] Intervals = new int[,]{ { -4, -2 }, { -2, 0 },
              { 0, 2 }, { 2, 4 } };

            int LengthofarrayIntervals = Intervals.GetLength(0);

            int Lengthofarr3 = arr3.GetLength(0);
            // Variable to store the count of intervals
            int frequencyininterval1 = 0;
            int frequencyininterval2 = 0;
            int frequencyininterval3 = 0;
            int frequencyininterval4 = 0;
            // Variables to store start and end of an interval
            int li, ri;

            int V;
            for (V = 0; V < Lengthofarr3;)
            {
                for (int i = 0; i <1; i++)
                {
                    li = Intervals[i, 0];
                    ri = Intervals[i, 1];

                    // Implies V lies in the interval
                    // so increase count
                    if (arr3[V] >= li && arr3[V] <= ri)
                        frequencyininterval1++;
                        

                }

                for (int i = 1; i < 2; i++)
                {
                    li = Intervals[i, 0];
                    ri = Intervals[i, 1];

                    // Implies V lies in the interval
                    // so increase count
                    if (arr3[V] >= li && arr3[V] <= ri)
                        frequencyininterval2++;
                    
                }

                for (int i = 2; i < 3; i++)
                {
                    li = Intervals[i, 0];
                    ri = Intervals[i, 1];

                    // Implies V lies in the interval
                    // so increase count
                    if (arr3[V] >= li && arr3[V] <= ri)
                        frequencyininterval3++;
                   
                }

                for (int i = 3; i < 4; i++)
                {
                    li = Intervals[i, 0];
                    ri = Intervals[i, 1];

                    // Implies V lies in the interval
                    // so increase count
                    if (arr3[V] >= li && arr3[V] <= ri)
                        frequencyininterval4++;
                   
                }
                V++;
            }
            double relativefrequency1;
            relativefrequency1 = (double)frequencyininterval1 / SampleSize;
            chart1.Series["Emperical Probabilities"].Points.AddXY(0, relativefrequency1);
           

            double relativefrequency2 = (double)frequencyininterval2 / 1000;
            chart1.Series["Emperical Probabilities"].Points.AddXY(0, relativefrequency2);

            double relativefrequency3 = (double)frequencyininterval3 / 1000;
            chart1.Series["Emperical Probabilities"].Points.AddXY(0, relativefrequency3);

            double relativefrequency4 = (double)frequencyininterval4 / 1000;
            chart1.Series["Emperical Probabilities"].Points.AddXY(0, relativefrequency4);

            chart1.Series[0].Points[0].AxisLabel = "(-4;-2]";
            chart1.Series[0].Points[1].AxisLabel = "(-2;0]";
            chart1.Series[0].Points[2].AxisLabel = "(0;2]";
            chart1.Series[0].Points[3].AxisLabel = "(2;4]";

            double p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;


            double denominator = Math.Sqrt(2 * 3.141);


            double power1 = (double)-1 / 2;
            double power2 = (double)-4 / 2;
            double power3 = (double)-9 / 2;
            double power4 = (double)-16 / 2;
            double power5 = (double)-25 / 2;
            double power6 = (double)-1 / 2;
            double power7 = (double)-4 / 2;
            double power8 = (double)-9 / 2;
            double power9 = (double)-16 / 2;
            double power10 = (double)-25 / 2;

            double numerator1 = Math.Pow(2.71828, power1);
            double numerator2 = Math.Pow(2.71828, power2);
            double numerator3 = Math.Pow(2.71828, power3);
            double numerator4 = Math.Pow(2.71828, power4);
            double numerator5 = Math.Pow(2.71828, power5);
            double numerator6 = Math.Pow(2.71828, power6);
            double numerator7 = Math.Pow(2.71828, power7);
            double numerator8 = Math.Pow(2.71828, power8);
            double numerator9 = Math.Pow(2.71828, power9);
            double numerator10 = Math.Pow(2.71828, power10);

            p1 = numerator1 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p1);

            p2 = numerator2 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p2);
            p3 = numerator3 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p3);
            p4 = numerator4 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p4);
            p5 = numerator5 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p5);

            p6 = numerator6 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p6);

            p7 = numerator7 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p7);
            p8 = numerator8 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p8);
            p9 = numerator9 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p9);
            p10 = numerator10 / denominator;
            chart1.Series["Theoretical Probabilities"].Points.AddXY(0, p10);

            double EmpericalAverage;
            int m;
            int sum = 0;

            for (m = 1; m <= SampleSize; m++)
            {
                sum = sum + m;
               
            }

            EmpericalAverage = sum / SampleSize;
            textBox4.Text = EmpericalAverage.ToString();

            double squareofaverage = sum * sum;

            double EmpericalVariance;
            int n;
            int summ = 0;
            int squareofn;

            for (n = 1 ; n <= SampleSize; n++)
            {
                squareofn = n * n;
                summ = summ + squareofn;

            }

            double squareofempericalAverage = EmpericalAverage * EmpericalAverage;

            double numerator = summ - squareofempericalAverage;

            EmpericalVariance = numerator / SampleSize;
            textBox6.Text = EmpericalVariance.ToString();

            double Mean = Convert.ToInt32(textBox1.Text);
            double Variance = Convert.ToInt32(textBox2.Text);

            double AbsoluteErrorinMean = EmpericalAverage - Mean;

            double AbsoluteErrorinVariance = EmpericalVariance - Variance;

            double RelativeErrorinMean = AbsoluteErrorinMean / Mean;

            textBox5.Text = Math.Abs(RelativeErrorinMean).ToString();

            double RelativeErrorinVariance = AbsoluteErrorinVariance / Variance;

            textBox7.Text = Math.Abs(RelativeErrorinVariance).ToString();

            double ChisquaredValue;

            double squareofni1 = frequencyininterval1 * frequencyininterval1;
            double squareofni2 = frequencyininterval2 * frequencyininterval2;
            double squareofni3 = frequencyininterval3 * frequencyininterval3;
            double squareofni4 = frequencyininterval4 * frequencyininterval4;

            
            double denominator1 = SampleSize * p1;
            double denominator2 = SampleSize * p2;
            double denominator3 = SampleSize * p3;
            double denominator4 = SampleSize * p4;

            double calculatenumeratordenominator1 = squareofni1 / denominator1;
            double calculatenumeratordenominator2 = squareofni2 / denominator2;
            double calculatenumeratordenominator3 = squareofni3 / denominator3;
            double calculatenumeratordenominator4 = squareofni4 / denominator4;

            ChisquaredValue = (calculatenumeratordenominator1 - SampleSize) + (calculatenumeratordenominator2 - SampleSize) + (calculatenumeratordenominator3 - SampleSize) + (calculatenumeratordenominator4 - SampleSize);
            textBox8.Text = ChisquaredValue.ToString();
        }
    }
}
