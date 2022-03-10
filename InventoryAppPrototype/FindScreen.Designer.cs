namespace InventoryAppPrototype
{
    partial class FindScreen
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
            this.db_list = new System.Windows.Forms.ListView();
            this.rtn_btn = new System.Windows.Forms.Button();
            this.rm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // db_list
            // 
            this.db_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.db_list.HideSelection = false;
            this.db_list.Location = new System.Drawing.Point(13, 13);
            this.db_list.Name = "db_list";
            this.db_list.Size = new System.Drawing.Size(776, 343);
            this.db_list.TabIndex = 0;
            this.db_list.UseCompatibleStateImageBehavior = false;
            this.db_list.View = System.Windows.Forms.View.Details;
            // 
            // rtn_btn
            // 
            this.rtn_btn.Location = new System.Drawing.Point(13, 362);
            this.rtn_btn.Name = "rtn_btn";
            this.rtn_btn.Size = new System.Drawing.Size(190, 80);
            this.rtn_btn.TabIndex = 1;
            this.rtn_btn.Text = "Return";
            this.rtn_btn.UseVisualStyleBackColor = true;
            this.rtn_btn.Click += new System.EventHandler(this.rtn_btn_Click);
            // 
            // rm_btn
            // 
            this.rm_btn.Location = new System.Drawing.Point(599, 362);
            this.rm_btn.Name = "rm_btn";
            this.rm_btn.Size = new System.Drawing.Size(190, 80);
            this.rm_btn.TabIndex = 2;
            this.rm_btn.Text = "Remove";
            this.rm_btn.UseVisualStyleBackColor = true;
            this.rm_btn.Click += new System.EventHandler(this.rm_btn_Click);
            // 
            // FindScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rm_btn);
            this.Controls.Add(this.rtn_btn);
            this.Controls.Add(this.db_list);
            this.Name = "FindScreen";
            this.Size = new System.Drawing.Size(801, 452);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView db_list;
        private System.Windows.Forms.Button rtn_btn;
        private System.Windows.Forms.Button rm_btn;
    }
}
