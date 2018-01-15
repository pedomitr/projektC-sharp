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
            if (Uncompleted() > 0) return;
            ListViewItem item = new ListViewItem(textBox1.Text);
            item.SubItems.Add(textBox2.Text);
            if (checkBox1.Checked == true)
            {
                item.SubItems.Add("m");
            }
            else
            {
             item.SubItems.Add("ž");
            }
            AddZeros(textBox3);
            AddZeros(textBox4);
            item.SubItems.Add(textBox3.Text + "." + textBox4.Text + "." + textBox5.Text + ".");
            item.SubItems.Add(textBox6.Text);
            item.SubItems.Add(textBox7.Text);
            hLvw.Items.Add(item);
            this.Visible = false;               

        }

        private int IsEmpty(TextBox textBox)
        {
            if (String.Compare(textBox.Text, "") != 1)
                return 1;
            return 0;
        }

        private int Uncompleted()
        {
            return IsEmpty(textBox1)
                   + IsEmpty(textBox2)
                   + IsEmpty(textBox3)
                   + IsEmpty(textBox4)
                   + IsEmpty(textBox5)
                   + IsEmpty(textBox6)
                   + IsEmpty(textBox7);           
        }

        private void AddZeros(TextBox textBox)
        {
            if (textBox.Text.Length == 1)
                textBox.Text = "0" + textBox.Text;
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == (int)Keys.Back || c == (int)Keys.Delete)
                return;
            e.KeyChar = '0';
            ((TextBox)sender).Text = "";
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox3_KeyPress(sender, e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox3_KeyPress(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
