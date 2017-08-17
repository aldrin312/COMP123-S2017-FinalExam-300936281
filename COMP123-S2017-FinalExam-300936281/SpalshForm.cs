using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Aldrin Fernandez
 * Date: Aug 17, 2017
 * StudentID: 300936281
 * Description: This is the SplashFormClass
 * Version: Created the Form and Instantiate the PickHighestCardForm from this form
 */
namespace COMP123_S2017_FinalExam_300936281
{

    public partial class SplashForm : Form
    {
        public PickHighestCardForm pickHighestCardForm
        {

            get
            {
                return Program.pickHighestCardForm;
            }

        }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pickHighestCardForm.Show();

            this.Hide();

            SplashFormTimer.Enabled = false; 
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
