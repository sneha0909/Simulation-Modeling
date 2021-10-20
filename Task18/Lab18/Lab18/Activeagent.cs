using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public interface Activeagent //Base Class
    {
        double getNextEvent();
        void processEvent();
    }
}
