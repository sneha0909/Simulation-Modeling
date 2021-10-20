using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    
    public class Queue
    {
        int customer; //created field

        public Queue() //Constructor to initialize the field
        {
            customer = 0;
        }

        public void increasingqueue () //method to increase the number of customers in queue
        {
            customer++;

        }


        public void decreasingqueue() //method to decrease the number of customers in queue
        {
            customer--;

        }

        public bool queueisempty //method to check if queue is empty
        {
            get //inbuilt get method (accessor)
            {
                return customer == 0;
            }

        }


        public int c
        {
            get 
            
            {
                return customer;
            }

        }










    }














}
