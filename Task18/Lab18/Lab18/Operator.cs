using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class Operator : Activeagent //Operator class is inherited from Base Class Activeagent
    {
        private Queue queueCust;
        private Model rand;
        private int currentCust;
        private int totalCust;
        private int servedCust;
        private double workTime;

        public bool isFree
        {
            get
            {
                return currentCust < totalCust;
            }
        }

        public void service()
        {
            if (totalCust == currentCust)
            {
                return;
            }
            currentCust++;
        }

        public int servedCustomer
        {
            get
            {
                return servedCust;
            }

        }

        public Operator(double workTimes, int count, Queue cQueue)
        {
            totalCust = count;
            servedCust = 0;
            currentCust = 0;
            queueCust = cQueue;
            rand = new Model();
            workTime = workTimes;
        }

        public double getNextEvent()
        {
            if (currentCust == 0)
            {
                return double.PositiveInfinity;
            }
            return rand.Time(currentCust * workTime);
            //throw new NotImplementedException();
        }

        public void processEvent()
        {
            servedCust++;
            if (queueCust.queueisempty)
            {
                currentCust--;
                return;
            }
            queueCust.decreasingqueue();
            //throw new NotImplementedException();
        }
    }
}
