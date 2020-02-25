
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
using System.Threading;

namespace FilesSeparator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string diir = "";

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                diir = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(diir);
                FileInfo[] fichiers = dir.GetFiles("*.txt", SearchOption.AllDirectories);

                string s = "";

                foreach (FileInfo fichier in fichiers)
                {
                    listBox1.Items.Add(fichier.FullName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(diir);
             DirectoryInfo dir = new DirectoryInfo(diir);
             Random r = new Random();
          /*   string pathString = textBox3.Text+dir.Name + r.Next();
             Directory.CreateDirectory(pathString);
             File.Copy(filename, desfile);*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


         
    }
}
