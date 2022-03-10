namespace InventoryAppPrototype
{
    partial class EditItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sub_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.input_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtn_btn = new System.Windows.Forms.Button();
            this.lvProperties = new System.Windows.Forms.ListView();
            this.PropertyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PropertyValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(598, 354);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(190, 80);
            this.sub_btn.TabIndex = 9;
            this.sub_btn.Text = "Submit";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(43, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name";
            // 
            // input_item
            // 
            this.input_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_item.Location = new System.Drawing.Point(462, 289);
            this.input_item.Name = "input_item";
            this.input_item.Size = new System.Drawing.Size(275, 26);
            this.input_item.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit this Item in the Database";
            // 
            // rtn_btn
            // 
            this.rtn_btn.Location = new System.Drawing.Point(12, 354);
            this.rtn_btn.Name = "rtn_btn";
            this.rtn_btn.Size = new System.Drawing.Size(190, 80);
            this.rtn_btn.TabIndex = 5;
            this.rtn_btn.Text = "Return";
            this.rtn_btn.UseVisualStyleBackColor = true;
            // 
            // lvProperties
            // 
            this.lvProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PropertyName,
            this.PropertyValue});
            this.lvProperties.HideSelection = false;
            this.lvProperties.Location = new System.Drawing.Point(33, 41);
            this.lvProperties.Name = "lvProperties";
            this.lvProperties.Size = new System.Drawing.Size(704, 242);
            this.lvProperties.TabIndex = 10;
            this.lvProperties.UseCompatibleStateImageBehavior = false;
            this.lvProperties.View = System.Windows.Forms.View.Details;
            // 
            // PropertyName
            // 
            this.PropertyName.Text = "Property Name";
            this.PropertyName.Width = 150;
            // 
            // PropertyValue
            // 
            this.PropertyValue.Text = "Property Value";
            this.PropertyValue.Width = 318;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvProperties);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtn_btn);
            this.Name = "EditItem";
            this.Size = new System.Drawing.Size(801, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rtn_btn;
        private System.Windows.Forms.ListView lvProperties;
        private System.Windows.Forms.ColumnHeader PropertyName;
        private System.Windows.Forms.ColumnHeader PropertyValue;
    }
}
