namespace AVLTree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.addBtn = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.IsEmptyLabel = new System.Windows.Forms.Label();
            this.IsEmptyLabelValue = new System.Windows.Forms.Label();
            this.deleteAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1021, 505);
            this.treeView1.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1145, 41);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(1039, 42);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(100, 22);
            this.addTextBox.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(1145, 70);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(1039, 71);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(100, 22);
            this.deleteTextBox.TabIndex = 4;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(1039, 99);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 22);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.Enabled = false;
            this.searchBtn.Location = new System.Drawing.Point(1145, 98);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(1145, 12);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 7;
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1091, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Depth";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.depthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depthLabel.Location = new System.Drawing.Point(1145, 153);
            this.depthLabel.MinimumSize = new System.Drawing.Size(35, 0);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(35, 19);
            this.depthLabel.TabIndex = 9;
            this.depthLabel.Text = "0";
            // 
            // IsEmptyLabel
            // 
            this.IsEmptyLabel.AutoSize = true;
            this.IsEmptyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IsEmptyLabel.Location = new System.Drawing.Point(1077, 185);
            this.IsEmptyLabel.Name = "IsEmptyLabel";
            this.IsEmptyLabel.Size = new System.Drawing.Size(59, 19);
            this.IsEmptyLabel.TabIndex = 10;
            this.IsEmptyLabel.Text = "IsEmpty";
            // 
            // IsEmptyLabelValue
            // 
            this.IsEmptyLabelValue.AutoSize = true;
            this.IsEmptyLabelValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IsEmptyLabelValue.Location = new System.Drawing.Point(1142, 185);
            this.IsEmptyLabelValue.MinimumSize = new System.Drawing.Size(35, 0);
            this.IsEmptyLabelValue.Name = "IsEmptyLabelValue";
            this.IsEmptyLabelValue.Size = new System.Drawing.Size(40, 19);
            this.IsEmptyLabelValue.TabIndex = 11;
            this.IsEmptyLabelValue.Text = "false";
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.Location = new System.Drawing.Point(1039, 127);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(181, 23);
            this.deleteAllBtn.TabIndex = 12;
            this.deleteAllBtn.Text = "Delete all tree";
            this.deleteAllBtn.UseVisualStyleBackColor = true;
            this.deleteAllBtn.Click += new System.EventHandler(this.deleteAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 529);
            this.Controls.Add(this.deleteAllBtn);
            this.Controls.Add(this.IsEmptyLabelValue);
            this.Controls.Add(this.IsEmptyLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.deleteTextBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "AVLTree Alg Str Lab3 Kosogov Artem PZ-17-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label IsEmptyLabel;
        private System.Windows.Forms.Label IsEmptyLabelValue;
        private System.Windows.Forms.Button deleteAllBtn;
    }
}

