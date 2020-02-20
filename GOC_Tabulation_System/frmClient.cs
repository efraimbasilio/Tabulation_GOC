using GOC_Tabulation_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_Tabulation_System
{
    public partial class frmClient : Form
    {
        Utilities util = new Utilities();
        public frmClient()
        {
            InitializeComponent();            
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 18; i++)
            {
                dataGridView1.Rows.Add(i,"0.00");
            }


            dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);

            ((DataGridViewTextBoxColumn)dataGridView1.Columns[1]).MaxInputLength = 5;
            ((DataGridViewTextBoxColumn)dataGridView1.Columns[1]).MaxInputLength = 5;
        }

        public void AddImageDataGrid(DataGridView dgv)
        {
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.close;
            dimg.HeaderText = "Close";
            dimg.ImageLayout = DataGridViewImageCellLayout.Normal;
            dimg.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns.Add(dimg);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {            
            int val = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            util.NoBlankScore(dataGridView1);
            util.InputToDouble(dataGridView1);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {           
            //control input for column 4
            e.Control.KeyPress -= new KeyPressEventHandler(colScores_KeyPress);

            //column to control input
            if ((dataGridView1.CurrentCell.ColumnIndex == 1))
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(colScores_KeyPress);
                    tb.KeyDown -= dataGridView1_KeyDown;
                    tb.KeyDown += dataGridView1_KeyDown;
                }
            }


        }

        private void colScores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            //if (e.Control && (e.KeyCode == Keys.C | e.KeyCode == Keys.V))
            //{
            //    e.SuppressKeyPress = true;
            //}

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                // cancel the "paste" function
                e.SuppressKeyPress = true;
            }
        }
    }
}
