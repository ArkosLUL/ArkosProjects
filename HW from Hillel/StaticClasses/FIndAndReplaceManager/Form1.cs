using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIndAndReplaceManager
{
    public partial class Form1 : Form
    {
        string stringWhereToFind;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Environment.CurrentDirectory;
                fileDialog.Filter = "*.txt | *.TXT";
                if(DialogResult.OK == fileDialog.ShowDialog())
                {
                    stringWhereToFind = File.ReadAllText(fileDialog.FileName, Encoding.GetEncoding(1251));
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
           searchReseultLabel.Text = FindAndReplaceManager.FindNext(searchTextBox.Text, stringWhereToFind).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
