using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Movie_Bonanza
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void splashFormTimer_Tick(object sender, EventArgs e)
        {
            //1. intantiate 
            selectionForm selectionForm = new selectionForm();

            this.splashFormTimer.Enabled = false;
            selectionForm.Show();
            this.Hide();
        }
    }
}
