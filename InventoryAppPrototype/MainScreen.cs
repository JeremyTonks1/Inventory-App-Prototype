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
    public partial class MainScreen : UserControl
    {
        //Parent Object.
        private InventoryApp app;

        public MainScreen(InventoryApp app)
        {
            InitializeComponent();
            
            //Set the Inventory App to your Parent Object.
            this.app = app;
        }

        public void testConnection()
        {
            app.createDB();

            if (app.getState())
            {
                add_btn.Enabled = true;
                edt_btn.Enabled = true;
                find_btn.Enabled = true;

                //Display the MySQL connection is running.
                con_lb.Text = "Database is connected.";
            }
            else
            {
                add_btn.Enabled = false;
                edt_btn.Enabled = false;
                find_btn.Enabled = false;
                //Display the MySQL connection is not running.
                con_lb.Text = "Database is disconnected.";
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            app.dbSet(0);
            //Go to the Add Item Page.
            app.showAddPage();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            //Go to the Find Screen Page.
            app.showFindPage(0);
        }

        private void edt_btn_Click(object sender, EventArgs e)
        {
            app.dbSet(1);
            app.showEditScreenPage();
        }

        private void rsh_btn_Click(object sender, EventArgs e)
        {
            testConnection();
        }
    }
}
