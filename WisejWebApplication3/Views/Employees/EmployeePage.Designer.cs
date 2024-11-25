namespace WisejWebApplication3.Views.Employees
{
    partial class EmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            this.employeeTable = new Wisej.Web.TableLayoutPanel();
            this.panel3 = new Wisej.Web.Panel();
            this.addEmployeeBtn = new Wisej.Web.Button();
            this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
            this.BackHomeBtn = new Wisej.Web.Button();
            this.employeeTable.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flexLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeTable
            // 
            this.employeeTable.ColumnCount = 2;
            this.employeeTable.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
            this.employeeTable.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
            this.employeeTable.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
            this.employeeTable.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
            this.employeeTable.Controls.Add(this.panel3, 0, 0);
            this.employeeTable.Dock = Wisej.Web.DockStyle.Fill;
            this.employeeTable.Font = new System.Drawing.Font("windowTitle", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.employeeTable.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
            this.employeeTable.HeaderBackColor = System.Drawing.Color.FromName("@activeBorder");
            this.employeeTable.HeaderForeColor = System.Drawing.Color.Black;
            this.employeeTable.HeaderSize = 64;
            this.employeeTable.Location = new System.Drawing.Point(0, 0);
            this.employeeTable.Margin = new Wisej.Web.Padding(12);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.Padding = new Wisej.Web.Padding(24, 0, 24, 0);
            this.employeeTable.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("employeeTable.ResponsiveProfiles"))));
            this.employeeTable.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("employeeTable.ResponsiveProfiles1"))));
            this.employeeTable.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("employeeTable.ResponsiveProfiles2"))));
            this.employeeTable.RowCount = 4;
            this.employeeTable.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 200F));
            this.employeeTable.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 200F));
            this.employeeTable.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 200F));
            this.employeeTable.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 200F));
            this.employeeTable.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 200F));
            this.employeeTable.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 200F));
            this.employeeTable.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 200F));
            this.employeeTable.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 200F));
            this.employeeTable.ShowCloseButton = false;
            this.employeeTable.ShowHeader = true;
            this.employeeTable.Size = new System.Drawing.Size(994, 598);
            this.employeeTable.TabIndex = 1;
            this.employeeTable.Text = "Employee Table";
            this.employeeTable.PanelCollapsed += new System.EventHandler(this.employeeTable_PanelCollapsed);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel3.CollapseSide = Wisej.Web.HeaderPosition.Right;
            this.panel3.Controls.Add(this.addEmployeeBtn);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel3.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
            this.panel3.HeaderPosition = Wisej.Web.HeaderPosition.Right;
            this.panel3.Location = new System.Drawing.Point(27, 3);
            this.panel3.Name = "panel3";
            this.panel3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel3.ResponsiveProfiles"))));
            this.panel3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel3.ResponsiveProfiles1"))));
            this.panel3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel3.ResponsiveProfiles2"))));
            this.panel3.ShowCloseButton = false;
            this.panel3.Size = new System.Drawing.Size(467, 194);
            this.panel3.TabIndex = 0;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.AutoSize = true;
            this.addEmployeeBtn.BackColor = System.Drawing.Color.FromName("@highlight");
            this.addEmployeeBtn.Dock = Wisej.Web.DockStyle.Fill;
            this.addEmployeeBtn.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.addEmployeeBtn.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.addEmployeeBtn.Location = new System.Drawing.Point(0, 0);
            this.addEmployeeBtn.Margin = new Wisej.Web.Padding(24);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("addEmployeeBtn.ResponsiveProfiles"))));
            this.addEmployeeBtn.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("addEmployeeBtn.ResponsiveProfiles1"))));
            this.addEmployeeBtn.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("addEmployeeBtn.ResponsiveProfiles2"))));
            this.addEmployeeBtn.Size = new System.Drawing.Size(465, 192);
            this.addEmployeeBtn.TabIndex = 2;
            this.addEmployeeBtn.Text = "Add An Employee";
            this.addEmployeeBtn.UseMnemonic = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // flexLayoutPanel1
            // 
            this.flexLayoutPanel1.AutoSize = true;
            this.flexLayoutPanel1.Controls.Add(this.BackHomeBtn);
            this.flexLayoutPanel1.Controls.Add(this.employeeTable);
            this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flexLayoutPanel1.HorizontalAlign = Wisej.Web.HorizontalAlignment.Center;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flexLayoutPanel1.Margin = new Wisej.Web.Padding(0);
            this.flexLayoutPanel1.MaximumSize = new System.Drawing.Size(1200, 0);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flexLayoutPanel1.ResponsiveProfiles"))));
            this.flexLayoutPanel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flexLayoutPanel1.ResponsiveProfiles1"))));
            this.flexLayoutPanel1.Size = new System.Drawing.Size(994, 598);
            this.flexLayoutPanel1.TabIndex = 1;
            // 
            // BackHomeBtn
            // 
            this.BackHomeBtn.BackColor = System.Drawing.Color.FromName("@activeCaption");
            this.BackHomeBtn.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.BackHomeBtn.Location = new System.Drawing.Point(8, 8);
            this.BackHomeBtn.Name = "BackHomeBtn";
            this.BackHomeBtn.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("BackHomeBtn.ResponsiveProfiles"))));
            this.BackHomeBtn.Size = new System.Drawing.Size(145, 37);
            this.BackHomeBtn.TabIndex = 3;
            this.BackHomeBtn.Text = "button1";
            this.BackHomeBtn.Click += new System.EventHandler(this.BackHomeBtn_Click);
            // 
            // EmployeePage
            // 
            this.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.flexLayoutPanel1);
            this.Name = "EmployeePage";
            this.Size = new System.Drawing.Size(994, 598);
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            this.employeeTable.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flexLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Button addEmployeeBtn;
        private Wisej.Web.TableLayoutPanel employeeTable;
        private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
        private Wisej.Web.Button BackHomeBtn;
    }
}
