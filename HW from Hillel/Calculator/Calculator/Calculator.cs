using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseCalculator
{
    class Calculator
    {
        private string stringToParse;
        
        

        public Calculator()
        {
            stringToParse = EvaluatingMachine.GetStringFromConsole();
        }

        public string StringToParse
        {
            get
            {
                return stringToParse;
            }
        }

        public void Show()
        {
            EvaluatingMachine.GetPostfixNotation();
            
            Console.WriteLine("Result = " + EvaluatingMachine.EvaluatePostfixExpression());
        }
    }
}
