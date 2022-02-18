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

namespace Practica
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();           
        }

        private void treeView1_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Equals("09-121"))
            {
                dataGridView1.Rows.Clear();
                foreach (var line in File.ReadLines("121.txt"))
                {
                    var array = line.Split();
                    dataGridView1.Rows.Add(array);
                }
            }
            if (e.Node.Text.Equals("09-122"))
            {
                dataGridView1.Rows.Clear();
                foreach (var line in File.ReadLines("122.txt"))
                {
                    var array = line.Split();
                    dataGridView1.Rows.Add(array);
                }
            }
        }
      
            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 web = new Form2();
            web.Show();
        }

        private void webBrowser1_DocumentCompleted_2(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            
        }
    }
}
