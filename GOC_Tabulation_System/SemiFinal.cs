using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class SemiFinal
    {
        protected int id;
        protected string judge;
        protected string score_beauty;
        protected string score_wit;
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

        public string Score_beauty
        {
            get { return score_beauty; }
            set { score_beauty = value; }
        }

        public string Score_wit
        {
            get { return score_wit; }
            set { score_wit = value; }
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
                    string sql = string.Concat("UPDATE semi_final SET " + "b" + judge + " = @score_beauty, " + "w" + judge + " = @score_wit WHERE can_no=@can_no;");

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("can_no", can_no);
                    cmd.Parameters.AddWithValue("score_beauty", score_beauty);
                    cmd.Parameters.AddWithValue("score_wit", score_wit);
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
