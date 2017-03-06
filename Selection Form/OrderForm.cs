using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Movie_Bonanza
{
    public partial class OrderForm : Form
    {
        //it will store the total amount spend on the movie
        public string storingGrandTotal;

        //3. create a reference to the previous form
        public selectionForm previousForm;

        //constructor
        public OrderForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// this event handler will close the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// this event handler will print a message for the selection of movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(previousForm.stroingValues[0] + " of category " + previousForm.stroingValues[1] + " will cost you for " + previousForm.stroingValues[2], "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        /// <summary>
        /// this event handler tells about the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderAboutBox aboutApp = new orderAboutBox();
            aboutApp.ShowDialog();
        }

        /// <summary>
        /// this event handler will check whether the checkbox is checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _orderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            additionalLabel.Visible = true;
            additionalTextBox.Visible = true;

            if (!orderCheckBox.Checked)
            {
                additionalLabel.Visible = false;
                additionalTextBox.Visible = false;
            }
            _storedVales();
        }

        /// <summary>
        /// this event handler will take you to the selection form with the same selection and values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _backButton_Click(object sender, EventArgs e)
        {

            previousForm.Show();
            this.Hide();

        }

        //this method will show the values for title, category, cost and picture as per the 
        //selection done in selection form and also it will calculate the total amount
        public void _storedVales()
        {
            titleTextBox.Text = previousForm.stroingValues[0];
            categoryTextBox.Text = previousForm.stroingValues[1];
            costTextBox.Text = previousForm.stroingValues[2];
            moviePictureBox.Image = previousForm.pictureMovie;

            if (orderCheckBox.Checked)
            {
                subTotalTextBox.Text = (double.Parse(additionalTextBox.Text.Remove(0, 1)) + double.Parse(costTextBox.Text.Remove(0, 1))).ToString();
                subTotalTextBox.Text = Double.Parse(subTotalTextBox.Text).ToString("C", CultureInfo.CurrentCulture);
            }
            else
            {
                subTotalTextBox.Text = (double.Parse(costTextBox.Text.Remove(0, 1))).ToString();
                subTotalTextBox.Text = Double.Parse(subTotalTextBox.Text).ToString("C", CultureInfo.CurrentCulture);
            }

            salesTaxTextBox.Text = (double.Parse(subTotalTextBox.Text.Remove(0, 1)) * 13 / 100).ToString();
            salesTaxTextBox.Text = Double.Parse(salesTaxTextBox.Text).ToString("C", CultureInfo.CurrentCulture);
            grandTotalTextBox.Text = (double.Parse(subTotalTextBox.Text.Remove(0, 1)) + (double.Parse(salesTaxTextBox.Text.Remove(0, 1)))).ToString();
            grandTotalTextBox.Text = Double.Parse(grandTotalTextBox.Text).ToString("C", CultureInfo.CurrentCulture);
            storingGrandTotal = grandTotalTextBox.Text;
        }

        /// <summary>
        /// this event handler will take you to the next form which is stream form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _streamButton_Click(object sender, EventArgs e)
        {
            
            //1. intantiate 
            streamForm streamForm = new streamForm();

            //2. pass a reference to the 
            streamForm.secondForm = this;

            streamForm.firstForm = this.previousForm;
            streamForm.Show();
            this.Hide();
            streamForm._notifyLabels();
        }
    }
}
