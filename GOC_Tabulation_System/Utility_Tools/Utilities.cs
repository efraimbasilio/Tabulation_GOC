using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    class Utilities
    {


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
                        break;
                    }
                }
            }

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

    }
}
