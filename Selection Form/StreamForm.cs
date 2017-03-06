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
        //3. create a reference to the second form
        public selectionForm firstForm;

        //3. create a reference to the previous form
        public OrderForm secondForm;

        //constructor
        public streamForm()
        {
            InitializeComponent();
        }

        //this method will show the values of total from the order form and 
        //title of the movie from selection form
        public void _notifyLabels()
        {
            notifyCreditLabel.Text = "Your Credit card  will be charged " + secondForm.storingGrandTotal;
            notifyMovieLabel.Text = firstForm.stroingValues[0] + " will begin streaming shortly";
        }

        /// <summary>
        /// this event handler will close the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
