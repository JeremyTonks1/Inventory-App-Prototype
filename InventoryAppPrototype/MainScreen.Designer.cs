namespace InventoryAppPrototype
{
    partial class MainScreen
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
            this.add_btn = new System.Windows.Forms.Button();
            this.edt_btn = new System.Windows.Forms.Button();
            this.find_btn = new System.Windows.Forms.Button();
            this.con_lb = new System.Windows.Forms.Label();
            this.rsh_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(15, 49);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(204, 74);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add Item";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edt_btn
            // 
            this.edt_btn.Location = new System.Drawing.Point(15, 129);
            this.edt_btn.Name = "edt_btn";
            this.edt_btn.Size = new System.Drawing.Size(204, 74);
            this.edt_btn.TabIndex = 1;
            this.edt_btn.Text = "Edit Item";
            this.edt_btn.UseVisualStyleBackColor = true;
            this.edt_btn.Click += new System.EventHandler(this.edt_btn_Click);
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(15, 209);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(204, 74);
            this.find_btn.TabIndex = 2;
            this.find_btn.Text = "Find Item";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // con_lb
            // 
            this.con_lb.AutoSize = true;
            this.con_lb.Location = new System.Drawing.Point(12, 16);
            this.con_lb.Name = "con_lb";
            this.con_lb.Size = new System.Drawing.Size(0, 17);
            this.con_lb.TabIndex = 3;
            // 
            // rsh_btn
            // 
            this.rsh_btn.Location = new System.Drawing.Point(15, 362);
            this.rsh_btn.Name = "rsh_btn";
            this.rsh_btn.Size = new System.Drawing.Size(204, 74);
            this.rsh_btn.TabIndex = 4;
            this.rsh_btn.Text = "Refresh Connection";
            this.rsh_btn.UseVisualStyleBackColor = true;
            this.rsh_btn.Click += new System.EventHandler(this.rsh_btn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rsh_btn);
            this.Controls.Add(this.con_lb);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.edt_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(801, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edt_btn;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Label con_lb;
        private System.Windows.Forms.Button rsh_btn;
    }
}
