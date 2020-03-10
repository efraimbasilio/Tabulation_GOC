using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class Utilities
    {

        public bool toSave;
        public void LoadDataTable(DataGridView dgv , string tableName)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(GOC_Tabulation_System.Config.GetConnectionString()))
                {
                    con.Open();
                    
                    string sql = string.Concat("SELECT * FROM " + tableName + " ORDER BY total DESC");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;

                    //initialize new datatable
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR : " + ex.Message.ToString(), "GOCINFOSYS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NoBlankScore(DataGridView dgv)
        {
            foreach (DataGridViewRow rw in dgv.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        //MessageBox.Show("No Empty grades");
                        rw.Cells[i].Value = "00.00";
                        rw.Cells[i].Selected = true;

                        break;
                    }
                }
            }
        }
        
        public void NoZeroScore(DataGridView dgv)
        {
            
            foreach (DataGridViewRow rw in dgv.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value.Equals("00.00"))
                    {                        
                        rw.Cells[i].Selected = true;
                        
                        return;
                    }
                   // toSave = false;
                }
            }
            toSave = true;
        }

        public void ScoreValidator_BEAUTY(DataGridView dgv, int minimum_score ,int maximum_score)
        {
            foreach (DataGridViewRow Myrow in dgv.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume                
                if (Convert.ToDouble(Myrow.Cells[1].Value) < minimum_score)// Or your condition 
                {
                    Myrow.Cells[1].Value = "00.00";
                    
                }
                else if (Convert.ToDouble(Myrow.Cells[1].Value) > maximum_score)                               
                {
                    Myrow.Cells[1].Value = "00.00";
                    
                }
                else
                {
                    double a = Convert.ToDouble(Myrow.Cells[1].Value.ToString());
                    Myrow.Cells[1].Value = a.ToString("n");                    
                }
            }
        }

        public void ScoreValidator_WIT_INT(DataGridView dgv, int minimum_score, int maximum_score)
        {
            foreach (DataGridViewRow Myrow in dgv.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume                
                if (Convert.ToDouble(Myrow.Cells[2].Value) < minimum_score)// Or your condition 
                {
                    Myrow.Cells[2].Value = "00.00";                   
                }
                else if (Convert.ToDouble(Myrow.Cells[2].Value) > maximum_score)
                {
                    Myrow.Cells[2].Value = "00.00";                    
                }
                else
                {
                    double a = Convert.ToDouble(Myrow.Cells[2].Value.ToString());
                    Myrow.Cells[2].Value = a.ToString("n");                   
                }
            }
        }

        public void ScoreValidator_LONG_GOWN_ONLY(DataGridView dgv, int minimum_score, int maximum_score)
        {
            foreach (DataGridViewRow Myrow in dgv.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume                
                if (Convert.ToDouble(Myrow.Cells[1].Value) < minimum_score)// Or your condition 
                {
                    Myrow.Cells[1].Value = "00.00";                   
                }
                else if (Convert.ToDouble(Myrow.Cells[1].Value) > maximum_score)
                {
                    Myrow.Cells[1].Value = "00.00";                   
                }
                else
                {
                    double a = Convert.ToDouble(Myrow.Cells[1].Value.ToString());
                    Myrow.Cells[1].Value = a.ToString("n");
                   
                }
            }
        }

        public void Score_To_Decimal(DataGridView dgv)
        {
            foreach (DataGridViewRow Myrow in dgv.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume                
                for (int i = 2; i < 7; i++)
                {
                    double a = Convert.ToDouble(Myrow.Cells[i].Value.ToString());
                    Myrow.Cells[i].Value = a.ToString("n");
                }                                   
            }
        }

        public void AllScore_To_Decimal(DataGridView dgv, int no_of_column, int start_column)
        {
            foreach (DataGridViewRow Myrow in dgv.Rows)
            {   //Here 2 cell is target value and 1 cell is Volume                
                for (int i = 2; i < no_of_column; i++)
                {
                    double a = Convert.ToDouble(Myrow.Cells[i].Value.ToString());
                    Myrow.Cells[i].Value = a.ToString("n");
                }
            }
        }

        
    }
}
