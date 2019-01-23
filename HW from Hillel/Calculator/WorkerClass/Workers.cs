using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    class Workers
    {
        List<Worker> workers;
        List<Worker> temp;

        public Workers()
        {
             workers = new List<Worker>();
             temp = new List<Worker>();
        }

        /// <summary>
        /// Добавление рабочего в список рабочих
        /// </summary>
        /// <param name="worker">Рабочий</param>
        public void InputUserData(Worker worker)
        {
            workers.Add(worker);
        }

        /// <summary>
        /// Вывод работников, чей стаж выше указанного пользователем
        /// </summary>
        public void Print(int experience)
        {
            foreach (var worker in workers)
            {
                if(experience <= DateTime.Now.Year -  worker.WorkerYearOfEmployment )
                Show(worker);
            }
        }

        /// <summary>
        /// Вывод работников на консоль из списка
        /// </summary>
        public void Print()
        {
            foreach (var worker in workers)
            {               
                    Show(worker);
            }
        }

        /// <summary>
        /// Вывод отсортированного списка работников по фамилии в алфавитном порядке
        /// </summary>
        /// <param name="isSorted">Сортировать?</param>
        public void Print(bool isSorted)
        {
            if (isSorted)
            {
                temp = workers.OrderBy(x => x.WorkerSurnameAndInitials).ToList();
                foreach (var worker in temp)
                {
                    Show(worker);
                }
            }
        }

        /// <summary>
        /// Вывод на консоль информации о работнике
        /// </summary>
        /// <param name="worker"></param>
        private void Show(Worker worker)
        {
            Console.WriteLine($"{worker.WorkerSurnameAndInitials}-->{worker.WorkerPosition}-->{worker.WorkerYearOfEmployment}");
        }
    }
}
