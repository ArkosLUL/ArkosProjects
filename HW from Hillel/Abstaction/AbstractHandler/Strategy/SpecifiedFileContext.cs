using DifferentStrategyS.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DifferentExtension.Strategy.ConcreteStrategy;

namespace DifferentExtension.Strategy
{
    class SpecifiedFileContext
    {
        AbstractHandler strategy;

        public SpecifiedFileContext(string path)
        {
            ChooseExtension(path);
        }
        private void ChooseExtension(string path)
        {
            string tempPath = Path.GetExtension(path);
            switch (tempPath)
            {
                case ".xml":
                    {

                        strategy = new XMLHandler(path);
                        break;
                    }

                case ".txt":
                    {

                        strategy = new TXTHandler(path);
                        break;

                    }
                case ".docx":
                    {

                        strategy = new DOCHandler(path);
                        break;

                    }
            }

        }

        public void Open()
        {
            if (strategy != null)
            {
                strategy.Open();
            }
        }

        public void Create()
        {
            if (strategy != null)
            {
                strategy.Create();
            }
        }

        public void Change()
        {
            if (strategy != null)
            {
                strategy.Change();
            }
        }

        public void Save()
        {
            if (strategy != null)
            {
                strategy.Save();
            }
        }
    }
}
