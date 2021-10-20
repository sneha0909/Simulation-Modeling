using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[,] Q = new double[,]{{ -0.4, 0.3, 0.1},
                            {0.4, -0.8, 0.4},
                            {0.1, 0.4, -0.5}};

        double lambda1;
        double lambda2;

        double t = 0;
        Random random = new Random();
        double[] ArrayofProbabilities = new double[] { 0, 0, 0, 0, 0 };
        double[] Arrayofintensities = new double[] { 0, 0 };

        double[] Arrayoftime = new double[] { 0, 0, 0, 0, 0 };   //Array of sequence of time 
        double p1;
        double p2;
        double p3;
        int i = 0;
        int j = 0;
        int k = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public double RandomDouble() //We are using this method because random.NextDouble() method gives random number 
                                     //between 0 and 1 
        {

            double rnd = random.NextDouble();

            return rnd;

        }
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

        private void GenerateRV()
        {

            double A = RandomDoubleInclusive();
            for (k = 0; k < 5;)
            {
                for (int b = 0; b < ArrayofProbabilities.Length; b++) //Looping over array of probabilities
                {

                    A = A - p1;

                    if (A <= 0)
                    {

                        //Arrayofstates[b] = k;

                        break;


                    }


                    else
                    {
                        k++;

                    }
                }
                break;


            }

        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            lambda1 = Convert.ToDouble(textBox1.Text);
            lambda2 = Convert.ToDouble(textBox2.Text);




            Arrayofintensities[0] = lambda1;
            Arrayofintensities[1] = lambda2;

            double alpha = RandomDouble();



            for (int i = 0; i < 2;)
            {
                double n = t + (-Q[i, i]);

             
                double tau = t + Arrayofintensities[i];


                if (tau < n)
                 {
                        
                    t = tau;
                    double newtau = t + Arrayofintensities[i] ;

                 }


                else
                {
                    t = n;

                    //Arrayoftime[i] = t;
                    Arrayoftime.SetValue(t, i);

                    Q[i, j] = -Q[i, j] / Q[i, i];

                    p1 = Q[i, j];


                    Q[i, j + 1] = -Q[i, j + 1] / Q[i, i];

                    p2 = Q[i, j + 1];

                   // textBox1.Text = Q[i, j + 1].ToString();

                    Q[i, j + 2] = -Q[i, j + 2] / Q[i, i];

                    p3 = Q[i, j + 2];




                    ArrayofProbabilities[0] = p1;
                    ArrayofProbabilities[1] = p2;
                    ArrayofProbabilities[2] = p3;


                    i++;
                    GenerateRV();
                }




            }
        }
    }
}
