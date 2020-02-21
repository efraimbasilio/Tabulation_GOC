using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    public partial class frmServer : Form
    {
        Judges j = new Judges();
        Candidates c = new Candidates();

        List<Judges> js = new List<Judges>();
        List<Candidates> cs = new List<Candidates>();

        Utilities util = new Utilities();

        #region Functions

        
       
        public void LoadJudgeAndCandidates()
        {
            //Get the number of Judges
            js.Clear();           
            js = j.Load();

            foreach (var item in js)
            {
                lblJudges.Text = item.Judge;
            }

            //Get the number of Candidates
            cs.Clear();
            cs = c.Load();

            foreach (var item in cs)
            {
                lblCandidates.Text = item.Candidate;
            }


        }
        #endregion

        #region LongGown PreElim
        public void Datagrid_LongGownOnly()
        {

            dgvPreElim.ColumnCount = 11;
            dgvPreElim.Columns[0].Name = "#";

            dgvPreElim.Columns[1].Name = "J1";
            dgvPreElim.Columns[2].Name = "J2";
            dgvPreElim.Columns[3].Name = "J3";
            dgvPreElim.Columns[4].Name = "J4";
            dgvPreElim.Columns[5].Name = "J5";
            dgvPreElim.Columns[6].Name = "J6";
            dgvPreElim.Columns[7].Name = "J7";
            dgvPreElim.Columns[8].Name = "J8";
            dgvPreElim.Columns[9].Name = "J9";
            dgvPreElim.Columns[10].Name = "Total";

            dgvPreElim.Columns[0].Width = 50;
            dgvPreElim.Columns[1].Width = 50;
            dgvPreElim.Columns[2].Width = 50;
            dgvPreElim.Columns[3].Width = 50;
            dgvPreElim.Columns[4].Width = 50;
            dgvPreElim.Columns[5].Width = 50;
            dgvPreElim.Columns[6].Width = 50;
            dgvPreElim.Columns[7].Width = 50;
            dgvPreElim.Columns[8].Width = 50;
            dgvPreElim.Columns[9].Width = 50;
            dgvPreElim.Columns[10].Width = 50;

            for (int i = 1; i <= 18; i++)
            {

                dgvPreElim.Rows.Add(i, "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00");
            }

            //ServerScores score = new ServerScores();
            //for (int i = 0; i < dgvPreElim.Rows.Count; i++)
            //{
            //    score.Can_no = dgvPreElim.Rows[i].Cells[0].Value.ToString();
            //    score.J1 = dgvPreElim.Rows[i].Cells[1].Value.ToString();
            //    score.J2 = dgvPreElim.Rows[i].Cells[2].Value.ToString();
            //    score.J3 = dgvPreElim.Rows[i].Cells[3].Value.ToString();
            //    score.J4 = dgvPreElim.Rows[i].Cells[4].Value.ToString();
            //    score.J5 = dgvPreElim.Rows[i].Cells[5].Value.ToString();
            //    score.J6 = dgvPreElim.Rows[i].Cells[6].Value.ToString();
            //    score.J7 = dgvPreElim.Rows[i].Cells[7].Value.ToString();
            //    score.J8 = dgvPreElim.Rows[i].Cells[8].Value.ToString();
            //    score.J9 = dgvPreElim.Rows[i].Cells[9].Value.ToString();
            //    score.Total = dgvPreElim.Rows[i].Cells[10].Value.ToString();

            //    score.Save();
            //}
            //MessageBox.Show("Record Long Gown Reseted!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ServerScores score = new ServerScores();
            //for (int i = 0; i < dgvPreElim.Rows.Count; i++)
            //{
            //    score.Can_no = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[0].Value.ToString());
            //    score.J1 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[1].Value.ToString());
            //    score.J2 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[2].Value.ToString());
            //    score.J3 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[3].Value.ToString());
            //    score.J4 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[4].Value.ToString());
            //    score.J5 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[5].Value.ToString());
            //    score.J6 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[6].Value.ToString());
            //    score.J7 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[7].Value.ToString());
            //    score.J8 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[8].Value.ToString());
            //    score.J9 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[9].Value.ToString());
            //    score.Total = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[10].Value.ToString());

            //    score.Update();
            //}
            //MessageBox.Show("Record Submitted!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Datagrid_LongGownAndBeauty()
        {

            dgvPreElim.ColumnCount = 20;
            dgvPreElim.Columns[0].Name = "#";

            dgvPreElim.Columns[1].Name = "B1";
            dgvPreElim.Columns[2].Name = "G1";
            dgvPreElim.Columns[3].Name = "B2";
            dgvPreElim.Columns[4].Name = "G2";
            dgvPreElim.Columns[5].Name = "B3";
            dgvPreElim.Columns[6].Name = "G3";
            dgvPreElim.Columns[7].Name = "B4";
            dgvPreElim.Columns[8].Name = "G4";
            dgvPreElim.Columns[9].Name = "B5";
            dgvPreElim.Columns[10].Name = "G5";
            dgvPreElim.Columns[11].Name = "B6";
            dgvPreElim.Columns[12].Name = "G6";
            dgvPreElim.Columns[13].Name = "B7";
            dgvPreElim.Columns[14].Name = "G7";
            dgvPreElim.Columns[15].Name = "B8";
            dgvPreElim.Columns[16].Name = "G8";
            dgvPreElim.Columns[17].Name = "B9";
            dgvPreElim.Columns[18].Name = "G9";
            dgvPreElim.Columns[19].Name = "TOTAL";

            dgvPreElim.Columns[0].Width = 50;
            dgvPreElim.Columns[1].Width = 50;
            dgvPreElim.Columns[2].Width = 50;
            dgvPreElim.Columns[3].Width = 50;
            dgvPreElim.Columns[4].Width = 50;
            dgvPreElim.Columns[5].Width = 50;
            dgvPreElim.Columns[6].Width = 50;
            dgvPreElim.Columns[7].Width = 50;
            dgvPreElim.Columns[8].Width = 50;
            dgvPreElim.Columns[9].Width = 50;
            dgvPreElim.Columns[10].Width = 50;
            dgvPreElim.Columns[11].Width = 50;
            dgvPreElim.Columns[12].Width = 50;
            dgvPreElim.Columns[13].Width = 50;
            dgvPreElim.Columns[14].Width = 50;
            dgvPreElim.Columns[15].Width = 50;
            dgvPreElim.Columns[16].Width = 50;
            dgvPreElim.Columns[17].Width = 50;
            dgvPreElim.Columns[18].Width = 50;
            dgvPreElim.Columns[19].Width = 50;

            for (int i = 1; i <= 18; i++)
            {

                dgvPreElim.Rows.Add(i, "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00");
            }
        }

        private void Submit_LongGownOnly()
        {
            //Submit Score to database
            for (int i = 0; i < dgvPreElim.RowCount; i++)
            {
                for (int y = 0; y < 11; y++)
                {
                    MessageBox.Show(dgvPreElim.Rows[i].Cells[y].Value.ToString());
                }

            }
        }

        private void Submit_LongGownAndBeauty()
        {
            //Submit Score to database
            for (int i = 0; i < dgvPreElim.RowCount; i++)
            {
                for (int y = 0; y < 20; y++)
                {
                    MessageBox.Show(dgvPreElim.Rows[i].Cells[y].Value.ToString());
                }

            }
        }

        private void Compute_LongGownOnly()
        {
            double sum = 00.00;
            for (int i = 0; i < dgvPreElim.RowCount; i++)
            {
                //clear
                dgvPreElim.Rows[i].Cells[10].Value = 00.00;
                sum = 00.00;

                for (int y = 1; y <=10; y++)
                {
                    sum = sum + Convert.ToDouble(dgvPreElim.Rows[i].Cells[y].Value);
                }
                //To show the Computed Score in the last Column
                dgvPreElim.Rows[i].Cells[10].Value = sum.ToString("n");
            }

           
            //this.dgvPreElim.Sort(this.dgvPreElim.Columns["TOTAL"], ListSortDirection.Descending); // To Sort the computed Score
        }
       
        #endregion

        #region ELIMINATION DATAGRID(TOP 10 or TOP 9)
        private void DataGrid_Semi_Final()
        {
            dgvSemiFinal.ColumnCount = 7; //Number of Columns to generate
            dgvSemiFinal.Columns[0].Name = "#";

            dgvSemiFinal.Columns[1].Name = "Talent";
            dgvSemiFinal.Columns[2].Name = "Swimsuit";
            dgvSemiFinal.Columns[3].Name = "OverAll Impact";
            dgvSemiFinal.Columns[4].Name = "Beauty of Face";
            dgvSemiFinal.Columns[5].Name = "Long Gown";       
            dgvSemiFinal.Columns[6].Name = "Total";

            dgvSemiFinal.Columns[0].Width = 50;
            dgvSemiFinal.Columns[1].Width = 50;
            dgvSemiFinal.Columns[2].Width = 50;
            dgvSemiFinal.Columns[3].Width = 50;
            dgvSemiFinal.Columns[4].Width = 50;
            dgvSemiFinal.Columns[5].Width = 50;
            dgvSemiFinal.Columns[6].Width = 50;
       

            for (int i = 1; i <= 18; i++)
            {

                dgvSemiFinal.Rows.Add(i, "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00");
            }
        }

        private void Submit_Semi_Final()
        {
            //Submit Score to database
            for (int i = 0; i < dgvSemiFinal.RowCount; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    MessageBox.Show(dgvSemiFinal.Rows[i].Cells[y].Value.ToString());
                }

            }
        }

        private void Compute_Semi_Final()
        {
            double sum = 00.00;
            for (int i = 0; i < dgvSemiFinal.RowCount; i++)
            {
                //clear
                dgvSemiFinal.Rows[i].Cells[6].Value = 00.00;
                sum = 00.00;

                for (int y = 1; y <=6; y++)
                {                  
                    sum = sum + Convert.ToDouble(dgvSemiFinal.Rows[i].Cells[y].Value);                                   
                }
                //To show the Computed Score in the last Column
                dgvSemiFinal.Rows[i].Cells[6].Value = sum.ToString("n");             
            }
            this.dgvSemiFinal.Sort(this.dgvSemiFinal.Columns["TOTAL"], ListSortDirection.Descending); // To Sort the computed Score
        }

        #endregion

        #region SEMI-FINAL - TO COMPUTE TOP 10
        private void DatagridDesignTOP10()
        {
            //dgvTOP10.ColumnCount = 20;
            //dgvTOP10.Columns[0].Name = "#";

            //dgvTOP10.Columns[1].Name = "B1";
            //dgvTOP10.Columns[2].Name = "W1";
            //dgvTOP10.Columns[3].Name = "B2";
            //dgvTOP10.Columns[4].Name = "W2";
            //dgvTOP10.Columns[5].Name = "B3";
            //dgvTOP10.Columns[6].Name = "W3";
            //dgvTOP10.Columns[7].Name = "B4";
            //dgvTOP10.Columns[8].Name = "W4";
            //dgvTOP10.Columns[9].Name = "B5";
            //dgvTOP10.Columns[10].Name = "W5";
            //dgvTOP10.Columns[11].Name = "B6";
            //dgvTOP10.Columns[12].Name = "W6";
            //dgvTOP10.Columns[13].Name = "B7";
            //dgvTOP10.Columns[14].Name = "W7";
            //dgvTOP10.Columns[15].Name = "B8";
            //dgvTOP10.Columns[16].Name = "W8";
            //dgvTOP10.Columns[17].Name = "B9";
            //dgvTOP10.Columns[18].Name = "W9";
            //dgvTOP10.Columns[19].Name = "TOTAL";
            Utilities util = new Utilities();
            util.LoadDataTable(dgvTOP10, "semi_final");

            dgvTOP10.Columns[0].Width = 50;
            dgvTOP10.Columns[1].Width = 50;
            dgvTOP10.Columns[2].Width = 50;
            dgvTOP10.Columns[3].Width = 50;
            dgvTOP10.Columns[4].Width = 50;
            dgvTOP10.Columns[5].Width = 50;
            dgvTOP10.Columns[6].Width = 50;
            dgvTOP10.Columns[7].Width = 50;
            dgvTOP10.Columns[8].Width = 50;
            dgvTOP10.Columns[9].Width = 50;
            dgvTOP10.Columns[10].Width = 50;
            dgvTOP10.Columns[11].Width = 50;
            dgvTOP10.Columns[12].Width = 50;
            dgvTOP10.Columns[13].Width = 50;
            dgvTOP10.Columns[14].Width = 50;
            dgvTOP10.Columns[15].Width = 50;
            dgvTOP10.Columns[16].Width = 50;
            dgvTOP10.Columns[17].Width = 50;
            dgvTOP10.Columns[18].Width = 50;
            dgvTOP10.Columns[19].Width = 50;


           
            //for (int i = 1; i <= 10; i++)
            //{

            //    dgvTOP10.Rows.Add(i, "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00");
            //}


        }

        private void Compute_TOP10()
        {
            double sum = 00.00;
            for (int i = 0; i < dgvTOP10.RowCount; i++)
            {
                //clear
                dgvTOP10.Rows[i].Cells[19].Value = 00.00;
                sum = 00.00;

                for (int y = 1; y <= 19; y++)
                {
                    sum = sum + Convert.ToDouble(dgvTOP10.Rows[i].Cells[y].Value);
                }
                //To show the Computed Score in the last Column
                dgvTOP10.Rows[i].Cells[19].Value = sum.ToString("n");
            }
           

        }
        #endregion

       

        public frmServer()
        {
            InitializeComponent();         
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            LoadJudgeAndCandidates();
            //Datagrid_LongGownOnly();
            DatagridDesignTOP10();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Compute_LongGownOnly();
            ServerScores score = new ServerScores();
            for (int i = 0; i < dgvPreElim.Rows.Count; i++)
            {
                score.Can_no = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[0].Value.ToString());
                score.J1 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[1].Value.ToString());
                score.J2 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[2].Value.ToString());
                score.J3 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[3].Value.ToString());
                score.J4 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[4].Value.ToString());
                score.J5 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[5].Value.ToString());
                score.J6 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[6].Value.ToString());
                score.J7 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[7].Value.ToString());
                score.J8 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[8].Value.ToString());
                score.J9 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[9].Value.ToString());
                score.Total = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[10].Value.ToString());

                score.Update();
            }
            MessageBox.Show("Record Submitted!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    

        private void btnSubmitSemi_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvSemiFinal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSubmitTOP_Click(object sender, EventArgs e)
        {
            SemiFinal semi = new SemiFinal();
            for (int i = 0; i < dgvTOP10.RowCount; i++)
            {
                semi.Can_no = dgvTOP10.Rows[i].Cells[0].Value.ToString();
                semi.B1 = dgvTOP10.Rows[i].Cells[1].Value.ToString();
                semi.W1 = dgvTOP10.Rows[i].Cells[2].Value.ToString();
                semi.B2 = dgvTOP10.Rows[i].Cells[3].Value.ToString();
                semi.W2 = dgvTOP10.Rows[i].Cells[4].Value.ToString();
                semi.B3 = dgvTOP10.Rows[i].Cells[5].Value.ToString();
                semi.W3 = dgvTOP10.Rows[i].Cells[6].Value.ToString();
                semi.B4 = dgvTOP10.Rows[i].Cells[7].Value.ToString();
                semi.W4 = dgvTOP10.Rows[i].Cells[8].Value.ToString();
                semi.B5 = dgvTOP10.Rows[i].Cells[9].Value.ToString();
                semi.W5 = dgvTOP10.Rows[i].Cells[10].Value.ToString();
                semi.B6 = dgvTOP10.Rows[i].Cells[11].Value.ToString();
                semi.W6 = dgvTOP10.Rows[i].Cells[12].Value.ToString();
                semi.B7 = dgvTOP10.Rows[i].Cells[13].Value.ToString();
                semi.W7 = dgvTOP10.Rows[i].Cells[14].Value.ToString();
                semi.B8 = dgvTOP10.Rows[i].Cells[15].Value.ToString();
                semi.W8 = dgvTOP10.Rows[i].Cells[16].Value.ToString();
                semi.B9 = dgvTOP10.Rows[i].Cells[17].Value.ToString();
                semi.W9 = dgvTOP10.Rows[i].Cells[18].Value.ToString();
                semi.Total = dgvTOP10.Rows[i].Cells[19].Value.ToString();

                semi.Save_Dummy_Semi();
            }
            MessageBox.Show("Record Saved!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPreviewTOP_Click(object sender, EventArgs e)
        {           
            dgvTOP10.Sort(dgvTOP10.Columns["TOTAL"], System.ComponentModel.ListSortDirection.Descending);
        }

        private void dgvTOP10_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSetting set = new frmSetting();
            set.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvPreElim_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region One decimal point only
        private void dgvPreElim_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {                  
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);           
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        #endregion

        private void dgvPreElim_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            util.NoBlankScore(dgvPreElim);
        }


        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmTop10 top = new frmTop10();

            top.EventName = cmbEvents.Text;
            top.topFinalist = Convert.ToInt32(lblNoSemiFinalist.Text);
            top.totalCandidates = Convert.ToInt32(lblCandidates.Text);

            top.All_Event_DataGridView_Design();
            top.ShowDialog();
        }
    }
}

