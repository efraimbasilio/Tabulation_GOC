﻿using System;
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
        #endregion

        public frmServer()
        {
            InitializeComponent();         
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            Datagrid_LongGownOnly();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          
        }
    }
}
