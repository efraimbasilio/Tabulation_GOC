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
    public partial class frmLocked : Form
    {
        public string LockStatus;
        public frmLocked()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LockMe();
        }

        private void LockMe()
        {
            FormStatus frm = new FormStatus();
            List<FormStatus> lists = new List<FormStatus>();
            lists.Clear();
            lists = frm.Load();

            foreach (var item in lists)
            {
                LockStatus = item.Form_Status;
            }

            if (LockStatus.Equals("Inactive"))
            {
                //timer1.Enabled = false;              
                frmTop10 top = new frmTop10();
                top.TimeTurnOn();
                this.Close();
            }
        }
    }
}
