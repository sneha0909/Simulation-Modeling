using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    /// <summary>
    /// Assumption:
    /// More Available Customers -> Resources decreases
    /// Assume atleast 1 customer consumes 1/2 of our food resources
    /// </summary>
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            InitializeComponent();
            chartSample.Series["Customers"].XValueMember = "X"; //Customers
            chartSample.Series["Resources"].YValueMembers = "Y"; //Resources
            chartSample.ChartAreas[0].AxisX.Minimum = double.NaN;
            chartSample.ChartAreas[0].AxisX.IsMarginVisible = false;
            chartSample.ChartAreas[0].AxisY.Minimum = double.NaN;
            chartSample.ChartAreas[0].AxisY.IsMarginVisible = true;
        }

        //Display a message box.
        DialogResult m1 = MessageBox.Show("Immediately enter your number.(Copy & Paste).\nInstead of typing it out.\nOkay?",
                                           "ATTENTION", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information,
                                           MessageBoxDefaultButton.Button1);

        double resvalue;
        double cusvalue;
        private void txtCus_TextChanged(object sender, EventArgs e)
        {
            //if(!timer1.Enabled)
            //{
                if (double.TryParse(txtCus.Text, out cusvalue))
                {
                    resvalue = cusvalue / 2;
                    txtRes.Text = resvalue.ToString();
                    chartSample.Series["Customers"].Points.AddXY(0, cusvalue);
                    chartSample.Series["Resources"].Points.AddXY(0, resvalue);

                    //timer1.Start();
                }
                else
                {
                    MessageBox.Show("Error: Invalid Value.");
                    //foreach (var series in chartSample.Series)
                    //{
                    //    series.Points.Clear();
                    //}
                }
            //}
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    chartSample.Series[0].Points.AddXY(0, resvalue);
        //    chartSample.Series[1].Points.AddXY(0, cusvalue);
        //    if (cusvalue == (resvalue/2)) timer1.Stop();
        //}

        private void button1_Click(object sender, EventArgs e) //Reset Button
        {
            foreach (var series in chartSample.Series)
            {
                series.Points.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Quit Button
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
