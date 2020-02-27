using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class FormStatus
    {
        protected int id;
        protected string formStatus;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Form_Status
        {
            get { return formStatus; }
            set { formStatus = value; }
        }

        public void Update()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE form_active SET formStatus=@formStatus ";
                    //"WHERE id= @id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("formStatus", formStatus);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Form Status Updated!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        List<FormStatus> status = new List<FormStatus>();

        public List<FormStatus> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {
                    con.Open();


                    string sql = "SELECT formStatus FROM form_active";


                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        FormStatus frmStat = new FormStatus();

                        //prepare properties                      
                        frmStat.formStatus = reader["formStatus"].ToString();

                        status.Add(frmStat);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;

        }//End of Load

    }
}
