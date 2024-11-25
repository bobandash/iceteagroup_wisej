using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wisej.Web;
using WisejWebApplication3.Services;
using WisejWebApplication3.Views.Employees.Controls;


namespace WisejWebApplication3.Views.Employees
{
    public partial class EmployeePage : Page
    {
        private AddStaff AddStaffWindow;
        private Organization Organization;
        private EditStaff EditStaffWindow;

        public EmployeePage(Organization organization)
        {
            InitializeComponent();
            this.Organization = organization;
            this.employeeTable.Text = $"{organization.Name} Employees Table";
        }

        private async void RefreshStaffPage(object sender, EventArgs e)
        {
            await SetupEmployeeItems();
        }

        private async void EmployeePage_Load(object sender, EventArgs e)
        {
            await SetupEmployeeItems();
        }

        private async Task SetupEmployeeItems()
        {
            this.employeeTable.Controls.Clear();
            this.employeeTable.Controls.Add(this.panel3);
            List<Staff> staffs = await StaffService.GetStaffs(Organization.Id);
            foreach (Staff staff in staffs)
            {
                var staffPanel = new StaffPanel(staff, EditStaffWindow, RefreshStaffPage);
                staffPanel.StaffRemoved += RefreshStaffPage;
                this.employeeTable.Controls.Add(staffPanel);
            }
        }



        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (AddStaffWindow == null || AddStaffWindow.IsDisposed)
            {
                AddStaffWindow = new AddStaff(Organization);
                AddStaffWindow.StaffAdded += RefreshStaffPage;
                AddStaffWindow.Show();
            }
            else
            {
                AddStaffWindow.Focus();
            }
        }

        private void employeeTable_PanelCollapsed(object sender, EventArgs e)
        {

        }

        private void BackHomeBtn_Click(object sender, EventArgs e)
        {
            Application.OpenPages["Homepage"].Show();
        }
    }
}
