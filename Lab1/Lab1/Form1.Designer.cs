namespace Lab1
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
            this.Greater = new System.Windows.Forms.Button();
            this.Less = new System.Windows.Forms.Button();
            this.UnEqual = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.MoveToRight = new System.Windows.Forms.Button();
            this.MoveToLeft = new System.Windows.Forms.Button();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Greater
            // 
            this.Greater.Location = new System.Drawing.Point(145, 120);
            this.Greater.Name = "Greater";
            this.Greater.Size = new System.Drawing.Size(75, 23);
            this.Greater.TabIndex = 0;
            this.Greater.Text = ">";
            this.Greater.UseVisualStyleBackColor = true;
            this.Greater.Click += new System.EventHandler(this.Greater_Click);
            // 
            // Less
            // 
            this.Less.Location = new System.Drawing.Point(64, 120);
            this.Less.Name = "Less";
            this.Less.Size = new System.Drawing.Size(75, 23);
            this.Less.TabIndex = 1;
            this.Less.Text = "<";
            this.Less.UseVisualStyleBackColor = true;
            this.Less.Click += new System.EventHandler(this.button2_Click);
            // 
            // UnEqual
            // 
            this.UnEqual.Location = new System.Drawing.Point(145, 149);
            this.UnEqual.Name = "UnEqual";
            this.UnEqual.Size = new System.Drawing.Size(75, 23);
            this.UnEqual.TabIndex = 3;
            this.UnEqual.Text = "!=";
            this.UnEqual.UseVisualStyleBackColor = true;
            this.UnEqual.Click += new System.EventHandler(this.button3_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(64, 149);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(75, 23);
            this.Equal.TabIndex = 2;
            this.Equal.Text = "==";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.button4_Click);
            // 
            // MoveToRight
            // 
            this.MoveToRight.Location = new System.Drawing.Point(145, 178);
            this.MoveToRight.Name = "MoveToRight";
            this.MoveToRight.Size = new System.Drawing.Size(75, 23);
            this.MoveToRight.TabIndex = 5;
            this.MoveToRight.Text = ">>";
            this.MoveToRight.UseVisualStyleBackColor = true;
            this.MoveToRight.Click += new System.EventHandler(this.button5_Click);
            // 
            // MoveToLeft
            // 
            this.MoveToLeft.Location = new System.Drawing.Point(64, 178);
            this.MoveToLeft.Name = "MoveToLeft";
            this.MoveToLeft.Size = new System.Drawing.Size(75, 23);
            this.MoveToLeft.TabIndex = 4;
            this.MoveToLeft.Text = "<<";
            this.MoveToLeft.UseVisualStyleBackColor = true;
            this.MoveToLeft.Click += new System.EventHandler(this.button6_Click);
            // 
            // Value1
            // 
            this.Value1.Location = new System.Drawing.Point(12, 12);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(100, 20);
            this.Value1.TabIndex = 7;
            this.Value1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(12, 75);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(100, 20);
            this.Value2.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(16, 13);
            this.label.TabIndex = 9;
            this.label.Text = "...";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(145, 42);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.MoveToRight);
            this.Controls.Add(this.MoveToLeft);
            this.Controls.Add(this.UnEqual);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Less);
            this.Controls.Add(this.Greater);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Greater;
        private System.Windows.Forms.Button Less;
        private System.Windows.Forms.Button UnEqual;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button MoveToRight;
        private System.Windows.Forms.Button MoveToLeft;
        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox Result;
    }
}

