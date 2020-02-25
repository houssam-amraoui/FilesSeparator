
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
        string distination = "";

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb1.Text != "") { 
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    diir = folderBrowserDialog1.SelectedPath;
                    distination = diir + "1";

                    DirectoryInfo dir = new DirectoryInfo(diir);

                    FileInfo[] fichiers = dir.GetFiles("*." + tb1.Text, SearchOption.AllDirectories);

                    foreach (FileInfo fichier in fichiers)
                    {
                        listBox1.Items.Add(fichier.FullName);
                    }
                    btnsave.Enabled = true;
                }
            }
            else
                MessageBox.Show("le textbox est empty");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
            DirectoryInfo dir = new DirectoryInfo(diir);
            FileInfo[] fichiers = dir.GetFiles("*." + tb1.Text, SearchOption.AllDirectories);
            foreach (FileInfo fichier in fichiers)
            {
                Directory.CreateDirectory(fichier.Directory.ToString().Replace(diir, distination));
                File.Copy(fichier.FullName, fichier.FullName.Replace(diir, distination));
            }
            }
            catch(Exception ex) { 
            MessageBox.Show(ex.Message+"\n Supprimer le et réessayer");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }   
    }
}
