using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._2
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        public bool trigerSort;
        Random marksGenerator = new Random();
        int mark;
        public delegate int Comparator<in T>(T x, T y);
        Comparator<int> sortbyu = delegate (int x, int y)
        {
            if (x > y) return -1;
            else if (y > x) return 1;
            else return 0;
        };
        Comparator<int> sortbyv = delegate (int x, int y)
        {
            if (x < y) return -1;
            else if (y < x) return 1;
            else return 0;
        };
        public List<int> sortby(List<int> t, Comparator<int> u)
        {
            int temp;
            for (int j = 0; j < t.Count; j++)
            {
                for (int i = 0; i < t.Count - 1; i++)
                {
                    if (u(t[i], t[i + 1]) > 0)
                    {
                        temp = t[i];
                        t[i] = t[i + 1];
                        t[i + 1] = temp;
                    }
                }
            }
            return t;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.collectionBox.Text = "";
            list.Clear();
            for (int i = 0; i < Convert.ToInt16(this.numberOfStuents.Text); i++)
            {
                mark = marksGenerator.Next(4, 11);
                list.Add(mark);
                this.collectionBox.Text = this.collectionBox.Text + "\n" + (i + 1) + ".Mark: " + mark;
            }
        }

        private void minSort_Click(object sender, EventArgs e)
        {
            linqBox.Clear();
            try
            {
                if (list.Count == 0) throw new Exception();
                sortby(list, sortbyv);

                for (int i = 0; i < list.Count; i++)
                {
                    linqBox.Text = linqBox.Text + "\n" + (i + 1) + ".Mark: " + list[i];
                }
            }
            catch
            {
                MessageBox.Show("Ошибка, сначала сгенериуйте коллекцию!");
            }

        } // сортировка по возрастанию

        private void maxSort_Click(object sender, EventArgs e)
        {
            linqBox.Clear();
            try
            {
                if (list.Count == 0) throw new Exception();
                sortby(list, sortbyu);

                for (int i = 0; i < list.Count; i++)
                {
                    linqBox.Text = linqBox.Text +"\n" + (i + 1) + ".Mark: "  + list[i];
                }
            }
            catch
            {
                MessageBox.Show("Ошибка, сначала сгенериуйте коллекцию!");
            }
        } // сортировка по убыванию

        private void collectionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void query1_Click(object sender, EventArgs e)
        {
            int i = 0;
            this.linqBox.Text = "";            
            IEnumerable<int> aMarks = list.Where(n => n>7).Select(n => n);
            foreach(int mark in aMarks)
            {
                this.linqBox.Text = this.linqBox.Text + "\n" + (i + 1) + ".Mark: " + mark;
                i++;
            }

        }

        private void query2_Click(object sender, EventArgs e)
        {
            int i = 0;
            this.linqBox.Text = "";
            IEnumerable<int> aMarks = list.Where(n => n == 10).Select(n => n);
            foreach (int mark in aMarks)
            {
                this.linqBox.Text = this.linqBox.Text + "\n" + (i + 1) + ".Mark: " + mark;
                i++;
            }
        }

    }
}
