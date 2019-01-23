namespace AlgStrLab2KosogovArtemPZ_17_1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Push1Btn = new System.Windows.Forms.Button();
            this.Pop1Btn = new System.Windows.Forms.Button();
            this.Peek1Btn = new System.Windows.Forms.Button();
            this.PushTextBox1 = new System.Windows.Forms.TextBox();
            this.Unite1Btn = new System.Windows.Forms.Button();
            this.Divide1Btn = new System.Windows.Forms.Button();
            this.DivideTextBox1 = new System.Windows.Forms.TextBox();
            this.DivideTextBox2 = new System.Windows.Forms.TextBox();
            this.Divide2Btn = new System.Windows.Forms.Button();
            this.Unite2Btn = new System.Windows.Forms.Button();
            this.PushTextBox2 = new System.Windows.Forms.TextBox();
            this.Peek2Btn = new System.Windows.Forms.Button();
            this.Pop2Btn = new System.Windows.Forms.Button();
            this.Push2Btn = new System.Windows.Forms.Button();
            this.Copy1Btn = new System.Windows.Forms.Button();
            this.Copy2Btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeLabel11 = new System.Windows.Forms.Label();
            this.SizeLabel12 = new System.Windows.Forms.Label();
            this.SizeLabel22 = new System.Windows.Forms.Label();
            this.SizeLabel21 = new System.Windows.Forms.Label();
            this.deleteStack1Btn = new System.Windows.Forms.Button();
            this.deleteStack2Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(16, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(267, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Stack";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(784, 52);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(267, 456);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "SecondStack";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Push1Btn
            // 
            this.Push1Btn.Location = new System.Drawing.Point(376, 52);
            this.Push1Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Push1Btn.Name = "Push1Btn";
            this.Push1Btn.Size = new System.Drawing.Size(100, 28);
            this.Push1Btn.TabIndex = 2;
            this.Push1Btn.Text = "Push";
            this.Push1Btn.UseVisualStyleBackColor = true;
            this.Push1Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pop1Btn
            // 
            this.Pop1Btn.Location = new System.Drawing.Point(376, 87);
            this.Pop1Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Pop1Btn.Name = "Pop1Btn";
            this.Pop1Btn.Size = new System.Drawing.Size(100, 28);
            this.Pop1Btn.TabIndex = 7;
            this.Pop1Btn.Text = "Pop";
            this.Pop1Btn.UseVisualStyleBackColor = true;
            this.Pop1Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Peek1Btn
            // 
            this.Peek1Btn.Location = new System.Drawing.Point(376, 123);
            this.Peek1Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Peek1Btn.Name = "Peek1Btn";
            this.Peek1Btn.Size = new System.Drawing.Size(100, 28);
            this.Peek1Btn.TabIndex = 10;
            this.Peek1Btn.Text = "Peek";
            this.Peek1Btn.UseVisualStyleBackColor = true;
            this.Peek1Btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // PushTextBox1
            // 
            this.PushTextBox1.Location = new System.Drawing.Point(291, 54);
            this.PushTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PushTextBox1.Name = "PushTextBox1";
            this.PushTextBox1.Size = new System.Drawing.Size(76, 22);
            this.PushTextBox1.TabIndex = 14;
            // 
            // Unite1Btn
            // 
            this.Unite1Btn.Location = new System.Drawing.Point(376, 159);
            this.Unite1Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Unite1Btn.Name = "Unite1Btn";
            this.Unite1Btn.Size = new System.Drawing.Size(100, 28);
            this.Unite1Btn.TabIndex = 15;
            this.Unite1Btn.Text = "Unite";
            this.Unite1Btn.UseVisualStyleBackColor = true;
            this.Unite1Btn.Click += new System.EventHandler(this.Unite1Btn_Click);
            // 
            // Divide1Btn
            // 
            this.Divide1Btn.Location = new System.Drawing.Point(376, 194);
            this.Divide1Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Divide1Btn.Name = "Divide1Btn";
            this.Divide1Btn.Size = new System.Drawing.Size(100, 28);
            this.Divide1Btn.TabIndex = 16;
            this.Divide1Btn.Text = "Divide";
            this.Divide1Btn.UseVisualStyleBackColor = true;
            this.Divide1Btn.Click += new System.EventHandler(this.Divide1Btn_Click);
            // 
            // DivideTextBox1
            // 
            this.DivideTextBox1.Location = new System.Drawing.Point(291, 198);
            this.DivideTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DivideTextBox1.Name = "DivideTextBox1";
            this.DivideTextBox1.Size = new System.Drawing.Size(76, 22);
            this.DivideTextBox1.TabIndex = 17;
            // 
            // DivideTextBox2
            // 
            this.DivideTextBox2.Location = new System.Drawing.Point(699, 194);
            this.DivideTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.DivideTextBox2.Name = "DivideTextBox2";
            this.DivideTextBox2.Size = new System.Drawing.Size(76, 22);
            this.DivideTextBox2.TabIndex = 24;
            // 
            // Divide2Btn
            // 
            this.Divide2Btn.Location = new System.Drawing.Point(591, 192);
            this.Divide2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Divide2Btn.Name = "Divide2Btn";
            this.Divide2Btn.Size = new System.Drawing.Size(100, 28);
            this.Divide2Btn.TabIndex = 23;
            this.Divide2Btn.Text = "Divide";
            this.Divide2Btn.UseVisualStyleBackColor = true;
            this.Divide2Btn.Click += new System.EventHandler(this.Divide2Btn_Click);
            // 
            // Unite2Btn
            // 
            this.Unite2Btn.Location = new System.Drawing.Point(591, 156);
            this.Unite2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Unite2Btn.Name = "Unite2Btn";
            this.Unite2Btn.Size = new System.Drawing.Size(100, 28);
            this.Unite2Btn.TabIndex = 22;
            this.Unite2Btn.Text = "Unite";
            this.Unite2Btn.UseVisualStyleBackColor = true;
            this.Unite2Btn.Click += new System.EventHandler(this.Unite2Btn_Click);
            // 
            // PushTextBox2
            // 
            this.PushTextBox2.Location = new System.Drawing.Point(699, 52);
            this.PushTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PushTextBox2.Name = "PushTextBox2";
            this.PushTextBox2.Size = new System.Drawing.Size(76, 22);
            this.PushTextBox2.TabIndex = 21;
            // 
            // Peek2Btn
            // 
            this.Peek2Btn.Location = new System.Drawing.Point(591, 121);
            this.Peek2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Peek2Btn.Name = "Peek2Btn";
            this.Peek2Btn.Size = new System.Drawing.Size(100, 28);
            this.Peek2Btn.TabIndex = 20;
            this.Peek2Btn.Text = "Peek";
            this.Peek2Btn.UseVisualStyleBackColor = true;
            this.Peek2Btn.Click += new System.EventHandler(this.Peek2Btn_Click);
            // 
            // Pop2Btn
            // 
            this.Pop2Btn.Location = new System.Drawing.Point(591, 85);
            this.Pop2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Pop2Btn.Name = "Pop2Btn";
            this.Pop2Btn.Size = new System.Drawing.Size(100, 28);
            this.Pop2Btn.TabIndex = 19;
            this.Pop2Btn.Text = "Pop";
            this.Pop2Btn.UseVisualStyleBackColor = true;
            this.Pop2Btn.Click += new System.EventHandler(this.Pop2Btn_Click);
            // 
            // Push2Btn
            // 
            this.Push2Btn.Location = new System.Drawing.Point(591, 49);
            this.Push2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Push2Btn.Name = "Push2Btn";
            this.Push2Btn.Size = new System.Drawing.Size(100, 28);
            this.Push2Btn.TabIndex = 18;
            this.Push2Btn.Text = "Push";
            this.Push2Btn.UseVisualStyleBackColor = true;
            this.Push2Btn.Click += new System.EventHandler(this.Push2Btn_Click);
            // 
            // Copy1Btn
            // 
            this.Copy1Btn.Location = new System.Drawing.Point(376, 230);
            this.Copy1Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Copy1Btn.Name = "Copy1Btn";
            this.Copy1Btn.Size = new System.Drawing.Size(100, 28);
            this.Copy1Btn.TabIndex = 25;
            this.Copy1Btn.Text = "Copy";
            this.Copy1Btn.UseVisualStyleBackColor = true;
            this.Copy1Btn.Click += new System.EventHandler(this.Copy1Btn_Click);
            // 
            // Copy2Btn
            // 
            this.Copy2Btn.Location = new System.Drawing.Point(591, 228);
            this.Copy2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Copy2Btn.Name = "Copy2Btn";
            this.Copy2Btn.Size = new System.Drawing.Size(100, 28);
            this.Copy2Btn.TabIndex = 26;
            this.Copy2Btn.Text = "Copy";
            this.Copy2Btn.UseVisualStyleBackColor = true;
            this.Copy2Btn.Click += new System.EventHandler(this.Copy2Btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // SizeLabel11
            // 
            this.SizeLabel11.AutoSize = true;
            this.SizeLabel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SizeLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel11.Location = new System.Drawing.Point(16, 512);
            this.SizeLabel11.Name = "SizeLabel11";
            this.SizeLabel11.Size = new System.Drawing.Size(111, 40);
            this.SizeLabel11.TabIndex = 28;
            this.SizeLabel11.Text = "Size =";
            // 
            // SizeLabel12
            // 
            this.SizeLabel12.AutoSize = true;
            this.SizeLabel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SizeLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel12.Location = new System.Drawing.Point(137, 512);
            this.SizeLabel12.Name = "SizeLabel12";
            this.SizeLabel12.Size = new System.Drawing.Size(2, 40);
            this.SizeLabel12.TabIndex = 29;
            // 
            // SizeLabel22
            // 
            this.SizeLabel22.AutoSize = true;
            this.SizeLabel22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SizeLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel22.Location = new System.Drawing.Point(905, 512);
            this.SizeLabel22.Name = "SizeLabel22";
            this.SizeLabel22.Size = new System.Drawing.Size(2, 40);
            this.SizeLabel22.TabIndex = 31;
            // 
            // SizeLabel21
            // 
            this.SizeLabel21.AutoSize = true;
            this.SizeLabel21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SizeLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel21.Location = new System.Drawing.Point(784, 512);
            this.SizeLabel21.Name = "SizeLabel21";
            this.SizeLabel21.Size = new System.Drawing.Size(111, 40);
            this.SizeLabel21.TabIndex = 30;
            this.SizeLabel21.Text = "Size =";
            // 
            // deleteStack1Btn
            // 
            this.deleteStack1Btn.Location = new System.Drawing.Point(376, 266);
            this.deleteStack1Btn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStack1Btn.Name = "deleteStack1Btn";
            this.deleteStack1Btn.Size = new System.Drawing.Size(100, 28);
            this.deleteStack1Btn.TabIndex = 32;
            this.deleteStack1Btn.Text = "Delete";
            this.deleteStack1Btn.UseVisualStyleBackColor = true;
            this.deleteStack1Btn.Click += new System.EventHandler(this.deleteStack1Btn_Click);
            // 
            // deleteStack2Btn
            // 
            this.deleteStack2Btn.Location = new System.Drawing.Point(591, 264);
            this.deleteStack2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStack2Btn.Name = "deleteStack2Btn";
            this.deleteStack2Btn.Size = new System.Drawing.Size(100, 28);
            this.deleteStack2Btn.TabIndex = 33;
            this.deleteStack2Btn.Text = "Delete";
            this.deleteStack2Btn.UseVisualStyleBackColor = true;
            this.deleteStack2Btn.Click += new System.EventHandler(this.deleteStack2Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.deleteStack2Btn);
            this.Controls.Add(this.deleteStack1Btn);
            this.Controls.Add(this.SizeLabel22);
            this.Controls.Add(this.SizeLabel21);
            this.Controls.Add(this.SizeLabel12);
            this.Controls.Add(this.SizeLabel11);
            this.Controls.Add(this.Copy2Btn);
            this.Controls.Add(this.Copy1Btn);
            this.Controls.Add(this.DivideTextBox2);
            this.Controls.Add(this.Divide2Btn);
            this.Controls.Add(this.Unite2Btn);
            this.Controls.Add(this.PushTextBox2);
            this.Controls.Add(this.Peek2Btn);
            this.Controls.Add(this.Pop2Btn);
            this.Controls.Add(this.Push2Btn);
            this.Controls.Add(this.DivideTextBox1);
            this.Controls.Add(this.Divide1Btn);
            this.Controls.Add(this.Unite1Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PushTextBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Peek1Btn);
            this.Controls.Add(this.Pop1Btn);
            this.Controls.Add(this.Push1Btn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Stack Realization using List PZ-17-1 Kosogov Artem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Push1Btn;
        private System.Windows.Forms.Button Pop1Btn;
        private System.Windows.Forms.Button Peek1Btn;
        private System.Windows.Forms.TextBox PushTextBox1;
        private System.Windows.Forms.Button Unite1Btn;
        private System.Windows.Forms.Button Divide1Btn;
        private System.Windows.Forms.TextBox DivideTextBox1;
        private System.Windows.Forms.TextBox DivideTextBox2;
        private System.Windows.Forms.Button Divide2Btn;
        private System.Windows.Forms.Button Unite2Btn;
        private System.Windows.Forms.TextBox PushTextBox2;
        private System.Windows.Forms.Button Peek2Btn;
        private System.Windows.Forms.Button Pop2Btn;
        private System.Windows.Forms.Button Push2Btn;
        private System.Windows.Forms.Button Copy1Btn;
        private System.Windows.Forms.Button Copy2Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label SizeLabel11;
        private System.Windows.Forms.Label SizeLabel12;
        private System.Windows.Forms.Label SizeLabel22;
        private System.Windows.Forms.Label SizeLabel21;
        private System.Windows.Forms.Button deleteStack1Btn;
        private System.Windows.Forms.Button deleteStack2Btn;
    }
}

