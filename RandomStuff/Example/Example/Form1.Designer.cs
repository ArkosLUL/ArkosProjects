namespace Example
{
    partial class FormGraphics
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
            this.buttonDrawRectangle = new System.Windows.Forms.Button();
            this.buttonMoveRectangle = new System.Windows.Forms.Button();
            this.buttonFillRectangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDrawRectangle
            // 
            this.buttonDrawRectangle.Location = new System.Drawing.Point(1078, 24);
            this.buttonDrawRectangle.Name = "buttonDrawRectangle";
            this.buttonDrawRectangle.Size = new System.Drawing.Size(198, 45);
            this.buttonDrawRectangle.TabIndex = 0;
            this.buttonDrawRectangle.Text = "Прямоугольник с контуром";
            this.buttonDrawRectangle.UseVisualStyleBackColor = true;
            this.buttonDrawRectangle.Click += new System.EventHandler(this.buttonDrawRectangle_Click);
            // 
            // buttonMoveRectangle
            // 
            this.buttonMoveRectangle.Location = new System.Drawing.Point(1078, 126);
            this.buttonMoveRectangle.Name = "buttonMoveRectangle";
            this.buttonMoveRectangle.Size = new System.Drawing.Size(198, 45);
            this.buttonMoveRectangle.TabIndex = 2;
            this.buttonMoveRectangle.Text = "Движение прямоугольника";
            this.buttonMoveRectangle.UseVisualStyleBackColor = true;
            this.buttonMoveRectangle.Click += new System.EventHandler(this.buttonMoveRectangle_Click);
            // 
            // buttonFillRectangle
            // 
            this.buttonFillRectangle.Location = new System.Drawing.Point(1078, 75);
            this.buttonFillRectangle.Name = "buttonFillRectangle";
            this.buttonFillRectangle.Size = new System.Drawing.Size(198, 45);
            this.buttonFillRectangle.TabIndex = 3;
            this.buttonFillRectangle.Text = "Прямоугольник с заливкой";
            this.buttonFillRectangle.UseVisualStyleBackColor = true;
            this.buttonFillRectangle.Click += new System.EventHandler(this.buttonFillRectangle_Click);
            // 
            // FormGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 768);
            this.Controls.Add(this.buttonFillRectangle);
            this.Controls.Add(this.buttonMoveRectangle);
            this.Controls.Add(this.buttonDrawRectangle);
            this.Name = "FormGraphics";
            this.Text = "Graphics examples";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawRectangle;
        private System.Windows.Forms.Button buttonMoveRectangle;
        private System.Windows.Forms.Button buttonFillRectangle;
    }
}

