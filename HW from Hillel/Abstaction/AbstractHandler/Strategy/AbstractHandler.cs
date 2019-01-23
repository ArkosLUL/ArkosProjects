using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentStrategyS.Strategy
{
    abstract class AbstractHandler
    {
        /* Создайте класс AbstractHandler.
         В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
         Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
         Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа. */
        public abstract void Open();

        public abstract void Create();

        public abstract void Change();

        public abstract void Save();
        
    }
}
