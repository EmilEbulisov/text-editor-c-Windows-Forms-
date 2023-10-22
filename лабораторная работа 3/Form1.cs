using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace лабораторная_работа_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                richTextBox1.Clear(); 
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; 
                string fileName = openFileDialog1.FileName; 
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); 
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt"; 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                var name = saveFileDialog1.FileName; 
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251)); 
            }
            richTextBox1.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void слеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void справаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);

        }
    }
}
