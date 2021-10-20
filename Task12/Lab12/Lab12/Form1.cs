using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ProbabilityofGoalsbyBarcelona;
        double ProbabilityofGoalsbyTexas;
        double ProbabilityofGoalsbyManchester;
        double ProbabilityofGoalsbyLiverpool;

        int k1 = 5; //Expected number of goals by Barcelona
        int k2 = 5; //Expected number of goals by Texas
        int k3 = 3; //Expected number of goals by Manchester City
        int k4 = 3; //Expected number of goals by Liverpool


        int rollingtime = 0;

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
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rollingtime++;

            textBox14.Text = rollingtime.ToString();
            int newroll = 0;

            double lambda1 = Convert.ToDouble(textBox10.Text);  //Average Goals scored in the match by Barcelona
            double lambda2 = Convert.ToDouble(textBox11.Text); //Average Goals scored in the match by Texas
            double lambda3 = Convert.ToDouble(textBox12.Text);  //Average Goals scored in the match by Manchester City
            double lambda4 = Convert.ToDouble(textBox13.Text);  //Average Goals scored in the match by Liverpool

            textBox1.Text = "Barcelona";
            textBox2.Text = "Texas";
            textBox3.Text = "Manchester City";
            textBox4.Text = "Liverpool";


            //Calculating Probability of scoring 5 goals by Barcelona Team
            //Hence, calculating P(5) by Poisson Distribution which is given by P(k) = (lambda^k e^-lambda)/k! where k = 5;

            double numerator1 = Math.Pow(lambda1, k1);
            double denominator1 = factorial_Recursion(k1);
            double MultiplierNum1 = Math.Exp(-lambda1);

            ProbabilityofGoalsbyBarcelona = (numerator1 / denominator1) * MultiplierNum1;

            //Calculating Probability of scoring 5 goals by Texas Team
            //Hence, calculating P(5) by Poisson Distribution which is given by P(k) = (lambda^k e^-lambda)/k! where k = 5;

            double numerator2 = Math.Pow(lambda2, k2);
            double denominator2 = factorial_Recursion(k2);
            double MultiplierNum2 = Math.Exp(-lambda2);

            ProbabilityofGoalsbyTexas = (numerator2 / denominator2) * MultiplierNum2;


            //Calculating Probability of scoring 3 goals by Manchester City Team
            //Hence, calculating P(3) by Poisson Distribution which is given by P(k) = (lambda^k e^-lambda)/k! where k = 3;

            double numerator3 = Math.Pow(lambda3, k3);
            double denominator3 = factorial_Recursion(k3);
            double MultiplierNum3 = Math.Exp(-lambda3);

            ProbabilityofGoalsbyManchester = (numerator3 / denominator3) * MultiplierNum3;

            //Calculating Probability of scoring 3 goals by Liverpool Team
            //Hence, calculating P(5) by Poisson Distribution which is given by P(k) = (lambda^k e^-lambda)/k! where k = 3;

            double numerator4 = Math.Pow(lambda4, k4);
            double denominator4 = factorial_Recursion(k4);
            double MultiplierNum4 = Math.Exp(-lambda4);

            ProbabilityofGoalsbyLiverpool = (numerator4 / denominator4) * MultiplierNum4;


            if (textBox14.Text == "40")
            {
                //timer1.Stop();
                //rollingtime = newroll;

                if (ProbabilityofGoalsbyBarcelona > ProbabilityofGoalsbyTexas)
                {
                    textBox5.Text = "Barcelona";
                    textBox7.Text = "Barcelona";


                }
                else
                {
                    textBox5.Text = "Texas";
                    textBox7.Text = "Texas";

                }

                if (ProbabilityofGoalsbyManchester > ProbabilityofGoalsbyLiverpool)
                {
                    textBox6.Text = "Manchester";
                    textBox8.Text = "Manchester";

                }

                else
                {
                    textBox6.Text = "Liverpool";
                    textBox8.Text = "Liverpool";

                }

            }

            if (textBox14.Text == "70")
            {
                timer1.Stop();
                rollingtime = newroll;
                if (textBox7.Text == "Barcelona" && textBox8.Text == "Manchester")
                {
                    if (ProbabilityofGoalsbyBarcelona > ProbabilityofGoalsbyManchester)
                    {
                        textBox9.Text = "Barcelona";
                    }
                    else
                    {
                        textBox9.Text = "Manchester";

                    }

                }

                if (textBox7.Text == "Barcelona" && textBox8.Text == "Liverpool")
                {
                    if (ProbabilityofGoalsbyBarcelona > ProbabilityofGoalsbyLiverpool)
                    {
                        textBox9.Text = "Barcelona";
                    }
                    else
                    {
                        textBox9.Text = "Liverpool";

                    }

                }


                if (textBox7.Text == "Texas" && textBox8.Text == "Manchester")
                {
                    if (ProbabilityofGoalsbyTexas > ProbabilityofGoalsbyManchester)
                    {
                        textBox9.Text = "Texas";
                    }
                    else
                    {
                        textBox9.Text = "Manchester";

                    }

                }

                if (textBox7.Text == "Texas" && textBox8.Text == "Liverpool")
                {
                    if (ProbabilityofGoalsbyTexas > ProbabilityofGoalsbyLiverpool)
                    {
                        textBox9.Text = "Texas";
                    }
                    else
                    {
                        textBox9.Text = "Liverpool";

                    }

                }

            }
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
