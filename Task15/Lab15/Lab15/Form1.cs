using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double[] Arrayoftime = new double[] { 0, 0, 0, 0, 0 };   //Array of sequence of time 
        int[] Arrayofstates = new int[] { 0, 0, 0, 0, 0 }; //Array of sequence of states 

        double[] ArrayofProbabilities = new double[] { 0,0,0,0,0};


        double[,] Q = new double[,]{{ -0.4, 0.3, 0.1},
                            {0.4, -0.8, 0.4},
                            {0.1, 0.4, -0.5}};



        int i = 0;
        int j = 0;
        double t = 0;
        int RV;
        int k;
        double p1;
        double p2;
        double p3;

        //int[] Statistics = new int[10000];
        //double[] Frequency = new double[100000]; //initializing an empty array

        //double t;

        //int NumberofExperiments = 10000; //N number of Simulation Experiments

        Random random = new Random();
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
                        switch (k) // 9 Different cases in Cheating dice 
                        {

                            case 0:

                                pictureBox1.Image = Properties.Resources.sunny;

                                textBox6.Text = "Sunny";
                                textBox1.Text = Arrayoftime[0].ToString();
                            
                               

                                break;
                            case 1:
                                pictureBox2.Image = Properties.Resources.snowy;
                                textBox7.Text = "Snow";
                                textBox2.Text = Arrayoftime[1].ToString();

                                break;
                            case 2:

                                pictureBox3.Image = Properties.Resources.download;
                                textBox8.Text = "Rainy";
                                textBox3.Text = Arrayoftime[2].ToString();
                                break;
                        }
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
            
            double alpha = RandomDouble();

           

                for (int i = 0; i < 3;)
                {
                    double logValue = Math.Log(alpha);

                    double tau = logValue / Q[i, i];

                    t = t + tau;

                    //Arrayoftime[i] = t;
                    Arrayoftime.SetValue(t, i);

                    Q[i, j] = -Q[i, j] / Q[i, i];

                    p1 = Q[i, j];


                    Q[i, j + 1] = -Q[i, j + 1] / Q[i, i];

                    p2 = Q[i, j + 1];

                    textBox1.Text = Q[i, j + 1].ToString();

                    Q[i, j + 2] = -Q[i, j + 2] / Q[i, i];

                    p3 = Q[i, j + 2];




                    ArrayofProbabilities[0] = p1;
                    ArrayofProbabilities[1] = p2;
                    ArrayofProbabilities[2] = p3;


                    i++;
                    GenerateRV();
                }
            

       




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }

}


