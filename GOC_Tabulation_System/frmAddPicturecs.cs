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
    public partial class frmAddPicturecs : Form
    {
        public frmAddPicturecs()
        {
            InitializeComponent();
        }
        String apppath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).ToString();
        private void frmAddPicturecs_Load(object sender, EventArgs e)
        {
            apppath = @"\\CLABSERVER\Users\Instructor\Desktop\GOC_Tabulation_System\Picture\";
            txtFromDB.Text = apppath;
            pictureBox1.ImageLocation = apppath + lrntxt.Text + ".jpg";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                string fullPath = opf.FileName;
                string fileName = opf.SafeFileName;
                string path = fullPath.Replace(fileName, "");

                txtPath.Text = path;//path name from browse file
                txtFileName.Text = fileName; // filename from browse

                //copy image*********************************************************************************
                string[] files = System.IO.Directory.GetFiles(txtPath.Text);

                foreach (string file in files)
                {
                    System.IO.File.Copy(txtPath.Text + txtFileName.Text, txtFromDB.Text + lrntxt.Text + ".jpg", true);
                    break;
                }
                //*******************************************************************************************
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"\\CLABSERVER\Users\Instructor\Desktop\GOC_Tabulation_System\Picture\"+ txtImage.Text +".jpg");
        }
    }
}
