namespace WisejWebApplication3.Views.Employees.Controls
{
    partial class StaffPanel
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exampleOrganization = new Wisej.Web.FlexLayoutPanel();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.tableLayoutPanel3 = new Wisej.Web.TableLayoutPanel();
            this.editBtn = new Wisej.Web.Button();
            this.deleteBtn = new Wisej.Web.Button();
            this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
            this.exampleOrganization.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exampleOrganization
            // 
            this.exampleOrganization.BackColor = System.Drawing.Color.FromName("@control");
            this.exampleOrganization.Controls.Add(this.label1);
            this.exampleOrganization.Controls.Add(this.label2);
            this.exampleOrganization.Controls.Add(this.label3);
            this.exampleOrganization.Controls.Add(this.tableLayoutPanel3);
            this.exampleOrganization.Dock = Wisej.Web.DockStyle.Fill;
            this.exampleOrganization.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.exampleOrganization.Location = new System.Drawing.Point(0, 0);
            this.exampleOrganization.Margin = new Wisej.Web.Padding(0);
            this.exampleOrganization.Name = "exampleOrganization";
            this.exampleOrganization.Padding = new Wisej.Web.Padding(20, 10, 20, 10);
            this.exampleOrganization.Size = new System.Drawing.Size(298, 218);
            this.exampleOrganization.Spacing = 0;
            this.exampleOrganization.TabIndex = 1;
            this.exampleOrganization.VerticalAlign = Wisej.Web.VerticalAlignment.Middle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("windowTitle", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.editBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.deleteBtn, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 138);
            this.tableLayoutPanel3.Margin = new Wisej.Web.Padding(3, 18, 3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = Wisej.Web.RightToLeft.No;
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(252, 30);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // editBtn
            // 
            this.editBtn.AutoSize = true;
            this.editBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.editBtn.Dock = Wisej.Web.DockStyle.Fill;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.editBtn.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.editBtn.Location = new System.Drawing.Point(3, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new Wisej.Web.Padding(12, 0, 12, 0);
            this.editBtn.Size = new System.Drawing.Size(120, 24);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Dock = Wisej.Web.DockStyle.Fill;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.deleteBtn.Location = new System.Drawing.Point(129, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new Wisej.Web.Padding(12, 0, 12, 0);
            this.deleteBtn.Size = new System.Drawing.Size(120, 24);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // flexLayoutPanel2
            // 
            this.flexLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flexLayoutPanel2.Name = "flexLayoutPanel2";
            this.flexLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flexLayoutPanel2.TabIndex = 0;
            // 
            // StaffPanel
            // 
            this.ClientSize = new System.Drawing.Size(298, 218);
            this.Controls.Add(this.exampleOrganization);
            this.Name = "StaffPanel";
            this.exampleOrganization.ResumeLayout(false);
            this.exampleOrganization.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.FlexLayoutPanel exampleOrganization;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Button deleteBtn;
        private Wisej.Web.FlexLayoutPanel flexLayoutPanel2;
        private Wisej.Web.Button editBtn;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel3;

    }
}