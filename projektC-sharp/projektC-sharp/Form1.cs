using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektC_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("Petar");
            item.SubItems.Add("Domitrović");
            item.SubItems.Add("m");
            item.SubItems.Add("25/04/1996");
            item.SubItems.Add("Hrvatska");
            item.SubItems.Add("Zagreb");
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
