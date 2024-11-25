using WisejWebApplication3.Properties;

namespace WisejWebApplication3.Views.Homepage.Controls
{
    partial class OrganizationPanel
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
            this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
            this.deleteBtn = new Wisej.Web.Button();
            this.editBtn = new Wisej.Web.Button();
            this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
            this.exampleOrganization.SuspendLayout();
            this.flexLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exampleOrganization
            // 
            this.exampleOrganization.BackColor = System.Drawing.Color.FromName("@control");
            this.exampleOrganization.Controls.Add(this.label1);
            this.exampleOrganization.Controls.Add(this.label2);
            this.exampleOrganization.Controls.Add(this.label3);
            this.exampleOrganization.Controls.Add(this.flexLayoutPanel1);
            this.exampleOrganization.Dock = Wisej.Web.DockStyle.Fill;
            this.exampleOrganization.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.exampleOrganization.Location = new System.Drawing.Point(0, 0);
            this.exampleOrganization.Margin = new Wisej.Web.Padding(0);
            this.exampleOrganization.Name = "exampleOrganization";
            this.exampleOrganization.Padding = new Wisej.Web.Padding(20, 10, 20, 10);
            this.exampleOrganization.Size = new System.Drawing.Size(300, 204);
            this.exampleOrganization.Spacing = 0;
            this.exampleOrganization.TabIndex = 1;
            this.exampleOrganization.VerticalAlign = Wisej.Web.VerticalAlignment.Middle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("windowTitle", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Organization";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: Test Organization";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name: Test Organization";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flexLayoutPanel1
            // 
            this.flexLayoutPanel1.Controls.Add(this.deleteBtn);
            this.flexLayoutPanel1.Controls.Add(this.editBtn);
            this.flexLayoutPanel1.HorizontalAlign = Wisej.Web.HorizontalAlignment.Center;
            this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(23, 124);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.Size = new System.Drawing.Size(254, 30);
            this.flexLayoutPanel1.TabIndex = 6;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.deleteBtn.Location = new System.Drawing.Point(50, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new Wisej.Web.Padding(12, 0, 12, 0);
            this.deleteBtn.Size = new System.Drawing.Size(78, 24);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.AutoSize = true;
            this.editBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.editBtn.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.editBtn.Location = new System.Drawing.Point(144, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new Wisej.Web.Padding(12, 0, 12, 0);
            this.editBtn.Size = new System.Drawing.Size(63, 24);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // flexLayoutPanel2
            // 
            this.flexLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flexLayoutPanel2.Name = "flexLayoutPanel2";
            this.flexLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flexLayoutPanel2.TabIndex = 0;
            // 
            // OrganizationPanel
            // 
            this.Controls.Add(this.exampleOrganization);
            this.Name = "OrganizationPanel";
            this.Size = new System.Drawing.Size(300, 204);
            this.exampleOrganization.ResumeLayout(false);
            this.exampleOrganization.PerformLayout();
            this.flexLayoutPanel1.ResumeLayout(false);
            this.flexLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.FlexLayoutPanel exampleOrganization;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
        private Wisej.Web.Button deleteBtn;
        private Wisej.Web.FlexLayoutPanel flexLayoutPanel2;
        private Wisej.Web.Button editBtn;
    }
}
