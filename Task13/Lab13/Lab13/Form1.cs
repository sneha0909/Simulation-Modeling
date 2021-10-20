using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        double parameter;
        int NumberofExperiments;
        int m;
        double S = 0;
        double[] probabilities = new double[5]; //initializing an empty array

        int[] Statistics = new int[5];
        double[] Frequency = new double[5]; //initializing an empty array
        int k;
        Random random = new Random();

        //int k;
        double Mean;
        double Variance;
        double EmpiricExpectation;
        double EmpiricVariance;
        double AbsoluteErrorinMean;
        double AbsoluteErrorinVariance;
        double RelativeErrorinMean;
        double RelativeErrorinVariance;
        double ChiSquaredTestValue;



        double p1;
        double p2;
        double p3;
        double p4;
        double p5;
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

        public double factorial_Recursion(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            parameter = Convert.ToDouble(textBox1.Text);

            //for (int z = 0; z < 5;)
            //{

                for (m = 0; m < 5;)
                {

                    double Alpha = RandomDoubleInclusive();

                    double LogAlpha = Math.Log(Alpha);

                    S = S + LogAlpha;

                    double newLambda = parameter * -1;

                    if (S < newLambda)
                    {

                        double subtractionfrom1   = 1 - parameter;                      //Using Geometric distribution which requires one parameter
                        double powerofsubtraction = Math.Pow(subtractionfrom1, m);      // and calculating probabilities using the formula
                                                                                        // P(x=m) = p(1 - p)^m
                        probabilities[m] = parameter * powerofsubtraction;


                        //double numerator = Math.Pow(Lambda, m);
                        //double denominator = factorial_Recursion(m);
                        //double MultiplierNum = Math.Exp(-Lambda);
                        //probabilities[m] = (double)(numerator / denominator) * MultiplierNum;
                        //z++;



                        m++;
                    }



                    else
                    {
                        m = m + 1;

                    }


                }

            //}

            textBox4.Text = probabilities[0].ToString();         
            textBox5.Text = probabilities[1].ToString();      
            textBox6.Text = probabilities[2].ToString();          
            textBox7.Text = probabilities[3].ToString();           
            textBox8.Text = probabilities[4].ToString();
           


            int i;
            NumberofExperiments = Convert.ToInt32(textBox3.Text);

            for (i = 0; i <= NumberofExperiments;)
            {

                if (i < NumberofExperiments)
                {
                    k = random.Next(0, 5);

                    Statistics[k] = Statistics[k] + 1;
                    i++;

                }

                else
                {

                    for (int j = 0; j < 5; j++)
                    {

                        Frequency[j] = (double)Statistics[j] / NumberofExperiments;
                        chart1.Series["Emperical Probabilities"].Points.AddXY(0, Frequency[j]);



                    }
                    break;



                }

            }

            textBox9.Text = Frequency[0].ToString();
            textBox10.Text = Frequency[1].ToString();
            textBox11.Text = Frequency[2].ToString();
            textBox12.Text = Frequency[3].ToString();
            textBox13.Text = Frequency[4].ToString();

            double P1 = Convert.ToDouble(textBox4.Text);
            double P2 = Convert.ToDouble(textBox5.Text);
            double P3 = Convert.ToDouble(textBox6.Text);
            double P4 = Convert.ToDouble(textBox7.Text);
            double P5 = Convert.ToDouble(textBox8.Text);

            Mean = (P1 * 1) + (P2 * 2) + (P3 * 3) + (P4 * 4) + (P5 * 5);


            double squareof1 = 1;
            double squareof2 = 4;
            double squareof3 = 9;
            double squareof4 = 16;
            double squareof5 = 25;

            double squareofMean = Mean * Mean;

            Variance = ((P1 * squareof1) + (P2 * squareof2) + (P3 * squareof3) + (P4 * squareof4) + (P5 * squareof5)) - squareofMean;

            p1 = Frequency[0];
            p2 = Frequency[1];
            p3 = Frequency[2];
            p4 = Frequency[3];
            p5 = Frequency[4];


            EmpiricExpectation = (p1 * 1) + (p2 * 2) + (p3 * 3) + (p4 * 4) + (p5 * 5);

            textBox18.Text = EmpiricExpectation.ToString();

            double squareofEmpiricExpectation = EmpiricExpectation * EmpiricExpectation;

            EmpiricVariance = ((p1 * squareof1) + (p2 * squareof2) + (p3 * squareof3) + (p4 * squareof4) + (p5 * squareof5)) - squareofEmpiricExpectation;

            textBox17.Text = EmpiricVariance.ToString();

            AbsoluteErrorinMean = EmpiricExpectation - Mean;

            AbsoluteErrorinVariance = EmpiricVariance - Variance;

            RelativeErrorinMean = AbsoluteErrorinMean / Mean;

            textBox14.Text = Math.Abs(RelativeErrorinMean).ToString();

            RelativeErrorinVariance = AbsoluteErrorinVariance / Variance;

            textBox15.Text = Math.Abs(RelativeErrorinVariance).ToString();


            int multiplier = 1000;

            int newp1 = (int)((p1 - (int)p1) * multiplier); //extracting last 3 digits of relative frequency
            int newp2 = (int)((p2 - (int)p2) * multiplier);
            int newp3 = (int)((p3 - (int)p3) * multiplier);
            int newp4 = (int)((p4 - (int)p4) * multiplier);
            int newp5 = (int)((p5 - (int)p5) * multiplier);

            int Numerator1 = newp1 * newp1;
            int Numerator2 = newp2 * newp2;
            int Numerator3 = newp3 * newp3;
            int Numerator4 = newp4 * newp4;
            int Numerator5 = newp5 * newp5;


            double denominator1 = NumberofExperiments * P1;
            double denominator2 = NumberofExperiments * P2;
            double denominator3 = NumberofExperiments * P3;
            double denominator4 = NumberofExperiments * P4;
            double denominator5 = NumberofExperiments * P5;

            double ChiValue1 = Math.Abs((Numerator1 / denominator1) - NumberofExperiments);
            double ChiValue2 = Math.Abs((Numerator2 / denominator2) - NumberofExperiments);
            double ChiValue3 = Math.Abs((Numerator3 / denominator3) - NumberofExperiments);
            double ChiValue4 = Math.Abs((Numerator4 / denominator4) - NumberofExperiments);
            double ChiValue5 = Math.Abs((Numerator5 / denominator5) - NumberofExperiments);

            ChiSquaredTestValue = ChiValue1 + ChiValue2 + ChiValue3 + ChiValue4 + ChiValue5;
            textBox16.Text = ChiSquaredTestValue.ToString();




        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
