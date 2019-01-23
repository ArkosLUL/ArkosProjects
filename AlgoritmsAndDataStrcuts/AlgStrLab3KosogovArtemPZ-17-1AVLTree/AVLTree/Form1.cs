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

namespace AVLTree
{
    public partial class Form1 : Form
    {
        private AVL avlTree = new AVL();
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateTree()
        {
            treeView1.Nodes.Clear();
            if (avlTree.IsEmpty() == false)
            {
                deleteBtn.Enabled = true;
                searchBtn.Enabled = true;
                TreeNode rootNode = new TreeNode(avlTree.root.data.ToString());
                treeView1.Nodes.Add(rootNode);
                FillTree(rootNode, avlTree.root);
                treeView1.ExpandAll();
                depthLabel.Text = avlTree.GetHeight(avlTree.root).ToString();
                IsEmptyLabelValue.Text = avlTree.IsEmpty().ToString();
            }
            else
            {
                deleteBtn.Enabled = searchBtn.Enabled = false;
            }
        }

        private void FillTree(TreeNode tr, Node atr)
        {
            if (atr.left != null)
            {
                TreeNode newNode = new TreeNode("Left: " + atr.left.data.ToString());
                tr.Nodes.Add(newNode);
                FillTree(newNode, atr.left);
            }
            if (atr.right != null)
            {
                TreeNode newNode = new TreeNode("Right: " + atr.right.data.ToString());
                tr.Nodes.Add(newNode);
                FillTree(newNode, atr.right);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (addTextBox.Text != "")
            {
                try
                {
                    avlTree.Add(Convert.ToInt32(addTextBox.Text));
                    UpdateTree();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Некорректный ключ. " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                addTextBox.Clear();

            }
            else
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (deleteTextBox.Text == "")
            {
                MessageBox.Show("\nВы ничего не ввели", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(deleteTextBox.Text, out int x))
            {
                MessageBox.Show("\nКлюч  должен быть в виде цифры", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Node temp = null;
            int Temp;
            try
            {
                temp = avlTree.Find(x);
                //MessageBox.Show(tree.Show(temp), "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temp = temp.data;
                temp = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("\nЭлемента нет в дереве", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            avlTree.Delete(x);
            UpdateTree();
            deleteTextBox.Clear();
            MessageBox.Show("\nЭлемент со значением = " + Temp.ToString() + " удален", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("\nВы ничего не ввели", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(searchTextBox.Text, out int x))
            {
                MessageBox.Show("\nКлюч  должен быть в виде цифры", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Node temp = avlTree.Find(x);
                MessageBox.Show(temp.data.ToString(), "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("\nЭлемента нет в дереве", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (temp != null)
            //{

            //    MessageBox.Show(tree.Show(temp), "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //}
            //else MessageBox.Show("\nЭлемента нет в дереве", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            searchTextBox.Clear();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            string fileName = null;
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog1.Filter = "txt files (*.txt)|*.txt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }
            }
            if (fileName != null)
            {
                string[] lines = File.ReadAllLines(fileName, Encoding.GetEncoding(1251));
                foreach (string str in lines)
                {
                    string[] str1 = str.Split(new char[] { ' ' });
                    try
                    {
                        for (int i = 0; i < str1.Length; i++)
                        {
                            avlTree.Add(Convert.ToInt32(str1[i]));
                        }
                    }

                    catch (Exception ex)
                    {
                    }
                }
                UpdateTree();
                deleteBtn.Enabled = searchBtn.Enabled = true;
            }
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            avlTree.Delete();
            UpdateTree();
            MessageBox.Show("Удаление дерева", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
