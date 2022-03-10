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
    public partial class FindScreen : UserControl
    {
        //Parent Object.
        private InventoryApp app;
        private ListViewItem listItem; 

        public FindScreen(InventoryApp app)
        {
            InitializeComponent();

            //Set the Inventory App to your Parent Object.
            this.app = app;
        }

        public void clearList()
        {
            //Clear the List View.
            db_list.Clear();
        }

        public void setColumn(string thisColumn)
        {
            //Create and add a new Column.
            var newColumn = db_list.Columns.Add(thisColumn);
            newColumn.Width = 150;
        }

        public void setItem(string thisItem)
        {
            //Create a new Row.
            this.listItem = new ListViewItem(thisItem);
        }

        public void addSubItem(String subItem)
        {
            this.listItem.SubItems.Add(subItem);
        }

        public void createItem()
        {
            //Add the new Row to the List View.
            db_list.Items.Add(listItem);
        } 

        private void rtn_btn_Click(object sender, EventArgs e)
        {
            //Return to the Main Screen Page.
            app.showMainPage(1);
        }

        private void rm_btn_Click(object sender, EventArgs e)
        {
            //Go to the Remove Item Page.
            app.showRemovePage();
        }
    }
}
