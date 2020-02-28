using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class TopFinalists
    {
        protected int id;
        protected string finalistsCount;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FinalistsCount
        {
            get { return finalistsCount; }
            set { finalistsCount = value; }
        }

        List<TopFinalists> finalists = new List<TopFinalists>();

        public void Update()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE top_finalists SET no_of_to_finalist = @finalistsCount ";
                    //"WHERE id= @id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("finalistsCount", finalistsCount);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("No of Top Finalist Updated!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public List<TopFinalists> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {
                    con.Open();


                    string sql = "SELECT * FROM top_finalists";


                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        TopFinalists finalist= new TopFinalists();

                        //prepare properties                      
                        finalist.finalistsCount = reader["no_of_top_finalist"].ToString();

                        finalists.Add(finalist);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return finalists;

        }//End of Load
    }
}
