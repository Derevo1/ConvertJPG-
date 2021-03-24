using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
         string filename;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                textBox1.Text = filename;
                for (int i = 0; i < 1; i++)
                {
                    var rand = new Random();
                    int index = rand.Next(10, 100);
                    File.Copy(filename, $"{index}.jpg");
                    pictureBox1.Image = Image.FromFile($"{index}.jpg");
                }
                }

        }
        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string newfile = filename;
             File.Move(newfile, Path.ChangeExtension(newfile, ".tpi"));
            MessageBox.Show("Save to TPI");
        }
    }
}
