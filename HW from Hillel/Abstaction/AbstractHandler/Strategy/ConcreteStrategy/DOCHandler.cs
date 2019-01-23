using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.VisualBasic;
using System.Data;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using DifferentStrategyS.Strategy;

namespace DifferentExtension.Strategy.ConcreteStrategy
{
    class DOCHandler : AbstractHandler
    {
        WordprocessingDocument wordDocument;
        Body body;
        Paragraph para;
        Run run;
        MainDocumentPart mainPart;
        private FileInfo file;
        private DirectoryInfo directory;
        private StreamReader reader;
        private StreamWriter writer;
        private string fileContent;

        public DOCHandler(string path)
        {
            try
            {
                this.directory = new DirectoryInfo(Path.GetDirectoryName(path));
                this.file = new FileInfo(Path.GetFullPath(path));
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Проверьте путь к файлу или существование данного файла в указанной папке");
            }

        }

        public override void Open()
        {
            if (file.Exists)
            {
                wordDocument = WordprocessingDocument.Open(file.FullName, true);
                body = wordDocument.MainDocumentPart.Document.Body;
                para = body.AppendChild(new Paragraph());
                run = para.AppendChild(new Run());
            }
            else
            {
                Create();
            }
        }

        public override void Create()
        {
            wordDocument = WordprocessingDocument.Create(file.FullName, WordprocessingDocumentType.Document);

            mainPart = wordDocument.AddMainDocumentPart();

            mainPart.Document = new Document();
            body = mainPart.Document.AppendChild(new Body());
            para = body.AppendChild(new Paragraph());
            run = para.AppendChild(new Run());
        }

        public override void Save()
        {
            wordDocument.Close();
        }

        public override void Change()
        {
            string temp = Console.ReadLine();
            run.AppendChild(new Text(temp));
        }
    }
}
