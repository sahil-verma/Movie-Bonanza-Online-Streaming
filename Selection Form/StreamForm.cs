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
    public partial class streamForm : Form
    {
        public selectionForm firstForm;
        //3. create a reference to the previous form
        public OrderForm secondForm;

        public streamForm()
        {
            InitializeComponent();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void _notifyLabels()
        {

            notifyCreditLabel.Text = "Your Credit card  will be charged " + secondForm.storingGrandTotal;
            notifyMovieLabel.Text = firstForm.stroingValues[0] + " will begin streaming shortly";
        }
    }
}
