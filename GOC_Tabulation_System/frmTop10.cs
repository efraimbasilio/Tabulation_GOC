﻿using MySql.Data.MySqlClient;
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
    public partial class frmTop10 : Form
    {       
        public string EventName; //Current Event Selected in the Server
        public int topFinalist;
        public int totalCandidates;
        public bool toSave;
        public string LockStatus;
        public string Judge;
       // public string Activate;

        //public int _minScore_BEAUTY = 30, _maxScore_BEAUTY = 60, _minScore_WIT_INT = 20, _maxScore_WIT_INT = 40;

        Utilities util = new Utilities();
        Event theEvent = new Event();
        Candidates can = new Candidates();
        Judges judge = new Judges();
        TopFinalists top = new TopFinalists();

        List<Candidates> listCandidates = new List<Candidates>();      
        List<Event> events = new List<Event>();
        List<TopFinalists> listTop = new List<TopFinalists>();

        public void No_of_Candidates()
        {
            listCandidates.Clear();

            listCandidates = can.Load();
            foreach (var item in listCandidates)
            {
                totalCandidates = Convert.ToInt32(item.Candidate);
            }
        }

        public void Current_Event()
        {           
            events.Clear();
            events = theEvent.Load();

            foreach (var item in events)
            {
                EventName = item.EventName;
            }                    
        }

        public void No_of_Finalist()
        {
            listTop.Clear();
            listTop = top.Load();

            foreach (var item in listTop)
            {
                topFinalist = Convert.ToInt32(item.FinalistsCount);
            }
        }

        #region DataGridView Input Validators
        private void dgvAllEvent_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //control input for column 
            e.Control.KeyPress -= new KeyPressEventHandler(colScores_KeyPress);

            //column to control input
            if ((dgvAllEvent.CurrentCell.ColumnIndex == 1))
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(colScores_KeyPress);
                    tb.KeyDown -= dgvAllEvent_KeyDown;
                    tb.KeyDown += dgvAllEvent_KeyDown;
                }
            }

        }
        private void colScores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void dgvAllEvent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                // cancel the "paste" function
                e.SuppressKeyPress = true;
            }
        }
        #endregion

        #region For Candidate Picture
        /// <summary>
        /// For Picture  of Candidate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAllEvent_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dgvAllEvent.Rows[e.RowIndex].Cells[0].Value.ToString());
            switch (val)
            {
                case 1:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._6;
                    break;

                case 7:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._7;
                    break;
                case 8:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._8;
                    break;
                case 9:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._9;
                    break;
                case 10:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._10;
                    break;
                case 11:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._11;
                    break;
                case 12:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._12;
                    break;
                case 13:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._13;
                    break;
                case 14:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._14;
                    break;
                case 15:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._15;
                    break;
                case 16:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._16;
                    break;
                case 17:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._17;
                    break;
                case 18:
                    pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources._18;
                    break;
            }
        }
        #endregion


        public void All_Event_DataGridView_Design()
        {           
            if (EventName.Equals("Semi Final - Q and A"))
            {
                #region Design Code For TOP 10
                lblEvent.Text = EventName;

                //Header Contetnt
                dgvAllEvent.ColumnCount = 3;
                dgvAllEvent.Columns[0].Name = "#";
                dgvAllEvent.Columns[1].Name = "Beauty of Face and Body Proportion [60 - 30]";
                dgvAllEvent.Columns[2].Name = "Wit and Intelligence [40 - 20]";
                //dgvAllEvent.Columns[3].Name = "Total Score";

                //Alignments
                dgvAllEvent.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllEvent.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllEvent.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;               

                //readonly Columns
                dgvAllEvent.Columns[0].ReadOnly = true;

                //Display Sizes
                dgvAllEvent.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAllEvent.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAllEvent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //dgvAllEvent.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //populate with default data
               
                for (int i = 1; i <= topFinalist; i++)
                {
                    dgvAllEvent.Rows.Add(i, "00.00", "00.00");
                }

                //Limit Input in datagrid
                ((DataGridViewTextBoxColumn)dgvAllEvent.Columns[1]).MaxInputLength = 5;
                ((DataGridViewTextBoxColumn)dgvAllEvent.Columns[2]).MaxInputLength = 5;
                #endregion
            }

            else if(EventName.Equals("Final - Q and A"))
            {
                #region Design Code For TOP 10
                lblEvent.Text = EventName;

                //Header Contetnt
                dgvAllEvent.ColumnCount = 3;
                dgvAllEvent.Columns[0].Name = "#";
                dgvAllEvent.Columns[1].Name = "Beauty of Face and Body Proportion [70 - 35]";
                dgvAllEvent.Columns[2].Name = "Wit and Intelligence [30 - 15]";
                //dgvAllEvent.Columns[3].Name = "Total Score";

                //Alignments
                dgvAllEvent.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllEvent.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllEvent.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //readonly Columns
                dgvAllEvent.Columns[0].ReadOnly = true;

                //Display Sizes
                dgvAllEvent.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAllEvent.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAllEvent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //dgvAllEvent.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //populate with default data
                for (int i = 1; i <= topFinalist; i++)
                {
                    dgvAllEvent.Rows.Add(i, "00.00", "00.00");
                }

                //Limit Input in datagrid
                ((DataGridViewTextBoxColumn)dgvAllEvent.Columns[1]).MaxInputLength = 5;
                ((DataGridViewTextBoxColumn)dgvAllEvent.Columns[2]).MaxInputLength = 5;
                #endregion
            }

            else if (EventName.Equals("Long Gown Competition"))
            {
                #region Design Code For TOP 10
                lblEvent.Text = EventName;

                //Header Contetnt
                dgvAllEvent.ColumnCount = 3;
                dgvAllEvent.Columns[0].Name = "#";
                dgvAllEvent.Columns[1].Name = "Overall Impact [10 - 5]";
                dgvAllEvent.Columns[2].Name = "Long Gown [25 - 13]";
                //dgvAllEvent.Columns[3].Name = "Total Score";

                //Alignments
                dgvAllEvent.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllEvent.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllEvent.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //readonly Columns
                dgvAllEvent.Columns[0].ReadOnly = true;

                //Display Sizes
                dgvAllEvent.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAllEvent.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAllEvent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //dgvAllEvent.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //populate with default data
                for (int i = 1; i <= totalCandidates; i++)
                {
                    dgvAllEvent.Rows.Add(i, "00.00", "00.00");
                }

                //Limit Input in datagrid
                ((DataGridViewTextBoxColumn)dgvAllEvent.Columns[1]).MaxInputLength = 5;
                ((DataGridViewTextBoxColumn)dgvAllEvent.Columns[2]).MaxInputLength = 5;
                #endregion
            }

            else if (EventName.Equals("Long Gown Only"))
            {
                //util.LoadDataTable(dgvAllEvent, "long_gown");

                #region Design Code For TOP 10
                lblEvent.Text = EventName;

                //Header Contetnt
                dgvAllEvent.ColumnCount = 2;
                dgvAllEvent.Columns[0].Name = "#";
                //dgvAllEvent.Columns[1].Name = "Beauty of Face and Body Proportion [25 - 13]";
                dgvAllEvent.Columns[1].Name = "Long Gown Competition [25 - 13]";
                //dgvAllEvent.Columns[3].Name = "Total Score";

                //Alignments
                dgvAllEvent.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvAllEvent.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAllEvent.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //dgvAllEvent.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvAllEvent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //readonly Columns
                dgvAllEvent.Columns[0].ReadOnly = true;

                //Display Sizes
                dgvAllEvent.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAllEvent.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //dgvAllEvent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //dgvAllEvent.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //populate with default data

                for (int i = 1; i <= totalCandidates; i++)
                {
                    dgvAllEvent.Rows.Add(i, "00.00");
                }

                //Limit Input in datagrid
                ((DataGridViewTextBoxColumn)dgvAllEvent.Columns[1]).MaxInputLength = 5;
                //((DataGridViewTextBoxColumn)dgvAllEvent.Columns[2]).MaxInputLength = 5;
                #endregion
            }
        }

        
        
        public void EventLoad()
        {
            //if (cmbEvents.Text.Equals("Long Gown Only"))
            //{                
            //    util.LoadDataTable(dgvAllEvent, "long_gown");
            //    //util.LoadDataTable(dgvSemiFinal, "pre_elim");

            //    Desgin_Elimination();
            //    Desgin_LongGownOnly();
            //}
        }

        public frmTop10()
        {
            InitializeComponent();
            No_of_Candidates();
            Current_Event();
            No_of_Finalist();

            Current_Event();
            All_Event_DataGridView_Design();
            timer1.Enabled = true;                 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void frmTop10_Load(object sender, EventArgs e)
        {
            lblJudgeNo.Text = Judge;
        }
       
        private void dgvAllEvent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
            //STATIC VALUES
            if (EventName.Equals("Semi Final - Q and A"))
            {
                //STATIC VALUES
               int _minScore_BEAUTY = 30, _maxScore_BEAUTY = 60, _minScore_WIT_INT = 20, _maxScore_WIT_INT = 40;
                util.NoBlankScore(dgvAllEvent);
                util.ScoreValidator_BEAUTY(dgvAllEvent, _minScore_BEAUTY, _maxScore_BEAUTY);
               util.ScoreValidator_WIT_INT(dgvAllEvent, _minScore_WIT_INT, _maxScore_WIT_INT);
            }
            else if (EventName.Equals("Final - Q and A"))
            {
                //STATIC VALUES
                int _minScore_BEAUTY = 35, _maxScore_BEAUTY = 70, _minScore_WIT_INT = 15, _maxScore_WIT_INT = 30;
                util.NoBlankScore(dgvAllEvent);
                util.ScoreValidator_BEAUTY(dgvAllEvent, _minScore_BEAUTY, _maxScore_BEAUTY);
                util.ScoreValidator_WIT_INT(dgvAllEvent, _minScore_WIT_INT, _maxScore_WIT_INT);
            }

            //else if (EventName.Equals("Final - Q and A"))
            //{
            //    //STATIC VALUES
            //    int _minScore_BEAUTY = 35, _maxScore_BEAUTY = 70, _minScore_WIT_INT = 15, _maxScore_WIT_INT = 30;
            //    util.NoBlankScore(dgvAllEvent);
            //    util.ScoreValidator_BEAUTY(dgvAllEvent, _minScore_BEAUTY, _maxScore_BEAUTY);
            //    util.ScoreValidator_WIT_INT(dgvAllEvent, _minScore_WIT_INT, _maxScore_WIT_INT);
            //}

            else if (EventName.Equals("Long Gown Competition"))
            {
                //STATIC VALUES
                int _minScore_BEAUTY = 5, _maxScore_BEAUTY = 10, _minScore_WIT_INT = 13, _maxScore_WIT_INT = 25;
                util.NoBlankScore(dgvAllEvent);
                util.ScoreValidator_BEAUTY(dgvAllEvent, _minScore_BEAUTY, _maxScore_BEAUTY);
                util.ScoreValidator_WIT_INT(dgvAllEvent, _minScore_WIT_INT, _maxScore_WIT_INT);
            }

            else if (EventName.Equals("Long Gown Only"))
            {

                util.NoBlankScore(dgvAllEvent);
               
                //STATIC VALUES
                int _minScore = 13, _maxScore= 25;
                util.ScoreValidator_LONG_GOWN_ONLY(dgvAllEvent, _minScore, _maxScore);
            }

        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            util.NoZeroScore(dgvAllEvent);

            if (util.toSave == true)
            {
                string message = "Please double check the scores before submitting ?";
                string title = "Tabulation System";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    string message2 = "Submit score now?";
                    string title2 = "Tabulation System";
                    MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                    DialogResult result2 = MessageBox.Show(message2, title2, buttons2, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        if (EventName.Equals("Long Gown Only"))
                        {
                            #region LongGownOnly
                            LongGownOnly score = new LongGownOnly();
                            for (int i = 0; i < dgvAllEvent.Rows.Count; i++)
                            {
                                score.Judge = lblJudgeNo.Text;//Judge No
                                score.Can_no = dgvAllEvent.Rows[i].Cells[0].Value.ToString();//Candidate Number    [0]
                                score.Score = dgvAllEvent.Rows[i].Cells[1].Value.ToString();//Score per candidate [1]
                                score.Save();
                            }
                            MessageBox.Show("Record Submitted!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            #endregion
                        }

                        else if (EventName.Equals("Semi Final - Q and A"))
                        {
                            #region SemiFinal
                            SemiFinal score = new SemiFinal();
                            for (int i = 0; i < dgvAllEvent.Rows.Count; i++)
                            {
                                score.Judge = lblJudgeNo.Text;//Judge No
                                score.Can_no = dgvAllEvent.Rows[i].Cells[0].Value.ToString();//Candidate Number    [0]
                                score.Score_beauty = dgvAllEvent.Rows[i].Cells[1].Value.ToString();//Score per candidate [1
                                score.Score_wit = dgvAllEvent.Rows[i].Cells[2].Value.ToString();//Score per candidate [1]

                                score.Save();
                            }
                            MessageBox.Show("Record Submitted!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            #endregion
                        }

                        else if (EventName.Equals("Final - Q and A"))
                        {
                            #region Final - Q and A
                            Final score = new Final();
                            for (int i = 0; i < dgvAllEvent.Rows.Count; i++)
                            {
                                score.Judge = lblJudgeNo.Text;//Judge No
                                score.Can_no = dgvAllEvent.Rows[i].Cells[0].Value.ToString();//Candidate Number    [0]
                                score.Score_beauty = dgvAllEvent.Rows[i].Cells[1].Value.ToString();//Score per candidate [1
                                score.Score_wit = dgvAllEvent.Rows[i].Cells[2].Value.ToString();//Score per candidate [1]

                                score.Save();
                            }
                            MessageBox.Show("Record Submitted!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            #endregion
                        }

                        else if (EventName.Equals("Long Gown Competition"))
                        {
                            #region Long Gown with Beauty Face

                            BeautyAndLongGown score = new BeautyAndLongGown();

                            for (int i = 0; i < dgvAllEvent.Rows.Count; i++)
                            {
                                score.Judge = lblJudgeNo.Text;//Judge No
                                score.Can_no = dgvAllEvent.Rows[i].Cells[0].Value.ToString();//Candidate Number    [0]
                                score.Score_beauty = dgvAllEvent.Rows[i].Cells[1].Value.ToString();//Score per candidate [1
                                score.Score_wit = dgvAllEvent.Rows[i].Cells[2].Value.ToString();//Score per candidate [1]

                                score.Save();
                            }
                            MessageBox.Show("Record Submitted!", "Tabulation System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            #endregion
                        }

                        this.Dispose();
                        frmMainClient main = new frmMainClient();
                        main.ShowDialog();
                    }
                    else
                    {
                        return;
                    }                    
                }
            }
            else
            {
                return;
            }
                     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            LockMe();          
        }
        public void TimeTurnOn()
        {
            timer1.Enabled = true;
        }
       
        private void LockMe()
        {            
            #region Form Lock
            FormStatus frm = new FormStatus();
                List<FormStatus> lists = new List<FormStatus>();
                lists.Clear();
                lists = frm.Load();

                foreach (var item in lists)
                {
                    LockStatus = item.Form_Status;
                }
            
                if (LockStatus.Equals("Active"))
                {
                    //off timer
                    timer1.Enabled = false;
                
                    //Show Lock Form
                    frmLocked frm2 = new frmLocked();
                    frm2.ShowDialog();
                  
                }
                else
                {

                //Current_Event();
                //All_Event_DataGridView_Design();
                timer1.Enabled = false;
            }
            #endregion          
        }

        
    }
}
