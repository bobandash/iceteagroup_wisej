﻿using System;
using System.Diagnostics;
using Wisej.Web;
using WisejWebApplication3.Services;
using WisejWebApplication3.Views.Employees;

namespace WisejWebApplication3.Views.Homepage.Controls
{
    public partial class OrganizationPanel : Wisej.Web.UserControl
    {
        private Organization Organization;
        public event EventHandler OrganizationRemoved;
        private EditOrganization EditOrganizationWindow;
        private EventHandler RefreshHomepage;

        public OrganizationPanel()
        {
            InitializeComponent();
        }

        public OrganizationPanel(Organization organization, EditOrganization editOrganizationWindow, EventHandler refreshHomePage)
        {
            InitializeComponent();
            Organization = organization;
            EditOrganizationWindow = editOrganizationWindow;
            RefreshHomepage = refreshHomePage;
            label1.Text = organization.Name;
            label2.Text = organization.Street;
            label3.Text = $"{organization.City} {organization.CountryCode} {organization.Zip}";
            label4.Text = $"{organization.Staff.Count} Employees";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (EditOrganizationWindow == null || EditOrganizationWindow.IsDisposed)
            {
                EditOrganizationWindow = new EditOrganization(Organization);
                EditOrganizationWindow.OrganizationEditted += RefreshHomepage;
                EditOrganizationWindow.Show();
            }
            else
            {
                EditOrganizationWindow.Focus();
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            try {
                await OrganizationService.RemoveOrganization(Organization.Id);
                OrganizationRemoved.Invoke(this, EventArgs.Empty);
            }
            catch {
                MessageBox.Show("Failed to remove organization.");
            }
        }


        private void ViewEmployeesBtn_Click(object sender, EventArgs e)
        {
            var page = new EmployeePage(Organization);
            page.Name = "EmployeePage";
            page.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exampleOrganization_PanelCollapsed(object sender, EventArgs e)
        {

        }
    }
}
