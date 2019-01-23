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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(200, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(588, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(200, 386);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Push1Btn
            // 
            this.Push1Btn.Location = new System.Drawing.Point(282, 42);
            this.Push1Btn.Name = "Push1Btn";
            this.Push1Btn.Size = new System.Drawing.Size(75, 23);
            this.Push1Btn.TabIndex = 2;
            this.Push1Btn.Text = "Push";
            this.Push1Btn.UseVisualStyleBackColor = true;
            this.Push1Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pop1Btn
            // 
            this.Pop1Btn.Location = new System.Drawing.Point(282, 71);
            this.Pop1Btn.Name = "Pop1Btn";
            this.Pop1Btn.Size = new System.Drawing.Size(75, 23);
            this.Pop1Btn.TabIndex = 7;
            this.Pop1Btn.Text = "Pop";
            this.Pop1Btn.UseVisualStyleBackColor = true;
            this.Pop1Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Peek1Btn
            // 
            this.Peek1Btn.Location = new System.Drawing.Point(282, 100);
            this.Peek1Btn.Name = "Peek1Btn";
            this.Peek1Btn.Size = new System.Drawing.Size(75, 23);
            this.Peek1Btn.TabIndex = 10;
            this.Peek1Btn.Text = "Peek";
            this.Peek1Btn.UseVisualStyleBackColor = true;
            this.Peek1Btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // PushTextBox1
            // 
            this.PushTextBox1.Location = new System.Drawing.Point(218, 44);
            this.PushTextBox1.Name = "PushTextBox1";
            this.PushTextBox1.Size = new System.Drawing.Size(58, 20);
            this.PushTextBox1.TabIndex = 14;
            // 
            // Unite1Btn
            // 
            this.Unite1Btn.Location = new System.Drawing.Point(282, 129);
            this.Unite1Btn.Name = "Unite1Btn";
            this.Unite1Btn.Size = new System.Drawing.Size(75, 23);
            this.Unite1Btn.TabIndex = 15;
            this.Unite1Btn.Text = "Unite";
            this.Unite1Btn.UseVisualStyleBackColor = true;
            this.Unite1Btn.Click += new System.EventHandler(this.Unite1Btn_Click);
            // 
            // Divide1Btn
            // 
            this.Divide1Btn.Location = new System.Drawing.Point(282, 158);
            this.Divide1Btn.Name = "Divide1Btn";
            this.Divide1Btn.Size = new System.Drawing.Size(75, 23);
            this.Divide1Btn.TabIndex = 16;
            this.Divide1Btn.Text = "Divide";
            this.Divide1Btn.UseVisualStyleBackColor = true;
            this.Divide1Btn.Click += new System.EventHandler(this.Divide1Btn_Click);
            // 
            // DivideTextBox1
            // 
            this.DivideTextBox1.Location = new System.Drawing.Point(218, 161);
            this.DivideTextBox1.Name = "DivideTextBox1";
            this.DivideTextBox1.Size = new System.Drawing.Size(58, 20);
            this.DivideTextBox1.TabIndex = 17;
            // 
            // DivideTextBox2
            // 
            this.DivideTextBox2.Location = new System.Drawing.Point(524, 158);
            this.DivideTextBox2.Name = "DivideTextBox2";
            this.DivideTextBox2.Size = new System.Drawing.Size(58, 20);
            this.DivideTextBox2.TabIndex = 24;
            // 
            // Divide2Btn
            // 
            this.Divide2Btn.Location = new System.Drawing.Point(443, 156);
            this.Divide2Btn.Name = "Divide2Btn";
            this.Divide2Btn.Size = new System.Drawing.Size(75, 23);
            this.Divide2Btn.TabIndex = 23;
            this.Divide2Btn.Text = "Divide";
            this.Divide2Btn.UseVisualStyleBackColor = true;
            // 
            // Unite2Btn
            // 
            this.Unite2Btn.Location = new System.Drawing.Point(443, 127);
            this.Unite2Btn.Name = "Unite2Btn";
            this.Unite2Btn.Size = new System.Drawing.Size(75, 23);
            this.Unite2Btn.TabIndex = 22;
            this.Unite2Btn.Text = "Unite";
            this.Unite2Btn.UseVisualStyleBackColor = true;
            // 
            // PushTextBox2
            // 
            this.PushTextBox2.Location = new System.Drawing.Point(524, 42);
            this.PushTextBox2.Name = "PushTextBox2";
            this.PushTextBox2.Size = new System.Drawing.Size(58, 20);
            this.PushTextBox2.TabIndex = 21;
            // 
            // Peek2Btn
            // 
            this.Peek2Btn.Location = new System.Drawing.Point(443, 98);
            this.Peek2Btn.Name = "Peek2Btn";
            this.Peek2Btn.Size = new System.Drawing.Size(75, 23);
            this.Peek2Btn.TabIndex = 20;
            this.Peek2Btn.Text = "Peek";
            this.Peek2Btn.UseVisualStyleBackColor = true;
            // 
            // Pop2Btn
            // 
            this.Pop2Btn.Location = new System.Drawing.Point(443, 69);
            this.Pop2Btn.Name = "Pop2Btn";
            this.Pop2Btn.Size = new System.Drawing.Size(75, 23);
            this.Pop2Btn.TabIndex = 19;
            this.Pop2Btn.Text = "Pop";
            this.Pop2Btn.UseVisualStyleBackColor = true;
            // 
            // Push2Btn
            // 
            this.Push2Btn.Location = new System.Drawing.Point(443, 40);
            this.Push2Btn.Name = "Push2Btn";
            this.Push2Btn.Size = new System.Drawing.Size(75, 23);
            this.Push2Btn.TabIndex = 18;
            this.Push2Btn.Text = "Push";
            this.Push2Btn.UseVisualStyleBackColor = true;
            this.Push2Btn.Click += new System.EventHandler(this.Push2Btn_Click);
            // 
            // Copy1Btn
            // 
            this.Copy1Btn.Location = new System.Drawing.Point(282, 187);
            this.Copy1Btn.Name = "Copy1Btn";
            this.Copy1Btn.Size = new System.Drawing.Size(75, 23);
            this.Copy1Btn.TabIndex = 25;
            this.Copy1Btn.Text = "Copy";
            this.Copy1Btn.UseVisualStyleBackColor = true;
            this.Copy1Btn.Click += new System.EventHandler(this.Copy1Btn_Click);
            // 
            // Copy2Btn
            // 
            this.Copy2Btn.Location = new System.Drawing.Point(443, 185);
            this.Copy2Btn.Name = "Copy2Btn";
            this.Copy2Btn.Size = new System.Drawing.Size(75, 23);
            this.Copy2Btn.TabIndex = 26;
            this.Copy2Btn.Text = "Copy";
            this.Copy2Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Push1Btn;
        private System.Windows.Forms.Button Pop1Btn;
        private System.Windows.Forms.Button Peek1Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
    }
}

