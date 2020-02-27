using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class Event
    {
        protected int id;
        protected string eventName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
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

                    string sql = "UPDATE event SET event_name=@eventName ";
                                    //"WHERE id= @id;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("eventName", eventName);                   
                   
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Event Updated!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
