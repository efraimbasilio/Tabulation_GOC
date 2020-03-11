using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class PreElimination
    {
        protected int id;
        protected string can_no;
        protected string beauty_face_body;
        protected string talent;
        protected string swimsuit;
        protected string gown;
        protected string overall_impact;
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

        public string Beauty_face_body
        {
            get { return beauty_face_body; }
            set { beauty_face_body = value; }
        }

        public string Talent
        {
            get { return talent; }
            set { talent = value; }
        }

        public string Swimsuit
        {
            get { return swimsuit; }
            set { swimsuit = value; }
        }

        public string Gown
        {
            get { return gown; }
            set { gown = value; }
        }

        public string Overall_impact
        {
            get { return overall_impact; }
            set { overall_impact = value; }
        }

        public string Total
        {
            get { return total; }
            set { total = value; }
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

                    string sql = "UPDATE pre_elim SET beauty_face_body=@beauty_face_body,talent=@talent,swimsuit=@swimsuit,gown=@gown,overall_impact=@overall_impact ,total=@total " +
                                    "WHERE can_no= @can_no;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("can_no", can_no);
                    cmd.Parameters.AddWithValue("beauty_face_body", beauty_face_body);
                    cmd.Parameters.AddWithValue("talent", talent);
                    cmd.Parameters.AddWithValue("swimsuit", swimsuit);
                    cmd.Parameters.AddWithValue("gown", gown);
                    cmd.Parameters.AddWithValue("overall_impact", overall_impact);
                    cmd.Parameters.AddWithValue("total", total);
                 
                    cmd.ExecuteNonQuery();                    
                }
               //MessageBox.Show("Recorde Updated!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Update_Long_Gown()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE pre_elim SET gown=@gown " +
                                    "WHERE can_no= @can_no;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("can_no", can_no);                    
                    cmd.Parameters.AddWithValue("gown", gown);                                      
                    cmd.ExecuteNonQuery();
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public void Update_Over_All()
        {
            try
            {
                //prepare connection string 
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {

                    //try to open connection
                    con.Open();

                    string sql = "UPDATE pre_elim SET overall_impact=@overall_impact " +
                                    "WHERE can_no= @can_no;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("can_no", can_no);
                    cmd.Parameters.AddWithValue("overall_impact", overall_impact);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
