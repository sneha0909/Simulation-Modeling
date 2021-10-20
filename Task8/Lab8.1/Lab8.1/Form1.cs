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
    public partial class Form1 : Form                                                                                                                                                                               
    {
        public Form1()
        {
            InitializeComponent();


           
        }

        //Let the event A be that I will go to Simulation Modeling Class or I will not go to the Simulation Modeling Class
        //Therefore, 
        //Probability that the event A occurs = P(A)
        //Number of event A occurs            = n(A)
        //Number of possible outcomes         = n(S)

        //Here, in our application the possible outcomes are : Yes,No
        //Therefore, the total number of possible outcomes = 2
        //The number of event A occurs = 1
        //Therefore the probability that event A occurs is, P(A) = 1/2 = 0.5




        double p = 0.5;

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
            double randomprobablity = RandomDoubleInclusive();
            

            if (randomprobablity < p) 
            {

                textBox1.Text = "Yes";
                Form2 form2 = new Form2();
                form2.Show();

            }
            else
            {
                textBox1.Text = "No";
                Form2 form2 = new Form2();
                form2.Show();

            }
        }
    }
}
