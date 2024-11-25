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
            this.deleteBtn = new Wisej.Web.Button();
            this.editBtn = new Wisej.Web.Button();
            this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
            this.label4 = new Wisej.Web.Label();
            this.ViewEmployeesBtn = new Wisej.Web.Button();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.tableLayoutPanel3 = new Wisej.Web.TableLayoutPanel();
            this.exampleOrganization.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exampleOrganization
            // 
            this.exampleOrganization.BackColor = System.Drawing.Color.FromName("@control");
            this.exampleOrganization.Controls.Add(this.label1);
            this.exampleOrganization.Controls.Add(this.label2);
            this.exampleOrganization.Controls.Add(this.label3);
            this.exampleOrganization.Controls.Add(this.label4);
            this.exampleOrganization.Controls.Add(this.tableLayoutPanel1);
            this.exampleOrganization.Controls.Add(this.tableLayoutPanel3);
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
            this.label1.Location = new System.Drawing.Point(23, 13);
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
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Street";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country, Zip";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Dock = Wisej.Web.DockStyle.Fill;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.deleteBtn.Location = new System.Drawing.Point(130, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new Wisej.Web.Padding(12, 0, 12, 0);
            this.deleteBtn.Size = new System.Drawing.Size(121, 24);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.editBtn.Size = new System.Drawing.Size(121, 24);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Employees";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewEmployeesBtn
            // 
            this.ViewEmployeesBtn.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.ViewEmployeesBtn.AutoSize = true;
            this.ViewEmployeesBtn.BackColor = System.Drawing.Color.LightYellow;
            this.ViewEmployeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ViewEmployeesBtn.ForeColor = System.Drawing.Color.Black;
            this.ViewEmployeesBtn.Location = new System.Drawing.Point(3, 3);
            this.ViewEmployeesBtn.Name = "ViewEmployeesBtn";
            this.ViewEmployeesBtn.Padding = new Wisej.Web.Padding(12, 0, 12, 0);
            this.ViewEmployeesBtn.Size = new System.Drawing.Size(248, 24);
            this.ViewEmployeesBtn.TabIndex = 7;
            this.ViewEmployeesBtn.Text = "View Employees";
            this.ViewEmployeesBtn.Click += new System.EventHandler(this.ViewEmployeesBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ViewEmployeesBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 30);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.editBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.deleteBtn, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 154);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = Wisej.Web.RightToLeft.No;
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(254, 30);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // OrganizationPanel
            // 
            this.Controls.Add(this.exampleOrganization);
            this.Name = "OrganizationPanel";
            this.Size = new System.Drawing.Size(300, 204);
            this.exampleOrganization.ResumeLayout(false);
            this.exampleOrganization.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private Wisej.Web.Label label4;
        private Wisej.Web.Button ViewEmployeesBtn;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel3;
    }
}
