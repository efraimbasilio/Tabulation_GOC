using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class BeautyAndLongGown
    {
        protected int id;
        protected string judge;
        protected string score_beauty;
        protected string score_wit;
        protected string can_no;

        protected string b1;
        protected string g1;
        protected string b2;
        protected string g2;
        protected string b3;
        protected string g3;
        protected string b4;
        protected string g4;
        protected string b5;
        protected string g5;
        protected string b6;
        protected string g6;
        protected string b7;
        protected string g7;
        protected string b8;
        protected string g8;
        protected string b9;
        protected string g9;
        protected string total;
        protected string total_overall;


        public string B1 { get { return b1; } set { b1 = value; } }
        public string G1 { get { return g1; } set { g1 = value; } }
        public string B2 { get { return b2; } set { b2 = value; } }
        public string G2 { get { return g2; } set { g2 = value; } }
        public string B3 { get { return b3; } set { b3 = value; } }
        public string G3 { get { return g3; } set { g3 = value; } }
        public string B4 { get { return b4; } set { b4 = value; } }
        public string G4 { get { return g4; } set { g4 = value; } }
        public string B5 { get { return b5; } set { b5 = value; } }
        public string G5 { get { return g5; } set { g5 = value; } }
        public string B6 { get { return b6; } set { b6 = value; } }
        public string G6 { get { return g6; } set { g6 = value; } }
        public string B7 { get { return b7; } set { b7 = value; } }
        public string G7 { get { return g7; } set { g7 = value; } }
        public string B8 { get { return b8; } set { b8 = value; } }
        public string G8 { get { return g8; } set { g8 = value; } }
        public string B9 { get { return b9; } set { b9 = value; } }
        public string G9 { get { return g9; } set { g9 = value; } }
        public string Total { get { return total; } set { total = value; } }

        public string Total_overall { get { return total_overall; } set { total_overall = value; } }

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

                    string sql = "INSERT INTO beauty_and_long_gown(can_no,b1,g1,b2,g2,b3,g3,b4,g4,b5,g5,b6,g6,b7,g7,b8,g8,b9,g9,total) " +
                                    " VALUES (@can_no,@b1,@g1,@b2,@g2,@b3,@g3,@b4,@g4,@b5,@g5,@b6,@g6,@b7,@g7,@b8,@g8,@b9,@g9,@total);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("can_no", can_no);
                    cmd.Parameters.AddWithValue("b1", b1);
                    cmd.Parameters.AddWithValue("g1", g1);
                    cmd.Parameters.AddWithValue("b2", b2);
                    cmd.Parameters.AddWithValue("g2", g2);
                    cmd.Parameters.AddWithValue("b3", b3);
                    cmd.Parameters.AddWithValue("g3", g3);
                    cmd.Parameters.AddWithValue("b4", b4);
                    cmd.Parameters.AddWithValue("g4", g4);
                    cmd.Parameters.AddWithValue("b5", b5);
                    cmd.Parameters.AddWithValue("g5", g5);
                    cmd.Parameters.AddWithValue("b6", b6);
                    cmd.Parameters.AddWithValue("g6", g6);
                    cmd.Parameters.AddWithValue("b7", b7);
                    cmd.Parameters.AddWithValue("g7", g7);
                    cmd.Parameters.AddWithValue("b8", b8);
                    cmd.Parameters.AddWithValue("g8", g8);
                    cmd.Parameters.AddWithValue("b9", b9);
                    cmd.Parameters.AddWithValue("g9", g9);
                    cmd.Parameters.AddWithValue("total", total);


                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("Record Saved!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

                    string sql = "UPDATE beauty_and_long_gown SET b1=@b1,g1=@g1,b2=@b2,g2=@g2,b3=@b3,g3=@g3,b4=@b4,g4=@g4,b5=@b5,g5=@g5,b6=@b6,g6=@g6,b7=@b7,g7=@g7,b8=@b8,g8=@g8,b9=@b9,g9=@g9,total_long_gown=@total , total_overall=@total_overall " +
                                    "WHERE can_no= @can_no;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("can_no",can_no);
                    cmd.Parameters.AddWithValue("b1", b1);
                    cmd.Parameters.AddWithValue("g1", g1);
                    cmd.Parameters.AddWithValue("b2", b2);
                    cmd.Parameters.AddWithValue("g2", g2);
                    cmd.Parameters.AddWithValue("b3", b3);
                    cmd.Parameters.AddWithValue("g3", g3);
                    cmd.Parameters.AddWithValue("b4", b4);
                    cmd.Parameters.AddWithValue("g4", g4);
                    cmd.Parameters.AddWithValue("b5", b5);
                    cmd.Parameters.AddWithValue("g5", g5);
                    cmd.Parameters.AddWithValue("b6", b6);
                    cmd.Parameters.AddWithValue("g6", g6);
                    cmd.Parameters.AddWithValue("b7", b7);
                    cmd.Parameters.AddWithValue("g7", g7);
                    cmd.Parameters.AddWithValue("b8", b8);
                    cmd.Parameters.AddWithValue("g8", g8);
                    cmd.Parameters.AddWithValue("b9", b9);
                    cmd.Parameters.AddWithValue("g9", g9);
                    cmd.Parameters.AddWithValue("total", total);
                    cmd.Parameters.AddWithValue("total_overall", total_overall);



                    cmd.ExecuteNonQuery();

                   // MessageBox.Show("Record Saved!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        

    }
}
