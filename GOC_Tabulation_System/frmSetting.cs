using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    public partial class frmSetting : Form
    {
        public void setThis()
        {
            if (this.CheckRequiredFields() == true)
            {
                //set properties
                GOC_Tabulation_System.Config.DSN = txtDSN.Text;
                GOC_Tabulation_System.Config.DB_HOST = txtHost.Text;
                GOC_Tabulation_System.Config.DB_NAME = txtName.Text;
                GOC_Tabulation_System.Config.DB_USER = txtUser.Text;
                GOC_Tabulation_System.Config.DB_PASSWORD = txtPassword.Text;

                //save settings
                GOC_Tabulation_System.Config.saveSettings();

                if (GOC_Tabulation_System.Config.TestConnection())
                {
                    MessageBox.Show("Successfully Connected to Database", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //if (flag == "Client")
                    //{
                    //    frmFrontMain frmFrontMain = new frmFrontMain();
                    //    frmFrontMain.ShowDialog();
                    //    this.Dispose();
                    //    this.Close();
                    //}
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }
        private void GetServerSettings()
        {
            txtDSN.Text = GOC_Tabulation_System.Config.DSN;
            txtHost.Text = GOC_Tabulation_System.Config.DB_HOST;
            txtName.Text = GOC_Tabulation_System.Config.DB_NAME;
            txtUser.Text = GOC_Tabulation_System.Config.DB_USER;
            txtPassword.Text = GOC_Tabulation_System.Config.DB_PASSWORD;
        }

        private bool CheckRequiredFields()
        {
            if (txtDSN.Text == "")
            {
                return false;
            }

            if (txtHost.Text == "")
            {
                return false;
            }

            if (txtName.Text == "")
            {
                return false;
            }

            if (txtUser.Text == "")
            {
                return false;
            }

            return true;
        }

        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            setThis();
        }

        private void frmSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSaveConfiguration.PerformClick();
            }
        }
    }
}
