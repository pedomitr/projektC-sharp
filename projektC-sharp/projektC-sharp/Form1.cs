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
            int returnVal = String.Compare(((ListViewItem)x).SubItems[Column].Text,
            ((ListViewItem)y).SubItems[Column].Text);

            if (Order == SortOrder.Descending)
                return -returnVal;
            else
                return returnVal;
        }
    }
}
