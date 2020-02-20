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
        public int topFinalist = 10;
        public int totalCandidates = 18;

        //public int _minScore_BEAUTY = 30, _maxScore_BEAUTY = 60, _minScore_WIT_INT = 20, _maxScore_WIT_INT = 40;

        Utilities util = new Utilities();

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

            else if (EventName.Equals("Long Gown with Beauty Face"))
            {
                #region Design Code For TOP 10
                lblEvent.Text = EventName;

                //Header Contetnt
                dgvAllEvent.ColumnCount = 3;
                dgvAllEvent.Columns[0].Name = "#";
                dgvAllEvent.Columns[1].Name = "Beauty of Face and Body Proportion [25 - 13]";
                dgvAllEvent.Columns[2].Name = "Long Gown Competition [25 - 13]";
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
                //Need Modification
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
        
        public frmTop10()
        {
            InitializeComponent();                      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void frmTop10_Load(object sender, EventArgs e)
        {
                       
        }
       
        private void dgvAllEvent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //STATIC VALUES
            if (EventName.Equals("Semi Final - Q and A"))
            {
                //STATIC VALUES
                int _minScore_BEAUTY = 30, _maxScore_BEAUTY = 60, _minScore_WIT_INT = 20, _maxScore_WIT_INT = 40; 
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

            else if (EventName.Equals("Final - Q and A"))
            {
                //STATIC VALUES
                int _minScore_BEAUTY = 35, _maxScore_BEAUTY = 70, _minScore_WIT_INT = 15, _maxScore_WIT_INT = 30;
                util.NoBlankScore(dgvAllEvent);
                util.ScoreValidator_BEAUTY(dgvAllEvent, _minScore_BEAUTY, _maxScore_BEAUTY);
                util.ScoreValidator_WIT_INT(dgvAllEvent, _minScore_WIT_INT, _maxScore_WIT_INT);
            }

            else if (EventName.Equals("Long Gown with Beauty Face"))
            {
                //STATIC VALUES
                int _minScore_BEAUTY = 13, _maxScore_BEAUTY = 25, _minScore_WIT_INT = 13, _maxScore_WIT_INT = 25;
                util.NoBlankScore(dgvAllEvent);
                util.ScoreValidator_BEAUTY(dgvAllEvent, _minScore_BEAUTY, _maxScore_BEAUTY);
                util.ScoreValidator_WIT_INT(dgvAllEvent, _minScore_WIT_INT, _maxScore_WIT_INT);
            }

            else if (EventName.Equals("Long Gown Only"))
            { 
                //STATIC VALUES
                int _minScore = 13, _maxScore= 25;
                util.ScoreValidator_LONG_GOWN_ONLY(dgvAllEvent, _minScore, _maxScore);
            }


        }
    }
}
