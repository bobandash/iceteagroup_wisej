﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Microsoft.Ajax.Utilities;
using Wisej.Web;
using PostalCodes;
using System.Linq;
using Wisej.Web.VisualBasic;
using WisejWebApplication3.Services;

namespace WisejWebApplication3
{
    public partial class AddOrganization : Form
    {
        private ErrorProvider ErrorProvider;
        public event EventHandler OrganizationAdded;

        public AddOrganization()
        {
            InitializeComponent();
            ErrorProvider = new ErrorProvider();
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }


        private void SetError(TextBox textBox, String errorMsg)
        {
            textBox.BackColor = Color.MistyRose;
            ErrorProvider.SetError(textBox,errorMsg);
            ErrorProvider.SetIconAlignment(textBox, ErrorIconAlignment.MiddleRight);
        }

        private void ClearError(TextBox textBox)
        {
            textBox.BackColor = Color.White;
            ErrorProvider.SetError(textBox, "");
        }


        private void Name_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetError(textBox, "Name is required.");

            }
            else
            {
                ClearError(textBox);
            }
        }

        private static bool IsValidCountry(string country)
        {
            try
            {
                CountryFactory.Instance.CreateCountry(country);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        private void Country_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            var countryCode = textBox.Text;
            if (string.IsNullOrWhiteSpace(countryCode))
            {
                SetError(textBox, "Country code is required.");
            } else if (!IsValidCountry(countryCode))
            {
                SetError(textBox, "Country code is not valid.");
            }
            else
            {
                ClearError(textBox);
            }
        }

        private static bool IsValidZipCode(string countryCode, string zipCode)
        {
            try
            {
                var country = CountryFactory.Instance.CreateCountry(countryCode);
                var postalCode = PostalCodeFactory.Instance.CreatePostalCode(country, zipCode);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }

        }

        private void Zip_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string zipCode = textBox.Text;
            string countryCode = CountryField.Text;

            if (string.IsNullOrWhiteSpace(zipCode))
            {
                SetError(textBox, "Zip code is required.");
            }
            else if (string.IsNullOrEmpty(countryCode))
            {
                SetError(textBox, "Country code is required to validate zip code.");
            }
            else if (!IsValidZipCode(countryCode, zipCode))
            {
                SetError(textBox, "Zip code is not valid.");
            }
            else
            {
                ClearError(textBox);
            }
        }

        private void Street_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetError(textBox, "Name is required.");
            }
            else
            {
                ClearError(textBox);
            }
        }


        private void CityField_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetError(textBox, "City is required.");
            }
            else
            {
                ClearError(textBox);
            }
        }


        private async void AddBtn_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (ErrorProvider.HasErrors)
            {
                MessageBox.Show("Cannot add organization until errors are resolved.");
                return;
            }

            try
            {
                var organization = new Organization
                {
                    Name = NameField.Text,
                    Street = StreetField.Text,
                    City = CityField.Text,
                    CountryCode = CountryField.Text,
                    Zip = ZipField.Text,
                };
                await OrganizationService.AddOrganization(organization);
                MessageBox.Show("Organization has been successfully added!");
                OrganizationAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            } 
            catch(Exception ex) {
                MessageBox.Show($"Error adding organization to database: {ex.Message}");
            }
        }

        private void flowLayoutPanel1_PanelCollapsed(object sender, EventArgs e)
        {

        }
    }
}
