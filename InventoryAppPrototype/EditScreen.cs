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
    public partial class EditScreen : UserControl
    {
        //Parent Object.
        private InventoryApp app;

        public EditScreen(InventoryApp app)
        {
            InitializeComponent();

            //Set the Inventory App to your Parent Object.
            this.app = app;
        }

        private void rtn_btn_Click(object sender, EventArgs e)
        {
            app.showMainPage(2);
        }

        private void edt_btn_Click(object sender, EventArgs e)
        {
            app.showEditItemPage(app.getEntry(input_item.Text));
        }
    }
}
