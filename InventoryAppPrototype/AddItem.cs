using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAppPrototype
{
    public partial class AddItem : UserControl
    {
        //Parent Object.
        private InventoryApp app;

        private bool onPage;

        public AddItem(InventoryApp app)
        {
            InitializeComponent();

            lvProperties.View = View.Details;
            lvProperties.FullRowSelect = true;

            //Set the Inventory App to your Parent Object.
            this.app = app;
        }

        public void setPage(bool onPage)
        {
            this.onPage = onPage;
        }

        private void rtn_btn_Click(object sender, EventArgs e)
        {
            this.app.showMainPage(0);
            lvProperties.Items.Clear();
            setPage(false);
            input_item.Text = "";
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            subAddEntry();
            this.app.showMainPage(0);
            lvProperties.Items.Clear();
            setPage(false);
            input_item.Text = "";
        }

        private void subAddEntry()
        {
            string columns = "";
            string items = "";

            for (int i = 0; i < lvProperties.Items.Count; i++)
            {
                if (i == 0)
                {
                    columns += lvProperties.Items[0].SubItems[0].Text;
                    items += "\"" + lvProperties.Items[0].SubItems[1].Text + "\"";
                }
                else
                {
                    columns += "," + lvProperties.Items[i].SubItems[0].Text;
                    items += "," + "\"" + lvProperties.Items[i].SubItems[1].Text + "\"";
                }
            }
            app.addItem(columns,items);
        }

        public void createInput(string item)
        {
            var listItem = new ListViewItem(item);
            listItem.SubItems.Add("");
            lvProperties.Items.Add(listItem);
        }

        private void input_item_TextChanged(object sender, EventArgs e)
        {
            if (onPage)
            {
                try
                {
                    lvProperties.SelectedItems[0].SubItems[1].Text = input_item.Text;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    lvProperties.Items[0].SubItems[1].Text = input_item.Text;
                }
            }
       
        }

        private void lvProperties_MouseClick(object sender, MouseEventArgs e)
        {
            input_item.Text = lvProperties.SelectedItems[0].SubItems[1].Text;
        }
    }
}
