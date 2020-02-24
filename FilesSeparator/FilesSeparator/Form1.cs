
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] fichiers = dir.GetFiles();

                string s = "";

                foreach (FileInfo fichier in fichiers)
                {
                    listBox1.Items.Add(fichier.FullName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
             Random r = new Random();
             string pathString = textBox3.Text+dir.Name + r.Next();
             string filename = textBox1.Text +"\\"+listBox1.SelectedItem;
             string desfile =pathString+"\\"+ listBox1.SelectedItem;
            Directory.CreateDirectory(pathString);
             File.Copy(filename, desfile);*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /* public static List<DirectoryInfo> getAllFilesFromDerectory(DirectoryInfo parent)
             {
                 List<DirectoryInfo> directories = new List<DirectoryInfo>();
                 List<DirectoryInfo> files = new List<DirectoryInfo>();
                 //adding initial parent whose files we want to fetch
                 directories.Add(parent);
                 while (directories.Count != 0)
                 {
                 FileInfo f = directories[0];
                 directories.RemoveAt(0);
                     if (f.isDirectory())
                     {
                         if (f.list().length > 0)
                         {
                             List<FileInfo> directoryList = Arrays.asList(f.);
                             List<FileInfo> fileList = Arrays.asList(f.listFiles(fileFilter));
                             directories.AddRange(directoryList);
                             files.AddRange(fileList);z
                         }
                     }
                 }
                 return files;
             }


         public static List<FileInfo> filterr(List<FileInfo> ss, String type)
         {
             List<FileInfo> fff = new List<FileInfo>();
             foreach (FileInfo file in ss)
             {
                 if (file.getPath().endsWith(type))
                     fff.Add(file);
             }
             return fff;
         }*/
    }
}
