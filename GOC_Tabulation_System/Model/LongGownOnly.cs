using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class LongGownOnly
    {
        protected int id;
        protected string judge;
        protected string score;
        protected string can_no;
       
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

        public string Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Can_no
        {
            get { return can_no; }
            set { can_no = value; }
        }


        public void Save()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    //string sql = "UPDATE long_gown SET  j1=@score WHERE can_no=@can_no;";
                    string sql = string.Concat("UPDATE long_gown SET " + "j" + judge + " = @score WHERE can_no=@can_no;");


                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("can_no", can_no);
                    cmd.Parameters.AddWithValue("score", score);
                    cmd.Parameters.AddWithValue("judge", judge);


                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("Recorde Updated!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
