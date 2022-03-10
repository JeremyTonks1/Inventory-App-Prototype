namespace InventoryAppPrototype
{
    partial class EditScreen
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
            this.edt_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.input_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edt_btn
            // 
            this.edt_btn.Location = new System.Drawing.Point(598, 354);
            this.edt_btn.Name = "edt_btn";
            this.edt_btn.Size = new System.Drawing.Size(190, 80);
            this.edt_btn.TabIndex = 9;
            this.edt_btn.Text = "Edit";
            this.edt_btn.UseVisualStyleBackColor = true;
            this.edt_btn.Click += new System.EventHandler(this.edt_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(72, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name";
            // 
            // input_item
            // 
            this.input_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_item.Location = new System.Drawing.Point(210, 56);
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
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search for this Item in the Database";
            // 
            // rtn_btn
            // 
            this.rtn_btn.Location = new System.Drawing.Point(12, 354);
            this.rtn_btn.Name = "rtn_btn";
            this.rtn_btn.Size = new System.Drawing.Size(190, 80);
            this.rtn_btn.TabIndex = 5;
            this.rtn_btn.Text = "Return";
            this.rtn_btn.UseVisualStyleBackColor = true;
            this.rtn_btn.Click += new System.EventHandler(this.rtn_btn_Click);
            // 
            // EditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edt_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtn_btn);
            this.Name = "EditScreen";
            this.Size = new System.Drawing.Size(801, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edt_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rtn_btn;
    }
}
