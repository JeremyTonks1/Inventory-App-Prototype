namespace InventoryAppPrototype
{
    partial class AddItem
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
            this.rtn_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_item = new System.Windows.Forms.TextBox();
            this.sub_btn = new System.Windows.Forms.Button();
            this.lvProperties = new System.Windows.Forms.ListView();
            this.PropertyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PropertyValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtn_btn
            // 
            this.rtn_btn.Location = new System.Drawing.Point(13, 362);
            this.rtn_btn.Name = "rtn_btn";
            this.rtn_btn.Size = new System.Drawing.Size(190, 80);
            this.rtn_btn.TabIndex = 0;
            this.rtn_btn.Text = "Return";
            this.rtn_btn.UseVisualStyleBackColor = true;
            this.rtn_btn.Click += new System.EventHandler(this.rtn_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add an Item into the Database";
            // 
            // input_item
            // 
            this.input_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_item.Location = new System.Drawing.Point(116, 309);
            this.input_item.Name = "input_item";
            this.input_item.Size = new System.Drawing.Size(622, 26);
            this.input_item.TabIndex = 2;
            this.input_item.TextChanged += new System.EventHandler(this.input_item_TextChanged);
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(599, 362);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(190, 80);
            this.sub_btn.TabIndex = 4;
            this.sub_btn.Text = "Submit";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // lvProperties
            // 
            this.lvProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PropertyName,
            this.PropertyValue});
            this.lvProperties.HideSelection = false;
            this.lvProperties.Location = new System.Drawing.Point(34, 49);
            this.lvProperties.Name = "lvProperties";
            this.lvProperties.Size = new System.Drawing.Size(704, 242);
            this.lvProperties.TabIndex = 5;
            this.lvProperties.UseCompatibleStateImageBehavior = false;
            this.lvProperties.View = System.Windows.Forms.View.Details;
            this.lvProperties.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvProperties_MouseClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(45, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value:";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvProperties);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtn_btn);
            this.Name = "AddItem";
            this.Size = new System.Drawing.Size(801, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rtn_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_item;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.ListView lvProperties;
        private System.Windows.Forms.ColumnHeader PropertyName;
        private System.Windows.Forms.ColumnHeader PropertyValue;
        private System.Windows.Forms.Label label2;
    }
}
