
using System;
using Wisej.Web;
using Page = Wisej.Web.Page;

namespace WisejWebApplication3
{
    public partial class Homepage : Page
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel2_PanelCollapsed(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void flexLayoutPanel2_PanelCollapsed(object sender, EventArgs e)
        {

        }

        private void flexLayoutPanel1_PanelCollapsed(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_PanelCollapsed(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_PanelCollapsed(object sender, EventArgs e)
        {
        }

        private void AddOrganization_Click(object sender, EventArgs e)
        {
            AddOrganization window = new AddOrganization();
            window.Show();
        }
    }
}
