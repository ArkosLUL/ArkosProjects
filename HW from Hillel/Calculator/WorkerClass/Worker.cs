using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    class Worker
    {
        private string workerSurnameAndInitials;
        private string workerPosition;
        private int workerYearOfEmployment;

        public string WorkerSurnameAndInitials
        {
            get
            {
                return workerSurnameAndInitials;
            }
        }

        public string WorkerPosition
        {
            get
            {
                return workerPosition;
            }
        }

        public int WorkerYearOfEmployment
        {
            get
            {
                return workerYearOfEmployment;
            }
        }

        public Worker(string surnameAndInitials, string workerPosition, int yearOfEmployment)
        {
            this.workerSurnameAndInitials = surnameAndInitials;
            this.workerPosition = workerPosition;
            this.workerYearOfEmployment = yearOfEmployment;
        }
    }
}
