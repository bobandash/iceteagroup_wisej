using System;
using Wisej.Web;
using WisejWebApplication3.Services;

namespace WisejWebApplication3.Views.Employees.Controls
{
    public partial class StaffPanel : Panel
    {

        private Staff Staff;
        public event EventHandler StaffRemoved;
        private EditStaff EditStaffWindow;
        private EventHandler RefreshStaffPage;

        public StaffPanel()
        {
            InitializeComponent();
        }

        public StaffPanel(Staff staff, EditStaff editStaffWindow, EventHandler refreshStaffPage)
        {
            InitializeComponent();
            Staff = staff;
            EditStaffWindow = editStaffWindow;
            RefreshStaffPage = refreshStaffPage;
            label1.Text = $"{staff.FirstName} {staff.LastName}";
            label2.Text = $"{staff.PhoneNumber}";
            label3.Text = $"{staff.Email}";

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (EditStaffWindow == null || EditStaffWindow.IsDisposed)
            {
                EditStaffWindow = new EditStaff(Staff);
                EditStaffWindow.StaffEditted += RefreshStaffPage;
                EditStaffWindow.Show();
            }
            else
            {
                EditStaffWindow.Focus();
            }
        }


        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await StaffService.RemoveStaff(Staff.Id);
                StaffRemoved.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Successfully removed staff.");
            }
            catch
            {
                MessageBox.Show("Failed to remove staff.");
            }
        }
    }
}
