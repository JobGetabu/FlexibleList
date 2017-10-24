namespace FlexibleList
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdd = new System.Windows.Forms.Button();
            this.listControl1 = new FlexibleList.ListControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(12, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(114, 24);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add Item";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // listControl1
            // 
            this.listControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listControl1.Location = new System.Drawing.Point(0, 0);
            this.listControl1.Name = "listControl1";
            this.listControl1.Size = new System.Drawing.Size(567, 500);
            this.listControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 38);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listControl1);
            this.Name = "Form1";
            this.Text = "Cool List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListControl listControl1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panel1;
    }
}

