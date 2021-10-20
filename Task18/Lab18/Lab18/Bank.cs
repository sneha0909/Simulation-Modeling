using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class Bank : Activeagent //Bank class is inherited from Base Class Activeagent
    {
        private Queue custQ;
        private Operator op;

        public Bank(double workTime, int opCount)
        {
            custQ = new Queue();
            op = new Operator(workTime, opCount, custQ);
        }

        public int waitingLine
        {
            get
            {
                return custQ.c;
            }
        }

        public int accept
        {
            get
            {
                return op.servedCustomer;
            }
        }

        public void service()
        {
            if (op.isFree)
            {
                op.service();
                return;
            }
            custQ.increasingqueue();
        }

        public double getNextEvent()
        {
            return op.getNextEvent();
            //throw new NotImplementedException();
        }

        public void processEvent()
        {
            op.processEvent();
            //throw new NotImplementedException();
        }
    }
}
