using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Greater_Click(object sender, EventArgs e)
        {
            this.Result.Text = "";
            this.label.Text = ">";
            try
            {
                if (this.Value1.Text=="" || this.Value1.Text == "")
                {
                    throw new ArgumentNullException();
                }
                if (this.Value1.Text.Length > this.Value2.Text.Length)
                {
                    this.Result.Text = "true";
                }
                else
                {
                    
                    this.Result.Text = "false";
                }
            }
            catch (ArgumentNullException)
            {
                this.Value1.Text = "";
                this.Value2.Text = "";
                this.label.Text = "Try again";
                this.Result.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Result.Text = "";
            this.label.Text = "<<";
            try
            {
                if (this.Value1.Text == "")
                {
                    throw new ArgumentNullException();
                }
                string value = this.Value1.Text;
                string lastText;
                for (int i = 1; i < value.Length; i++)
                {
                    lastText = this.Result.Text;
                    this.Result.Text = lastText + value[i];
                }
                lastText = this.Result.Text;
                this.Result.Text = lastText + value[0];
            }
            catch (ArgumentNullException)
            {
                this.Value1.Text = "";
                this.Value2.Text = "";
                this.label.Text = "Try again";
                this.Result.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Result.Text = "";
            this.label.Text = "!=";
            try
            {
                if (this.Value1.Text == "" || this.Value2.Text == "")
                {
                    throw new ArgumentNullException();
                }
                if (!(this.Value1.Text.Equals(this.Value2.Text)))
                {
                    this.Result.Text = "true";
                }
                else
                {

                    this.Result.Text = "false";
                }
            }
            catch (ArgumentNullException)
            {
                this.Value1.Text = "";
                this.Value2.Text = "";
                this.label.Text = "Try again";
                this.Result.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Result.Text = "";
            this.label.Text = "==";
            try
            {
                if (this.Value1.Text == "" || this.Value2.Text == "")
                {
                    throw new ArgumentNullException();
                }
                if (this.Value1.Text.Equals(this.Value2.Text))
                {
                    this.Result.Text = "true";
                }
                else
                {

                    this.Result.Text = "false";
                }
            }
            catch (ArgumentNullException)
            {
                this.Value1.Text = "";
                this.Value2.Text = "";
                this.label.Text = "Try again";
                this.Result.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Result.Text = "";
            this.label.Text = "<<";
            try
            {
                if (this.Value1.Text == "")
                {
                    throw new ArgumentNullException();
                }
                string value = this.Value1.Text;
                string lastText;
                for (int i = 0; i < value.Length-1; i++)
                {
                    lastText = this.Result.Text;
                    this.Result.Text = lastText + value[i];
                }
                lastText = this.Result.Text;
                this.Result.Text = value.Last() + lastText;
            }
            catch (ArgumentNullException)
            {
                this.Value1.Text = "";
                this.Value2.Text = "";
                this.label.Text = "Try again";
                this.Result.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Result.Text = "";
            this.label.Text = "<";
            try
            {
                if (this.Value1.Text == "" || this.Value2.Text == "")
                {
                    throw new ArgumentNullException();
                }
                if (this.Value1.Text.Length < this.Value2.Text.Length)
                {
                    this.Result.Text = "true";
                }
                else
                {
                    this.Result.Text = "false";
                }
            }
            catch (ArgumentNullException)
            {
                this.Value1.Text = "";
                this.Value2.Text = "";
                this.label.Text = "Try again";
                this.Result.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
