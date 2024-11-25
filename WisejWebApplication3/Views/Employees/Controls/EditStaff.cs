using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using Wisej.Web;
using WisejWebApplication3.Services;

namespace WisejWebApplication3.Views.Employees.Controls
{
    public partial class EditStaff : Form
    {
        private ErrorProvider ErrorProvider;
        public event EventHandler StaffEditted;
        private readonly Staff Staff;


        public EditStaff(Staff staff)
        {
            InitializeComponent();
            ErrorProvider = new ErrorProvider();
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Staff = staff;
            TitleField.Text = staff.Title;
            FirstNameField.Text = staff.FirstName;
            LastNameField.Text = staff.LastName;        
            PhoneNumberField.Text = staff.PhoneNumber;
            EmailField.Text = staff.Email;
        }


        private void SetError(TextBox textBox, String errorMsg)
        {
            textBox.BackColor = Color.MistyRose;
            ErrorProvider.SetError(textBox, errorMsg);
            ErrorProvider.SetIconAlignment(textBox, ErrorIconAlignment.MiddleRight);
        }

        private void ClearError(TextBox textBox)
        {
            textBox.BackColor = Color.White;
            ErrorProvider.SetError(textBox, "");
        }


        private void Title_Validating(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetError(textBox, "Title is required.");
            }
            else
            {
                ClearError(textBox);
            }
        }

        private static bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void EmailField_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetError(textBox, "Email is required.");
            }
            else if (!IsEmail(textBox.Text))
            {
                SetError(textBox, "Email is not valid.");
            }
            else
            {
                ClearError(textBox);
            }
        }

        private void FirstNameField_Validating(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetError(textBox, "First name is required.");
            }
            else
            {
                ClearError(textBox);
            }
        }
        private void LastNameField_Validating(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetError(textBox, "Last name is required.");
            }
            else
            {
                ClearError(textBox);
            }
        }


        private void PhoneNumberField_Validating(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string phoneNumber = PhoneNumberField.Text.Trim();
            bool isValidPhoneNumber = phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                SetError(textBox, "Phone number is required.");
            }
            else if (isValidPhoneNumber)
            {
                SetError(textBox, "Phone number must be exactly 10 digits.");
            }
            else
            {
                ClearError(textBox);
            }

        }

        private async void EditStaffBtn_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (ErrorProvider.HasErrors)
            {
                MessageBox.Show("Cannot edit organization until errors are resolved.");
                return;
            }

            try
            {
                var staff = new Staff
                {
                    FirstName = FirstNameField.Text,
                    LastName = LastNameField.Text,
                    PhoneNumber = PhoneNumberField.Text,
                    Email = EmailField.Text,
                };
                await StaffService.EditStaff(Staff.Id, staff);
                MessageBox.Show("Staff has been successfully edited!");
                StaffEditted?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error failed to edit organization in database: {ex.Message}");
            }
        }
    }
}
