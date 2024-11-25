namespace WisejWebApplication3
{
    partial class EditOrganization
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
            this.components = new System.ComponentModel.Container();
            Wisej.Web.JavaScript.ClientEvent clientEvent1 = new Wisej.Web.JavaScript.ClientEvent();
            Wisej.Web.JavaScript.ClientEvent clientEvent2 = new Wisej.Web.JavaScript.ClientEvent();
            Wisej.Web.JavaScript.ClientEvent clientEvent3 = new Wisej.Web.JavaScript.ClientEvent();
            this.NameField = new Wisej.Web.TextBox();
            this.ZipField = new Wisej.Web.TextBox();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.StreetField = new Wisej.Web.TextBox();
            this.CountryField = new Wisej.Web.TextBox();
            this.backgroundWorker1 = new Wisej.Web.BackgroundWorker();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.CityField = new Wisej.Web.TextBox();
            this.EditOrganizationBtn = new Wisej.Web.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameField
            // 
            clientEvent1.Event = "blur";
            this.NameField.ClientEvents.Add(clientEvent1);
            this.NameField.LabelText = "Name";
            this.NameField.Location = new System.Drawing.Point(27, 27);
            this.NameField.MaxLength = 100;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(271, 53);
            this.NameField.TabIndex = 0;
            this.NameField.TextChanged += new System.EventHandler(this.NameField_TextChanged);
            this.NameField.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            // 
            // ZipField
            // 
            this.ZipField.Dock = Wisej.Web.DockStyle.Fill;
            this.ZipField.LabelText = "Zip";
            this.ZipField.Location = new System.Drawing.Point(27, 263);
            this.ZipField.Name = "ZipField";
            this.ZipField.Size = new System.Drawing.Size(271, 53);
            this.ZipField.TabIndex = 5;
            this.ZipField.Validating += new System.ComponentModel.CancelEventHandler(this.Zip_Validating);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // StreetField
            // 
            clientEvent2.Event = "blur";
            this.StreetField.ClientEvents.Add(clientEvent2);
            this.StreetField.Dock = Wisej.Web.DockStyle.Fill;
            this.StreetField.LabelText = "Street";
            this.StreetField.Location = new System.Drawing.Point(27, 86);
            this.StreetField.Name = "StreetField";
            this.StreetField.Size = new System.Drawing.Size(271, 53);
            this.StreetField.TabIndex = 2;
            this.StreetField.TextChanged += new System.EventHandler(this.StreetField_TextChanged);
            this.StreetField.Validating += new System.ComponentModel.CancelEventHandler(this.Street_Validating);
            // 
            // CountryField
            // 
            this.CountryField.Dock = Wisej.Web.DockStyle.Fill;
            this.CountryField.LabelText = "Country Code";
            this.CountryField.Location = new System.Drawing.Point(27, 204);
            this.CountryField.Name = "CountryField";
            this.CountryField.RightToLeft = Wisej.Web.RightToLeft.No;
            this.CountryField.Size = new System.Drawing.Size(271, 53);
            this.CountryField.TabIndex = 4;
            this.CountryField.Validating += new System.ComponentModel.CancelEventHandler(this.Country_Validating);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NameField);
            this.flowLayoutPanel1.Controls.Add(this.StreetField);
            this.flowLayoutPanel1.Controls.Add(this.CityField);
            this.flowLayoutPanel1.Controls.Add(this.CountryField);
            this.flowLayoutPanel1.Controls.Add(this.ZipField);
            this.flowLayoutPanel1.Controls.Add(this.EditOrganizationBtn);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(24);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 388);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.PanelCollapsed += new System.EventHandler(this.flowLayoutPanel1_PanelCollapsed);
            // 
            // CityField
            // 
            clientEvent3.Event = "blur";
            this.CityField.ClientEvents.Add(clientEvent3);
            this.CityField.Dock = Wisej.Web.DockStyle.Fill;
            this.CityField.LabelText = "City";
            this.CityField.Location = new System.Drawing.Point(27, 145);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(271, 53);
            this.CityField.TabIndex = 3;
            this.CityField.Validating += new System.ComponentModel.CancelEventHandler(this.CityField_Validating);
            // 
            // EditOrganizationBtn
            // 
            this.EditOrganizationBtn.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.EditOrganizationBtn.BackColor = System.Drawing.Color.FromName("@primary");
            this.EditOrganizationBtn.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EditOrganizationBtn.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.EditOrganizationBtn.Location = new System.Drawing.Point(27, 331);
            this.EditOrganizationBtn.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
            this.EditOrganizationBtn.Name = "EditOrganizationBtn";
            this.EditOrganizationBtn.Size = new System.Drawing.Size(271, 37);
            this.EditOrganizationBtn.TabIndex = 6;
            this.EditOrganizationBtn.Text = "Edit Organization";
            this.EditOrganizationBtn.Click += new System.EventHandler(this.EditOrganizationBtn_Click);
            // 
            // EditOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 388);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EditOrganization";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TextBox NameField;
        private Wisej.Web.TextBox ZipField;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.TextBox StreetField;
        private Wisej.Web.TextBox CountryField;
        private Wisej.Web.BackgroundWorker backgroundWorker1;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Button EditOrganizationBtn;
        private Wisej.Web.TextBox CityField;

    }
}