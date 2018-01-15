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
            item.SubItems.Add(textBox2.Text);
            if (checkBox1.Checked == true)
                item.SubItems.Add("m");
            else
                item.SubItems.Add("ž");
            item.SubItems.Add(textBox3.Text + "." + textBox4.Text + "." + textBox5.Text + ".");
            item.SubItems.Add(textBox6.Text);
            item.SubItems.Add(textBox7.Text);
            hLvw.Items.Add(item);
            this.Visible = false;
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                checkBox2.Checked = false;
            else
                checkBox2.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkBox1.Checked = false;
            else
                checkBox1.Checked = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
