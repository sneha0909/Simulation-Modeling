using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class Customer : Activeagent //Customer class is inherited from Base Class Activeagent
    {
        private Model rand;
        private double arrivalTime;
        private Bank bank;

        public Customer(double ArrivalTime, Bank banks)
        {
            rand = new Model();
            arrivalTime = ArrivalTime;
            bank = banks;
        }

        public double getNextEvent()
        {
            return rand.Time(arrivalTime);
            
        }

        public void processEvent()
        {
            bank.service();
            
        }
    }
}
