using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class Judges
    {
        protected int id;
        protected string judge;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Judge
        {
            get { return judge; }
            set { judge = value; }
        }

        List<Judges> ListJudges = new List<Judges>();

        public List<Judges> Load()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {
                    con.Open();


                    string sql = "SELECT * FROM judges";


                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //loop while have record
                    while (reader.Read())
                    {
                        //instantiate model
                        Judges judge = new Judges();

                        //prepare properties
                        judge.id = Convert.ToInt32(reader["id"].ToString());
                        judge.judge = reader["judges"].ToString();

                        ListJudges.Add(judge);                                               
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ListJudges;

        }//End of Load

    }
}
