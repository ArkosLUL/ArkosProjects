namespace View
{
    partial class PhoneBookView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.labelSkype = new System.Windows.Forms.Label();
            this.SkypeTextBox = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ContactIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactIDColumn,
            this.NameColumn,
            this.LastNameColumn,
            this.PhoneNumberColumn,
            this.SkypeColumn,
            this.EmailColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 205);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(820, 239);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPhoneNumber);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Controls.Add(this.LastNameTextBox);
            this.panel1.Controls.Add(this.labelSkype);
            this.panel1.Controls.Add(this.SkypeTextBox);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.PhoneNumberTextBox);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 136);
            this.panel1.TabIndex = 1;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(7, 58);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(52, 13);
            this.labelPhoneNumber.TabIndex = 10;
            this.labelPhoneNumber.Text = "Телефон";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(69, 107);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(194, 20);
            this.EmailTextBox.TabIndex = 9;
            this.EmailTextBox.Text = "Введите e-mail";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(7, 32);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Фамилия";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(69, 29);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.LastNameTextBox.TabIndex = 7;
            this.LastNameTextBox.Text = "Введите номер фамилию";
            // 
            // labelSkype
            // 
            this.labelSkype.AutoSize = true;
            this.labelSkype.Location = new System.Drawing.Point(7, 84);
            this.labelSkype.Name = "labelSkype";
            this.labelSkype.Size = new System.Drawing.Size(37, 13);
            this.labelSkype.TabIndex = 6;
            this.labelSkype.Text = "Skype";
            // 
            // SkypeTextBox
            // 
            this.SkypeTextBox.Location = new System.Drawing.Point(69, 81);
            this.SkypeTextBox.Name = "SkypeTextBox";
            this.SkypeTextBox.Size = new System.Drawing.Size(194, 20);
            this.SkypeTextBox.TabIndex = 5;
            this.SkypeTextBox.Text = "Введите скайп";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(7, 110);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "E-mail";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(69, 55);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(194, 20);
            this.PhoneNumberTextBox.TabIndex = 3;
            this.PhoneNumberTextBox.Text = "Введите номер телефона\r\n";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(69, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(194, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.Text = "Введите имя";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(92, 165);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(350, 20);
            this.SearchTextBox.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(11, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(511, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(592, 455);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(673, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(754, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ContactIDColumn
            // 
            this.ContactIDColumn.HeaderText = "ID";
            this.ContactIDColumn.Name = "ContactIDColumn";
            this.ContactIDColumn.ReadOnly = true;
            this.ContactIDColumn.Width = 25;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 150;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.HeaderText = "Фамилия";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            this.LastNameColumn.Width = 150;
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.HeaderText = "Телефон";
            this.PhoneNumberColumn.Name = "PhoneNumberColumn";
            this.PhoneNumberColumn.ReadOnly = true;
            this.PhoneNumberColumn.Width = 150;
            // 
            // SkypeColumn
            // 
            this.SkypeColumn.HeaderText = "Skype";
            this.SkypeColumn.Name = "SkypeColumn";
            this.SkypeColumn.ReadOnly = true;
            this.SkypeColumn.Width = 150;
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "E-mail";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            this.EmailColumn.Width = 150;
            // 
            // PhoneBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 490);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Name = "PhoneBookView";
            this.Text = "Phone book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSkype;
        private System.Windows.Forms.TextBox SkypeTextBox;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
    }
}

