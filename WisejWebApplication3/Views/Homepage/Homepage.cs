
using System;
using System.Collections.Generic;
using Wisej.Web;
using Page = Wisej.Web.Page;
using WisejWebApplication3.Services;
using System.Diagnostics;
using System.Threading.Tasks;
using WisejWebApplication3.Views.Homepage.Controls;
using System.Drawing.Text;

namespace WisejWebApplication3
{
    public partial class Homepage : Page
    {
        private AddOrganization AddOrganizationWindow;
        private EditOrganization EditOrganizationWindow;
        public Homepage()
        {
            InitializeComponent();
            this.VisibleChanged += Homepage_VisibleChanged;
        }

        private async void Homepage_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) 
            {
                await SetupOrganizationComponents();
            }
        }


        private async void RefreshHomePage(object sender, EventArgs e)
        {
            await SetupOrganizationComponents();
        }

        private async Task SetupOrganizationComponents()
        {
            this.organizationTable.Controls.Clear();
            this.organizationTable.Controls.Add(this.panel3);
            List<Organization> organizations = await OrganizationService.GetOrganizations();
            foreach (Organization organization in organizations)
            {
                var organizationPanel = new OrganizationPanel(organization, EditOrganizationWindow, RefreshHomePage);
                organizationPanel.OrganizationRemoved += RefreshHomePage;
                this.organizationTable.Controls.Add(organizationPanel);
            }
        }

        private void AddOrganization_Click(object sender, EventArgs e)
        {
            if (AddOrganizationWindow == null || AddOrganizationWindow.IsDisposed)
            {
                AddOrganizationWindow = new AddOrganization();
                AddOrganizationWindow.OrganizationAdded += RefreshHomePage;
                AddOrganizationWindow.Show();
            }
            else
            {
                AddOrganizationWindow.Focus();
            }
           
        }


    }
}

