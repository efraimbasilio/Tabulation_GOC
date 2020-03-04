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
    public partial class frmMainClient : Form
    {
        public string EventName; //Current Event Selected in the Server
        public int topFinalist;
        public int totalCandidates;
        public bool toSave;
        public string LockStatus;
        public string Judge;

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

        public frmMainClient()
        {
            InitializeComponent();
            No_of_Candidates();
            Current_Event();
            No_of_Finalist();

            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTop10 frm = new frmTop10();
            frm.Judge = cmbJudge.Text;
            this.Dispose();
            frm.ShowDialog();
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
                ////All_Event_DataGridView_Design();
                //timer1.Enabled = false;
                TimeTurnOn();
            }
            #endregion          
        }

        private void cmbJudge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
