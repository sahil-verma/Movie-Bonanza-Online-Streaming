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
        
        //3. create a reference to the previous form
        public selectionForm previousForm;
        public OrderForm()
        {
            InitializeComponent();

        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the health", "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderAboutBox aboutApp = new orderAboutBox();
            aboutApp.ShowDialog();
        }

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

        private void _backButton_Click(object sender, EventArgs e)
        {
            //1. intantiate 
            selectionForm SelectionForm = new selectionForm();

            //2. pass a reference to the 
            SelectionForm.firstForm = this;

            SelectionForm.Show();

            this.Hide();
        }

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

        }
    }
}
