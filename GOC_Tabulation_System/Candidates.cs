using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class Candidates
    {
        protected int id;
        protected string candidates;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Candidate
        {
            get { return candidates; }
            set { candidates = value; }
        }


        List<Candidates> ListCandidates = new List<Candidates>();

        public List<Candidates> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {
                    con.Open();


                    string sql = "SELECT * FROM candidates";


                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Candidates candidate = new Candidates();

                        //prepare properties
                        candidate.id = Convert.ToInt32(reader["id"].ToString());
                        candidate.candidates = reader["can_no"].ToString();

                        ListCandidates.Add(candidate);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ListCandidates;

        }//End of Load

    }
}
