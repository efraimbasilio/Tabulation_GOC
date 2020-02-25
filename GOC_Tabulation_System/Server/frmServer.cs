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
        public void Desgin_LongGownOnly()
        {
            #region Design datagrid old
            //dgvPreElim.ColumnCount = 11;
            ////dgvPreElim.Columns[0].Name = "#";

            ////dgvPreElim.Columns[1].Name = "J1";
            ////dgvPreElim.Columns[2].Name = "J2";
            ////dgvPreElim.Columns[3].Name = "J3";
            ////dgvPreElim.Columns[4].Name = "J4";
            ////dgvPreElim.Columns[5].Name = "J5";
            ////dgvPreElim.Columns[6].Name = "J6";
            ////dgvPreElim.Columns[7].Name = "J7";
            ////dgvPreElim.Columns[8].Name = "J8";
            ////dgvPreElim.Columns[9].Name = "J9";
            ////dgvPreElim.Columns[10].Name = "Total";

            //dgvPreElim.Columns[0].Width = 50;
            //dgvPreElim.Columns[1].Width = 50;
            //dgvPreElim.Columns[2].Width = 50;
            //dgvPreElim.Columns[3].Width = 50;
            //dgvPreElim.Columns[4].Width = 50;
            //dgvPreElim.Columns[5].Width = 50;
            //dgvPreElim.Columns[6].Width = 50;
            //dgvPreElim.Columns[7].Width = 50;
            //dgvPreElim.Columns[8].Width = 50;
            //dgvPreElim.Columns[9].Width = 50;
            //dgvPreElim.Columns[10].Width = 50;
            //dgvPreElim.Columns[11].Width = 50;

            //for (int i = 1; i <= 18; i++)
            //{

            //    dgvPreElim.Rows.Add(i, "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00", "00.00");
            //}

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
            #endregion

            DataGridViewColumn id = dgvPreElim.Columns[0];
            DataGridViewColumn can_no = dgvPreElim.Columns[1];
            DataGridViewColumn j1 = dgvPreElim.Columns[2];
            DataGridViewColumn j2 = dgvPreElim.Columns[3];
            DataGridViewColumn j3 = dgvPreElim.Columns[4];
            DataGridViewColumn j4 = dgvPreElim.Columns[5];
            DataGridViewColumn j5 = dgvPreElim.Columns[6];
            DataGridViewColumn j6 = dgvPreElim.Columns[7];
            DataGridViewColumn j7 = dgvPreElim.Columns[8];
            DataGridViewColumn j8 = dgvPreElim.Columns[9];
            DataGridViewColumn j9 = dgvPreElim.Columns[10];
            DataGridViewColumn total = dgvPreElim.Columns[11];

            id.Visible = false;
            can_no.Width = 50;
            j1.Width = 50;
            j2.Width = 50;
            j3.Width = 50;
            j4.Width = 50;
            j5.Width = 50;
            j6.Width = 50;
            j7.Width = 50;
            j8.Width = 50;
            j9.Width = 50;
            total.Width = 50;
        }

        public void Design_LongGownAndBeauty()
        {

            DataGridViewColumn id = dgvPreElim.Columns[0];
            DataGridViewColumn can_no = dgvPreElim.Columns[1];
            DataGridViewColumn b1 = dgvPreElim.Columns[2];
            DataGridViewColumn g1 = dgvPreElim.Columns[3];
            DataGridViewColumn b2 = dgvPreElim.Columns[4];
            DataGridViewColumn g2 = dgvPreElim.Columns[5];
            DataGridViewColumn b3 = dgvPreElim.Columns[6];
            DataGridViewColumn g3 = dgvPreElim.Columns[7];
            DataGridViewColumn b4 = dgvPreElim.Columns[8];
            DataGridViewColumn g4 = dgvPreElim.Columns[9];
            DataGridViewColumn b5 = dgvPreElim.Columns[10];
            DataGridViewColumn g5 = dgvPreElim.Columns[11];
            DataGridViewColumn b6 = dgvPreElim.Columns[12];
            DataGridViewColumn g6 = dgvPreElim.Columns[13];
            DataGridViewColumn b7 = dgvPreElim.Columns[14];
            DataGridViewColumn g7 = dgvPreElim.Columns[15];
            DataGridViewColumn b8 = dgvPreElim.Columns[16];
            DataGridViewColumn g8 = dgvPreElim.Columns[17];
            DataGridViewColumn b9 = dgvPreElim.Columns[18];
            DataGridViewColumn g9 = dgvPreElim.Columns[19];
            DataGridViewColumn total = dgvPreElim.Columns[20];

            id.Visible = false;
            can_no.Width = 50;
            b1.Width = 50;
            g1.Width = 50;
            b2.Width = 50;
            g2.Width = 50;
            b3.Width = 50;
            g3.Width = 50;
            b4.Width = 50;
            g4.Width = 50;
            b5.Width = 50;
            g5.Width = 50;
            b6.Width = 50;
            g6.Width = 50;
            b7.Width = 50;
            g7.Width = 50;
            b8.Width = 50;
            g8.Width = 50;
            b9.Width = 50;
            g9.Width = 50;
            total.Width = 50;
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
                dgvPreElim.Rows[i].Cells[11].Value = 00.00;
                sum = 00.00;

                for (int y = 2; y <=11; y++)
                {
                    sum = sum + Convert.ToDouble(dgvPreElim.Rows[i].Cells[y].Value);                    
                }
                //To show the Computed Score in the last Column
                sum = sum / Convert.ToDouble(lblJudges.Text);
                dgvPreElim.Rows[i].Cells[11].Value = sum.ToString("n");
            }

           
            //this.dgvPreElim.Sort(this.dgvPreElim.Columns["TOTAL"], ListSortDirection.Descending); // To Sort the computed Score
        }

        private void Compute_PreElim()
        {
            double sum = 00.00;
            for (int i = 0; i < dgvSemiFinal.RowCount; i++)
            {
                //clear
                dgvSemiFinal.Rows[i].Cells[7].Value = 00.00;
                sum = 00.00;

                for (int y = 2; y <= 7; y++)
                {
                    sum = sum + Convert.ToDouble(dgvSemiFinal.Rows[i].Cells[y].Value);

                }
                //To show the Computed Score in the last Column               
                dgvSemiFinal.Rows[i].Cells[7].Value = sum.ToString("n");                              
            }
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
        private void Design_TOP10()
        {

            DataGridViewColumn id = dgvTOP10.Columns[0];
            DataGridViewColumn can_no = dgvTOP10.Columns[1];
            DataGridViewColumn b1 = dgvTOP10.Columns[2];
            DataGridViewColumn w1 = dgvTOP10.Columns[3];
            DataGridViewColumn b2 = dgvTOP10.Columns[4];
            DataGridViewColumn w2 = dgvTOP10.Columns[5];
            DataGridViewColumn b3 = dgvTOP10.Columns[6];
            DataGridViewColumn w3 = dgvTOP10.Columns[7];
            DataGridViewColumn b4 = dgvTOP10.Columns[8];
            DataGridViewColumn w4 = dgvTOP10.Columns[9];
            DataGridViewColumn b5 = dgvTOP10.Columns[10];
            DataGridViewColumn w5 = dgvTOP10.Columns[11];
            DataGridViewColumn b6 = dgvTOP10.Columns[12];
            DataGridViewColumn w6 = dgvTOP10.Columns[13];
            DataGridViewColumn b7 = dgvTOP10.Columns[14];
            DataGridViewColumn w7 = dgvTOP10.Columns[15];
            DataGridViewColumn b8 = dgvTOP10.Columns[16];
            DataGridViewColumn w8 = dgvTOP10.Columns[17];
            DataGridViewColumn b9 = dgvTOP10.Columns[18];
            DataGridViewColumn w9 = dgvTOP10.Columns[19];
            DataGridViewColumn total = dgvTOP10.Columns[20];

            id.Visible = false;
            can_no.Width = 50;
            b1.Width = 50;
            w1.Width = 50;
            b2.Width = 50;
            w2.Width = 50;
            b3.Width = 50;
            w3.Width = 50;
            b4.Width = 50;
            w4.Width = 50;
            b5.Width = 50;
            w5.Width = 50;
            b6.Width = 50;
            w6.Width = 50;
            b7.Width = 50;
            w7.Width = 50;
            b8.Width = 50;
            w8.Width = 50;
            b9.Width = 50;
            w9.Width = 50;
            total.Width = 50;

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

        public void Desgin_Elimination()
        {           
            DataGridViewColumn id = dgvSemiFinal.Columns[0];
            DataGridViewColumn can_no = dgvSemiFinal.Columns[1];
            DataGridViewColumn beauty_face_body = dgvSemiFinal.Columns[2];
            DataGridViewColumn talent = dgvSemiFinal.Columns[3];
            DataGridViewColumn swimsuit = dgvSemiFinal.Columns[4];
            DataGridViewColumn gown = dgvSemiFinal.Columns[5];
            DataGridViewColumn overall_impact = dgvSemiFinal.Columns[6];
            DataGridViewColumn total = dgvSemiFinal.Columns[7];

            id.Visible = false;
            can_no.Width = 50;
            beauty_face_body.Width = 50;
            talent.Width = 50;
            swimsuit.Width = 50;
            gown.Width = 50;
            overall_impact.Width = 50;
            total.Width = 50;                      
        }

        public frmServer()
        {
            InitializeComponent();
            LoadJudgeAndCandidates();

            util.LoadDataTable(dgvSemiFinal, "pre_elim");
            Desgin_Elimination();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
                    
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Compute_LongGownOnly();

            ServerScores score = new ServerScores();
            PreElimination elim = new PreElimination();
            for (int i = 0; i < dgvPreElim.Rows.Count; i++)
            {
                score.Can_no = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[1].Value.ToString());
                score.J1 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[2].Value.ToString());
                score.J2 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[3].Value.ToString());
                score.J3 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[4].Value.ToString());
                score.J4 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[5].Value.ToString());
                score.J5 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[6].Value.ToString());
                score.J6 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[7].Value.ToString());
                score.J7 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[8].Value.ToString());
                score.J8 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[9].Value.ToString());
                score.J9 = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[10].Value.ToString());
                score.Total = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[11].Value.ToString());

                //MessageBox.Show("NO # " + dgvPreElim.Rows[i].Cells[1].Value.ToString() + " SCORE: "+ dgvPreElim.Rows[i].Cells[11].Value.ToString());

                score.Update();

                elim.Can_no = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[1].Value.ToString());
                elim.Gown = string.Format("{0:0.00}", dgvPreElim.Rows[i].Cells[11].Value.ToString());

                elim.Update_Long_Gown();
               // MessageBox.Show("AA", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Load Elim
            util.LoadDataTable(dgvSemiFinal, "pre_elim");
            Desgin_Elimination();

            btnSubmitSemi.PerformClick();
        } 
           

        private void btnSubmitSemi_Click(object sender, EventArgs e)
        {
            //Compute Elim and Load Record
            PreElimination score = new PreElimination();
            Compute_PreElim(); 
                                   
            for (int i = 0; i < dgvSemiFinal.Rows.Count; i++)
            {               
                score.Can_no = string.Format("{0:0.00}", dgvSemiFinal.Rows[i].Cells[1].Value.ToString());
                score.Beauty_face_body = string.Format("{0:0.00}", dgvSemiFinal.Rows[i].Cells[2].Value.ToString());
                score.Talent = string.Format("{0:0.00}", dgvSemiFinal.Rows[i].Cells[3].Value.ToString());
                score.Swimsuit = string.Format("{0:0.00}", dgvSemiFinal.Rows[i].Cells[4].Value.ToString());
                score.Gown = string.Format("{0:0.00}", dgvSemiFinal.Rows[i].Cells[5].Value.ToString());
                score.Overall_impact = string.Format("{0:0.00}", dgvSemiFinal.Rows[i].Cells[6].Value.ToString());
                score.Total = string.Format("{0:0.00}", dgvSemiFinal.Rows[i].Cells[7].Value.ToString());

                score.Update();               
            }

            util.LoadDataTable(dgvSemiFinal, "pre_elim");
            Desgin_Elimination();
        }

        private void dgvSemiFinal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            util.NoBlankScore(dgvSemiFinal);
            util.AllScore_To_Decimal(dgvSemiFinal,7,2);

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
            util.AllScore_To_Decimal(dgvPreElim, 11, 2);
        }


        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //frmTop10 top = new frmTop10();

            //top.EventName = cmbEvents.Text;
            //top.topFinalist = Convert.ToInt32(lblNoSemiFinalist.Text);
            //top.totalCandidates = Convert.ToInt32(lblCandidates.Text);

            //top.All_Event_DataGridView_Design();
            //top.ShowDialog();

            if (cmbEvents.Text.Equals("Long Gown Only"))
            {               
                util.LoadDataTable(dgvPreElim, "long_gown");
                util.LoadDataTable(dgvSemiFinal, "pre_elim");

                Desgin_Elimination();
                Desgin_LongGownOnly(); 
            }
            else if(cmbEvents.Text.Equals("Long Gown with Beauty Face"))
            {
                util.LoadDataTable(dgvPreElim, "beauty_and_long_gown");
                Design_LongGownAndBeauty();
            }

            else if (cmbEvents.Text.Equals("Semi Final - Q and A"))
            {
                util.LoadDataTable(dgvTOP10, "semi_final");
                Design_TOP10();
            }

            else if (cmbEvents.Text.Equals("Final - Q and A"))
            {
                util.LoadDataTable(dgvTOP10, "final");
                Design_TOP10();
            }

        }
    }
}

