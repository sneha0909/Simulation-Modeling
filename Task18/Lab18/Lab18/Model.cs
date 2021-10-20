using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class Model
    {
        private Random rand;

        public Model()
        {
            rand = new Random();
        }

        public double Time(double l)
        {
            return -(Math.Log(rand.NextDouble()) / l);
        }
    }
}

