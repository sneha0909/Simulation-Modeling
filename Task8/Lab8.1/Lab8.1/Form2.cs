using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double p = 0.5;
        //double p1 = 0.05;
        //double p2 = 0.05;
        //double p3 = 0.05;
        //double p4 = 0.05;
        //double p5 = 0.05;
        //double p6 = 0.05;
        //double p7 = 0.05;
        //double p8 = 0.05;
        //double p9 = 0.05;
        //double p10 = 0.05;
        //double p11 = 0.05;
        //double p12 = 0.05;
        //double p13 = 0.05;
        //double p14 = 0.05;
        //double p15 = 0.05;
        //double p16 = 0.05;
        //double p17 = 0.05;
        //double p18 = 0.05;
        //double p19 = 0.05;
        //double p20 = 0.05;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double A = RandomDoubleInclusive();
            for (k = 1; k < 21;)
            {


                A = A - p;


                if (A <= 0)
                {
                    switch (k)
                    {

                        case 1:

                            textBox1.Text = "It is certain.";
                            break;
                        case 2:

                            textBox1.Text = "It is decidedly so.";
                            break;
                        case 3:

                            textBox2.Text = "Without a doubt.";
                            break;
                        case 4:

                            textBox2.Text = "Yes – definitely.";
                            break;
                        case 5:

                            textBox2.Text = " You may rely on it.";
                            break;
                        case 6:

                            textBox2.Text = "As I see it, yes.";
                            break;
                        case 7:

                            textBox2.Text = "Most likely.";
                            break;
                        case 8:

                            textBox2.Text = "Outlook good.";
                            break;
                        case 9:

                            textBox2.Text = "Yes.";
                            break;
                        case 10:

                            textBox2.Text = "Signs point to yes.";
                            break;
                        case 11:

                            textBox2.Text = "Reply hazy, try again.";
                            break;
                        case 12:

                            textBox2.Text = " Ask again later.";
                            break;
                        case 13:

                            textBox2.Text = " Better not tell you now.";
                            break;
                        case 14:

                            textBox2.Text = " Cannot predict now.";
                            break;

                        case 15:

                            textBox2.Text = "Concentrate and ask again.";
                            break;
                        case 16:

                            textBox2.Text = "Don't count on it.";
                            break;
                        case 17:

                            textBox2.Text = "My reply is no.";
                            break;
                        case 18:

                            textBox2.Text = "My sources say no.";
                            break;
                        case 19:

                            textBox2.Text = "Outlook not so good.";
                            break;
                        case 20:

                            textBox2.Text = "Very doubtful.";
                            break;



                    }
                    break;




                }

                else
                {
                    k++;
                    

                }



            }
            
        }
    }
}
