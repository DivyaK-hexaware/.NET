using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DependencyInversionPrinciple
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int CustomerName { get; set; }
    }

    public class CustomerBAL
    {
        public void Insert(Customer c)
        {
            try
            {
                //Insert logic
            }
            catch (Exception e)
            {
                //Exception handling 
                FileLogger f = new FileLogger();
                f.LogError(e);
            }
        }
    }

    public class FileLogger
    {
        public void LogError(Exception e)
        {
            //Log Error in a physical file
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
