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
        
        protected string b1;
        protected string w1;
        protected string b2;
        protected string w2;
        protected string b3;
        protected string w3;
        protected string b4;
        protected string w4;
        protected string b5;
        protected string w5;
        protected string b6;
        protected string w6;
        protected string b7;
        protected string w7;
        protected string b8;
        protected string w8;
        protected string b9;
        protected string w9;
        protected string total;
       
        public string B1 { get { return b1; } set { b1 = value; } }
        public string W1 { get { return w1; } set { w1 = value; } }
        public string B2 { get { return b2; } set { b2 = value; } }
        public string W2 { get { return w2; } set { w2 = value; } }
        public string B3 { get { return b3; } set { b3 = value; } }
        public string W3 { get { return w3; } set { w3 = value; } }
        public string B4 { get { return b4; } set { b4 = value; } }
        public string W4 { get { return w4; } set { w4 = value; } }
        public string B5 { get { return b5; } set { b5 = value; } }
        public string W5 { get { return w5; } set { w5 = value; } }
        public string B6 { get { return b6; } set { b6 = value; } }
        public string W6 { get { return w6; } set { w6 = value; } }
        public string B7 { get { return b7; } set { b7 = value; } }
        public string W7 { get { return w7; } set { w7 = value; } }
        public string B8 { get { return b8; } set { b8 = value; } }
        public string W8 { get { return w8; } set { w8 = value; } }
        public string B9 { get { return b9; } set { b9 = value; } }
        public string W9 { get { return w9; } set { w9 = value; } }
        public string Total { get { return total; } set { total = value; } }



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

        //public void Save()
        //{
        //    try
        //    {
        //        //prepare connection string 
        //        using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
        //        {

        //            //try to open connection
        //            con.Open();

        //            //string sql = "UPDATE long_gown SET  j1=@score WHERE can_no=@can_no;";
        //            string sql = string.Concat("UPDATE long_gown SET " + "j" + judge + " = @score WHERE can_no=@can_no;");


        //            MySqlCommand cmd = new MySqlCommand(sql, con);

        //            cmd.Parameters.AddWithValue("can_no", can_no);
        //            cmd.Parameters.AddWithValue("score", score);
        //            cmd.Parameters.AddWithValue("judge", judge);


        //            cmd.ExecuteNonQuery();

        //            //MessageBox.Show("Recorde Updated!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //}

        public void Insert_Top_10()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "INSERT INTO semi_final(can_no,b1,w1,b2,w2,b3,w3,b4,w4,b5,w5,b6,w6,b7,w7,b8,w8,b9,w9,total) " +
                                    " VALUES (@can_no,@b1,@w1,@b2,@w2,@b3,@w3,@b4,@w4,@b5,@w5,@b6,@w6,@b7,@w7,@b8,@w8,@b9,@w9,@total);";                    

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("can_no", can_no);
                    cmd.Parameters.AddWithValue("b1", b1);
                    cmd.Parameters.AddWithValue("w1", w1);
                    cmd.Parameters.AddWithValue("b2", b2);
                    cmd.Parameters.AddWithValue("w2", w2);
                    cmd.Parameters.AddWithValue("b3", b3);
                    cmd.Parameters.AddWithValue("w3", w3);
                    cmd.Parameters.AddWithValue("b4", b4);
                    cmd.Parameters.AddWithValue("w4", w4);
                    cmd.Parameters.AddWithValue("b5", b5);
                    cmd.Parameters.AddWithValue("w5", w5);
                    cmd.Parameters.AddWithValue("b6", b6);
                    cmd.Parameters.AddWithValue("w6", w6);
                    cmd.Parameters.AddWithValue("b7", b7);
                    cmd.Parameters.AddWithValue("w7", w7);
                    cmd.Parameters.AddWithValue("b8", b8);
                    cmd.Parameters.AddWithValue("w8", w8);
                    cmd.Parameters.AddWithValue("b9", b9);
                    cmd.Parameters.AddWithValue("w9", w9);
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



    }
}
