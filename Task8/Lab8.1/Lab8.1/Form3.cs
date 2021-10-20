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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        double p = 0.5;
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
        private void button1_Click(object sender, EventArgs e)
        {
           
            double A = RandomDoubleInclusive();

            for (k = 1; k < 21;)
            {

                A = A - p;

                if (A < p)
                {

                    textBox2.Text = "Yes";
                    break;


                }
                else
                {
                    textBox2.Text = "No";
                    break;


                }
            }




        }
    }
}
