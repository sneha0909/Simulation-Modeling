using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Array of different probabilities of 6 possible answers of Dice
        double[] p = { 0.1, 0.25, 0.16, 0.14, 0.2, 0.15 };

        int k;

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
      
        public void functionfordice2() //Its a cheating dice
        {
            double A = RandomDoubleInclusive();
            for (k = 1; k < 10;)
            {

                for (int i = 0; i < p.Length; i++) //Looping over array of probabilities
                {
                    A = A - p[i];




                    if (A <= 0)
                    {
                        switch (k) // 9 Different cases in Cheating dice 
                        {

                            case 1:

                                pictureBox2.Image = Properties.Resources.Dice1;

                                break;
                            case 2:
                                pictureBox2.Image = Properties.Resources.Dice2;
                                break;
                            case 3:

                                pictureBox2.Image = Properties.Resources.Dice3;

                                break;
                            case 4:

                                pictureBox2.Image = Properties.Resources._4;
                                break;
                            case 5:

                                pictureBox2.Image = Properties.Resources.Dice5;
                                break;
                            case 6:

                                pictureBox2.Image = Properties.Resources.Dice6;
                                break;

                            case 7:

                                pictureBox2.Image = Properties.Resources.Dice6;
                                break;
                            case 8:

                                pictureBox2.Image = Properties.Resources.Dice6;
                                break;
                            case 9:

                                pictureBox2.Image = Properties.Resources.Dice6;
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

        int rollingtime = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rollingtime++;

            textBox1.Text = rollingtime.ToString();

            int newroll = 0;
            if (textBox1.Text == "20")
            {
                timer1.Stop();
                rollingtime = newroll;
            }

            
            functionfordice2();

            double A = RandomDoubleInclusive();
            for (k = 1; k < 7;)
            {

                for (int i = 0; i < p.Length; i++) //Looping over array of probabilities
                {
                    A = A - p[i];




                    if (A <= 0)
                    {
                        switch (k) // 6 Different cases in Dices
                        {

                            case 1:

                                pictureBox1.Image = Properties.Resources.Dice1;

                                break;
                            case 2:
                                pictureBox1.Image = Properties.Resources.Dice2;
                                break;
                            case 3:

                                pictureBox1.Image = Properties.Resources.Dice3;

                                break;
                            case 4:

                                pictureBox1.Image = Properties.Resources._4;
                                break;
                            case 5:

                                pictureBox1.Image = Properties.Resources.Dice5;
                                break;
                            case 6:

                                pictureBox1.Image = Properties.Resources.Dice6;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
