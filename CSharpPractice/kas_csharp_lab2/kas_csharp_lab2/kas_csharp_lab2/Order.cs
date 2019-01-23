using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    public class Order
    {
        public string OrderSubject
        { get; set; }
        public DateTime DateAndTimeOfOrder
        { get; set; }
        public int OrderExecutionTime
        { get; set; }
        public Order(string ordersubject, DateTime dateandtimeoforder, int orderexecutiontime)
        {
            OrderSubject = ordersubject;
            DateAndTimeOfOrder = dateandtimeoforder;
            OrderExecutionTime = orderexecutiontime;
        }
        public Order()
        {
            OrderSubject = "BlankOrderSubject";
            DateAndTimeOfOrder = DateTime.Today;
            OrderExecutionTime = 0;
        }
        public override string ToString()
        {
            return String.Format("\nOrder subject: " + OrderSubject + "\nDate and time of order: " + DateAndTimeOfOrder + "\nOrder execution time: " + OrderExecutionTime + "\n");
        }
        public object DeepCopy()
        {
            object order = new Order();
            ((Order)order).OrderSubject = this.OrderSubject;
            ((Order)order).DateAndTimeOfOrder = this.DateAndTimeOfOrder;
            ((Order)order).OrderExecutionTime = this.OrderExecutionTime;
            return order;
        }

    }
}
