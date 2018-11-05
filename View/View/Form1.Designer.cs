namespace View
{
    partial class BaseForm
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
            this.AddContact = new System.Windows.Forms.Button();
            this.DeleteContact = new System.Windows.Forms.Button();
            this.ChangeContact = new System.Windows.Forms.Button();
            this.ListOfContacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddContact
            // 
            this.AddContact.Location = new System.Drawing.Point(62, 94);
            this.AddContact.Name = "AddContact";
            this.AddContact.Size = new System.Drawing.Size(75, 23);
            this.AddContact.TabIndex = 0;
            this.AddContact.Text = "Добавить";
            this.AddContact.UseVisualStyleBackColor = true;
            this.AddContact.Click += new System.EventHandler(this.AddContact_Click);
            // 
            // DeleteContact
            // 
            this.DeleteContact.Enabled = false;
            this.DeleteContact.Location = new System.Drawing.Point(62, 152);
            this.DeleteContact.Name = "DeleteContact";
            this.DeleteContact.Size = new System.Drawing.Size(75, 23);
            this.DeleteContact.TabIndex = 1;
            this.DeleteContact.Text = "Удалить";
            this.DeleteContact.UseVisualStyleBackColor = true;
            // 
            // ChangeContact
            // 
            this.ChangeContact.Enabled = false;
            this.ChangeContact.Location = new System.Drawing.Point(62, 123);
            this.ChangeContact.Name = "ChangeContact";
            this.ChangeContact.Size = new System.Drawing.Size(75, 23);
            this.ChangeContact.TabIndex = 2;
            this.ChangeContact.Text = "Изменить";
            this.ChangeContact.UseVisualStyleBackColor = true;
            // 
            // ListOfContacts
            // 
            this.ListOfContacts.FormattingEnabled = true;
            this.ListOfContacts.Location = new System.Drawing.Point(185, 34);
            this.ListOfContacts.Name = "ListOfContacts";
            this.ListOfContacts.Size = new System.Drawing.Size(182, 264);
            this.ListOfContacts.TabIndex = 3;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 404);
            this.Controls.Add(this.ListOfContacts);
            this.Controls.Add(this.ChangeContact);
            this.Controls.Add(this.DeleteContact);
            this.Controls.Add(this.AddContact);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddContact;
        private System.Windows.Forms.Button DeleteContact;
        private System.Windows.Forms.Button ChangeContact;
        private System.Windows.Forms.ListBox ListOfContacts;
    }
}

