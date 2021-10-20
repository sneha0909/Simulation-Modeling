using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Statistics = new int[5];
        double[] Frequency = new double[5]; //initializing an empty array

        double P1;
        double P2;
        double P3;
        double P4;
        double P5;
        int NumberofExperiments;

        double SumofP;

        Random random = new Random();

        int k;
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
        private void TheoreticalMean()
        {
          

            


        }
        private void button1_Click(object sender, EventArgs e)
        {

            P1 = Convert.ToDouble(textBox1.Text);
            P2 = Convert.ToDouble(textBox2.Text);
            P3 = Convert.ToDouble(textBox3.Text);
            P4 = Convert.ToDouble(textBox4.Text);

            NumberofExperiments = Convert.ToInt32(textBox6.Text);

            SumofP = P1 + P2 + P3 + P4;

            P5 = 1 - SumofP;

            textBox5.Text = P5.ToString();


            int i;

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

                        //textBox7.Text = Frequency[0].ToString();
                        //textBox8.Text = Frequency[1].ToString();
                        //textBox9.Text = Frequency[2].ToString();
                        //textBox10.Text = Frequency[3].ToString();
                        //textBox11.Text = Frequency[4].ToString();
                        //textBox7.Text = textBox7.Text + "," + Frequency[j].ToString();
                    }
                    break;



                }
            }
            textBox7.Text = Frequency[0].ToString();
            textBox8.Text = Frequency[1].ToString();
            textBox9.Text = Frequency[2].ToString();
            textBox10.Text = Frequency[3].ToString();
            textBox11.Text = Frequency[4].ToString();


            Mean = (P1 * 1) + (P2 * 2) + (P3 * 3) + (P4 * 4) + (P5 * 5);


                double squareof1   = 1;
                double squareof2  = 4;
                double squareof3   = 9;
                double squareof4  = 16;
                double squareof5   = 25;

                double squareofMean = Mean * Mean;
                
                Variance = ((P1 * squareof1) + (P2 * squareof2) + (P3 * squareof3) + (P4 * squareof4) + (P5 * squareof5)) - squareofMean ;

                p1 = Frequency[0];
                p2 = Frequency[1];
                p3 = Frequency[2];
                p4 = Frequency[3];
                p5 = Frequency[4];


                EmpiricExpectation = (p1 * 1) + (p2 * 2) + (p3 * 3) + (p4 * 4) + (p5 * 5);

                textBox12.Text = EmpiricExpectation.ToString();

                double squareofEmpiricExpectation = EmpiricExpectation * EmpiricExpectation;

                EmpiricVariance = ((p1 * squareof1) + (p2 * squareof2) + (p3 * squareof3) + (p4 * squareof4) + (p5 * squareof5)) - squareofEmpiricExpectation;

                textBox13.Text = EmpiricVariance.ToString();

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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
