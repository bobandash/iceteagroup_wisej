namespace WisejWebApplication3.Views.Employees.Controls
{
    partial class EditStaff
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
            this.TitleField = new Wisej.Web.TextBox();
            this.EmailField = new Wisej.Web.TextBox();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.FirstNameField = new Wisej.Web.TextBox();
            this.PhoneNumberField = new Wisej.Web.TextBox();
            this.backgroundWorker1 = new Wisej.Web.BackgroundWorker();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.LastNameField = new Wisej.Web.TextBox();
            this.EditStaffBtn = new Wisej.Web.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleField
            // 
            clientEvent1.Event = "blur";
            this.TitleField.ClientEvents.Add(clientEvent1);
            this.TitleField.LabelText = "Title";
            this.TitleField.Location = new System.Drawing.Point(27, 27);
            this.TitleField.MaxLength = 100;
            this.TitleField.Name = "TitleField";
            this.TitleField.Size = new System.Drawing.Size(271, 53);
            this.TitleField.TabIndex = 0;
            this.TitleField.Validating += new System.ComponentModel.CancelEventHandler(this.Title_Validating);
            // 
            // EmailField
            // 
            this.EmailField.Dock = Wisej.Web.DockStyle.Fill;
            this.EmailField.LabelText = "Email";
            this.EmailField.Location = new System.Drawing.Point(27, 263);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(271, 53);
            this.EmailField.TabIndex = 5;
            this.EmailField.Validating += new System.ComponentModel.CancelEventHandler(this.EmailField_Validating);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // FirstNameField
            // 
            clientEvent2.Event = "blur";
            this.FirstNameField.ClientEvents.Add(clientEvent2);
            this.FirstNameField.Dock = Wisej.Web.DockStyle.Fill;
            this.FirstNameField.LabelText = "First Name";
            this.FirstNameField.Location = new System.Drawing.Point(27, 86);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(271, 53);
            this.FirstNameField.TabIndex = 2;
            this.FirstNameField.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameField_Validating);
            // 
            // PhoneNumberField
            // 
            this.PhoneNumberField.Dock = Wisej.Web.DockStyle.Fill;
            this.PhoneNumberField.LabelText = "Phone Number";
            this.PhoneNumberField.Location = new System.Drawing.Point(27, 204);
            this.PhoneNumberField.Name = "PhoneNumberField";
            this.PhoneNumberField.RightToLeft = Wisej.Web.RightToLeft.No;
            this.PhoneNumberField.Size = new System.Drawing.Size(271, 53);
            this.PhoneNumberField.TabIndex = 4;
            this.PhoneNumberField.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneNumberField_Validating);
            // 
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TitleField);
            this.flowLayoutPanel1.Controls.Add(this.FirstNameField);
            this.flowLayoutPanel1.Controls.Add(this.LastNameField);
            this.flowLayoutPanel1.Controls.Add(this.PhoneNumberField);
            this.flowLayoutPanel1.Controls.Add(this.EmailField);
            this.flowLayoutPanel1.Controls.Add(this.EditStaffBtn);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(24);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 390);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // LastNameField
            // 
            clientEvent3.Event = "blur";
            this.LastNameField.ClientEvents.Add(clientEvent3);
            this.LastNameField.Dock = Wisej.Web.DockStyle.Fill;
            this.LastNameField.LabelText = "Last Name";
            this.LastNameField.Location = new System.Drawing.Point(27, 145);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(271, 53);
            this.LastNameField.TabIndex = 3;
            this.LastNameField.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameField_Validating);
            // 
            // EditStaffBtn
            // 
            this.EditStaffBtn.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.EditStaffBtn.BackColor = System.Drawing.Color.FromName("@primary");
            this.EditStaffBtn.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EditStaffBtn.ForeColor = System.Drawing.Color.FromName("@desktop");
            this.EditStaffBtn.Location = new System.Drawing.Point(27, 331);
            this.EditStaffBtn.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
            this.EditStaffBtn.Name = "EditStaffBtn";
            this.EditStaffBtn.Size = new System.Drawing.Size(271, 37);
            this.EditStaffBtn.TabIndex = 6;
            this.EditStaffBtn.Text = "Edit Staff";
            this.EditStaffBtn.Click += new System.EventHandler(this.EditStaffBtn_Click);
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 390);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EditStaff";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TextBox TitleField;
        private Wisej.Web.TextBox EmailField;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.TextBox FirstNameField;
        private Wisej.Web.TextBox PhoneNumberField;
        private Wisej.Web.BackgroundWorker backgroundWorker1;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Button EditStaffBtn;
        private Wisej.Web.TextBox LastNameField;

    }
}