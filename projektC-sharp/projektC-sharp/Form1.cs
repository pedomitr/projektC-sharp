using System;
using System.Collections;
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
            this.listView1.ListViewItemSorter = new ListViewItemComparer();
            dodaj1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodaj1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = listView1.SelectedItems.Count;
            if (count == 0) return;
            for(int i = 0; i < count; ++i)
            {
                listView1.SelectedItems[0].Remove();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewItemComparer comparer = (ListViewItemComparer)listView1.ListViewItemSorter;
            if (e.Column == comparer.Column && comparer.Order == SortOrder.Ascending)
            {
                comparer.Order = SortOrder.Descending;
            }
            else
            {
                comparer.Order = SortOrder.Ascending;
            }

            comparer.Column = e.Column;
            listView1.Sort();
        }
    }

    class ListViewItemComparer : IComparer
    {
        public SortOrder Order = SortOrder.Ascending;
        public int Column;
        public ListViewItemComparer()
        {
            Column = 0;
        }
        public ListViewItemComparer(int column)
        {           
            Column = column;
        }


        public int Compare(object x, object y)
        {
            int returnVal = 0;
            returnVal = String.Compare(((ListViewItem)x).SubItems[Column].Text,
                        ((ListViewItem)y).SubItems[Column].Text);
            if (Order == SortOrder.Descending)
                return -returnVal;
            else
                return returnVal;
        }
    }     
}
