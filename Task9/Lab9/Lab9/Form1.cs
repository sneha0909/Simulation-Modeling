using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //chart1.Series["Customers"].XValueMember = "X"; //Customers
            //chart1.Series["Resources"].YValueMembers = "Y"; //Resources
            //chart1.ChartAreas[0].AxisX.Minimum = double.NaN;
            //chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            //chart1.ChartAreas[0].AxisY.Minimum = double.NaN;
            //chart1.ChartAreas[0].AxisY.IsMarginVisible = true;
        }

        int[] Statistics  = new int[5];
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

        
        private void textBox5_TextChanged(object sender, EventArgs e)
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



                    }
                    break;



                }

                    
                
                
            }

            textBox7.Text = Frequency[0].ToString();
            textBox8.Text = Frequency[1].ToString();
            textBox9.Text = Frequency[2].ToString();
            textBox10.Text = Frequency[3].ToString();
            textBox11.Text = Frequency[4].ToString();


        }
    }
}
