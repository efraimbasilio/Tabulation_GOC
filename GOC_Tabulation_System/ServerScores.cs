using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class ServerScores
    {
        protected int id;
        protected string can_no;
        protected string j1;
        protected string j2;
        protected string j3;
        protected string j4;
        protected string j5;
        protected string j6;
        protected string j7;
        protected string j8;
        protected string j9;
        protected string total;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Can_no
        {
            get { return can_no; }
            set { can_no = value; }
        }

        public string J1
        {
            get { return j1; }
            set { j1 = value; }
        }

        public string J2
        {
            get { return j2; }
            set { j2 = value; }
        }

        public string J3
        {
            get { return j3; }
            set { j3 = value; }
        }

        public string J4
        {
            get { return j4; }
            set { j4 = value; }
        }

        public string J5
        {
            get { return j5; }
            set { j5 = value; }
        }

        public string J6
        {
            get { return j6; }
            set { j6 = value; }
        }

        public string J7
        {
            get { return j7; }
            set { j7 = value; }
        }

        public string J8
        {
            get { return j8; }
            set { j8 = value; }
        }

        public string J9
        {
            get { return j9; }
            set { j9 = value; }
        }

        public string Total
        {
            get { return total; }
            set { total = value; }
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

                    string sql = "INSERT INTO long_gown(can_no,j1,j2,j3,j4,j5,j6,j7,j8,j9,total) " +
                                    " VALUES (@can_no,@j1,@j2,@j3,@j4,@j5,@j6,@j7,@j8,@j9,@total);";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("can_no", can_no);
                    cmd.Parameters.AddWithValue("j1", j1);
                    cmd.Parameters.AddWithValue("j2", j2);
                    cmd.Parameters.AddWithValue("j3", j3);
                    cmd.Parameters.AddWithValue("j4", j4);
                    cmd.Parameters.AddWithValue("j5", j5);
                    cmd.Parameters.AddWithValue("j6", j6);
                    cmd.Parameters.AddWithValue("j7", j7);
                    cmd.Parameters.AddWithValue("j8", j8);
                    cmd.Parameters.AddWithValue("j9", j9);
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

                    string sql = "UPDATE long_gown SET can_no=@can_no, j1=@j1,j2=@j2,j3=@j3,j4=@j4,j5=@j5,j6=@j6,j7=@j7,j8=@j8,j9=@j9" +
                                    " WHERE can_no=@can_no;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    
                    cmd.Parameters.AddWithValue("can_no", can_no);
                    cmd.Parameters.AddWithValue("j1", j1);
                    cmd.Parameters.AddWithValue("j2", j2);
                    cmd.Parameters.AddWithValue("j3", j3);
                    cmd.Parameters.AddWithValue("j4", j4);
                    cmd.Parameters.AddWithValue("j5", j5);
                    cmd.Parameters.AddWithValue("j6", j6);
                    cmd.Parameters.AddWithValue("j7", j7);
                    cmd.Parameters.AddWithValue("j8", j8);
                    cmd.Parameters.AddWithValue("j9", j9);
                    cmd.Parameters.AddWithValue("total", total);

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
