namespace Lab1._2
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
            this.studentsLabel = new System.Windows.Forms.Label();
            this.numberOfStuents = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.collectionBox = new System.Windows.Forms.RichTextBox();
            this.minSort = new System.Windows.Forms.Button();
            this.maxSort = new System.Windows.Forms.Button();
            this.linqBox = new System.Windows.Forms.RichTextBox();
            this.query1 = new System.Windows.Forms.Button();
            this.query2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Location = new System.Drawing.Point(13, 13);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(102, 13);
            this.studentsLabel.TabIndex = 0;
            this.studentsLabel.Text = "Number of students:";
            // 
            // numberOfStuents
            // 
            this.numberOfStuents.Location = new System.Drawing.Point(121, 10);
            this.numberOfStuents.Name = "numberOfStuents";
            this.numberOfStuents.Size = new System.Drawing.Size(22, 20);
            this.numberOfStuents.TabIndex = 1;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(158, 7);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 2;
            this.generate.Text = "Show Marks";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // collectionBox
            // 
            this.collectionBox.Location = new System.Drawing.Point(12, 46);
            this.collectionBox.Name = "collectionBox";
            this.collectionBox.Size = new System.Drawing.Size(221, 221);
            this.collectionBox.TabIndex = 4;
            this.collectionBox.Text = "";
            this.collectionBox.TextChanged += new System.EventHandler(this.collectionBox_TextChanged);
            // 
            // minSort
            // 
            this.minSort.Location = new System.Drawing.Point(12, 284);
            this.minSort.Name = "minSort";
            this.minSort.Size = new System.Drawing.Size(75, 23);
            this.minSort.TabIndex = 5;
            this.minSort.Text = "Sort-";
            this.minSort.UseVisualStyleBackColor = true;
            this.minSort.Click += new System.EventHandler(this.minSort_Click);
            // 
            // maxSort
            // 
            this.maxSort.Location = new System.Drawing.Point(158, 284);
            this.maxSort.Name = "maxSort";
            this.maxSort.Size = new System.Drawing.Size(75, 23);
            this.maxSort.TabIndex = 6;
            this.maxSort.Text = "Sort+";
            this.maxSort.UseVisualStyleBackColor = true;
            this.maxSort.Click += new System.EventHandler(this.maxSort_Click);
            // 
            // linqBox
            // 
            this.linqBox.Location = new System.Drawing.Point(239, 46);
            this.linqBox.Name = "linqBox";
            this.linqBox.Size = new System.Drawing.Size(221, 221);
            this.linqBox.TabIndex = 7;
            this.linqBox.Text = "";
            // 
            // query1
            // 
            this.query1.AutoSize = true;
            this.query1.Location = new System.Drawing.Point(274, 13);
            this.query1.Name = "query1";
            this.query1.Size = new System.Drawing.Size(75, 23);
            this.query1.TabIndex = 8;
            this.query1.Text = "Query1";
            this.query1.UseVisualStyleBackColor = true;
            this.query1.Click += new System.EventHandler(this.query1_Click);
            // 
            // query2
            // 
            this.query2.AutoSize = true;
            this.query2.Location = new System.Drawing.Point(365, 13);
            this.query2.Name = "query2";
            this.query2.Size = new System.Drawing.Size(75, 23);
            this.query2.TabIndex = 9;
            this.query2.Text = "Query2";
            this.query2.UseVisualStyleBackColor = true;
            this.query2.Click += new System.EventHandler(this.query2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 425);
            this.Controls.Add(this.query2);
            this.Controls.Add(this.query1);
            this.Controls.Add(this.linqBox);
            this.Controls.Add(this.maxSort);
            this.Controls.Add(this.minSort);
            this.Controls.Add(this.collectionBox);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.numberOfStuents);
            this.Controls.Add(this.studentsLabel);
            this.Name = "Form1";
            this.Text = "OOP 2-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.TextBox numberOfStuents;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.RichTextBox collectionBox;
        private System.Windows.Forms.Button minSort;
        private System.Windows.Forms.Button maxSort;
        private System.Windows.Forms.RichTextBox linqBox;
        private System.Windows.Forms.Button query1;
        private System.Windows.Forms.Button query2;
    }
}

