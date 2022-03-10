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
    public partial class EditItem : UserControl
    {
        //Parent Object.
        private InventoryApp app;
        private string currentValue;

        public EditItem(InventoryApp app)
        {
            InitializeComponent();

            //Set the Inventory App to your Parent Object.
            this.app = app;
        }

        public void updateInputs(string item)
        {
            input_item.Text = item;
            this.currentValue = item;
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            app.updateEntry(currentValue, input_item.Text);
            app.showMainPage(3);
        }
    }
}
