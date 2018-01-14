using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektC_sharp
{
    public partial class Dodaj : UserControl
    {
        private ListView hLvw;
        public Dodaj(ListView lvw)
        {
            InitializeComponent();
            hLvw = lvw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(textBox1.Text);
            item.SubItems.Add(textBox1.Text);
            item.SubItems.Add(textBox1.Text);
            item.SubItems.Add(textBox1.Text);
            item.SubItems.Add(textBox1.Text);
            item.SubItems.Add(textBox1.Text);
            hLvw.Items.Add(item);
            this.Visible = false;
        }
    }
}
