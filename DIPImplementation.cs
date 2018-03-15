using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DIPrinciple
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
    }
    public interface ILogger
    {
        void LogError(Exception e);
    }

    public class FileLogger : ILogger
    {
        public void LogError(Exception e)
        {
            //Log Error in a physical file
        }
    }
    public class EventViewerLogger : ILogger
    {
        public void LogError(Exception e)
        {
            //Log Error in a physical file
        }
    }
    public class CustomerBAL
    {
        private ILogger _objLogger;
        public CustomerBAL(ILogger objLogger)
        {
            _objLogger = objLogger;
        }

        public void Insert(Customer c)
        {
            try
            {
                //Insert logic
            }
            catch (Exception e)
            {
                _objLogger.LogError(e);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ILogger mylogger = new EventViewerLogger();
            CustomerBAL custBAL = new CustomerBAL(mylogger);

            ILogger myfilelogger = new FileLogger();
            CustomerBAL custBAL1 = new CustomerBAL(myfilelogger);
        }
    }
}