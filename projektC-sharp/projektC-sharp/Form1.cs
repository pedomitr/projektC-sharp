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
            if(e.Column == 3)
            {
                DateSort();
                return;
            }
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


        public void DateSort()
        {
            int count = listView1.Items.Count;
            int index = 0;
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < count - 1; ++i)
            {
                item = listView1.Items[i];
                for (int j = i + 1; j < count - 1; ++j)
                {
                    if(DateComparer(item, listView1.Items[j]) > 0)
                    {
                        listView1.BeginUpdate();
                        index = item.Index;
                        listView1.Items.RemoveAt(index);
                        listView1.Items.Insert(j, item);
                        listView1.EndUpdate();
                    }
                }

            }
        }

        public int DateComparer(object x, object y)
        {
            int returnVal = 0;
            returnVal = String.Compare(((ListViewItem)x).SubItems[3].Text.Substring(6, 4),
                         ((ListViewItem)y).SubItems[3].Text.Substring(6, 4));
            if (returnVal <= 0)
            {
                returnVal = String.Compare(((ListViewItem)x).SubItems[3].Text.Substring(3, 2),
                         ((ListViewItem)y).SubItems[3].Text.Substring(3, 2));
            }
            else if (returnVal <= 0)
            {
                returnVal = String.Compare(((ListViewItem)x).SubItems[3].Text.Substring(0, 2),
                             ((ListViewItem)y).SubItems[3].Text.Substring(0, 2));

            }
            return returnVal;
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
