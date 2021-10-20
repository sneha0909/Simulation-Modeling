using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        
        private void btStart_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            double price = (double)edPrice.Value;
            int days = (int)edDays.Value;
            double drift = Convert.ToDouble(edDrift.Text);
            double standarddeviation = Convert.ToDouble(edDeviation.Text);

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, price);


            double squareofdeviation = standarddeviation * standarddeviation;
            double divisionpart = squareofdeviation / 2;

            double part1 = drift - divisionpart;

            int part2 = (days + 1) - days;

            double ti = 0.5;

            

            double[] Statistics = new double[10000];


            //for (int i = 1; i <= days; i++)
            //{

            //    double randomtimes = new Random().NextDouble();

            //    Statistics[i] = randomtimes;
            //    i++;

  
            //}

          

            for (int day = 1; day <= days; day++)
            {
                //double random = new Random().NextDouble();   //N(0,1)
                //double squareroo = Statistics[day + 1] - Statistics[day]; //(ti + 1) - ti

                //ti = Statistics[day] + Math.Sqrt(squareroo) * random; // w(ti + 1) = w(ti) + sqrt(ti+1 - ti)*N(0,1) : Simulation formula for Brownian Motion(Weiner Process)

                double part3 = standarddeviation * ti;

                double exponentialpart = part1 * part2 + part3;

                //price = price * (1 + k * (random.NextDouble() - 0.5));

                price = price * Math.Exp(exponentialpart);
                chart1.Series[0].Points.AddXY(day, price);
                
            }
        }

        private void edPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
