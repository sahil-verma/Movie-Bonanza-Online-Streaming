using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection_Form
{
    public partial class selectionForm : Form
    {
        public selectionForm()
        {
            InitializeComponent();
        }
            
        private void _selection(object sender, EventArgs e)
        {
            titleTextBox.Text = (currentMovieListBox.SelectedItem).ToString();
            if(currentMovieListBox.SelectedItem.ToString() == "Cedar Rapids")
            {
                categoryTextBox.Text = "Comedy";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Dilemma")
            {
                categoryTextBox.Text = "Comedy";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "No Strings Attached")
            {
                categoryTextBox.Text = "Comedy";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Just Go With It")
            {
                categoryTextBox.Text = "Comedy";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Season of the Witch")
            {
                categoryTextBox.Text = "Sci-Fi";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "I am Number Four")
            {
                categoryTextBox.Text = "Sci-Fi";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The	Green Hornet")
            {
                categoryTextBox.Text = "Action";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Death Race 2")
            {
                categoryTextBox.Text = "Action";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Mechanic")
            {
                categoryTextBox.Text = "Action";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Sanctum")
            {
                categoryTextBox.Text = "Action";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Other Woman")
            {
                categoryTextBox.Text = "Action";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Eagle")
            {
                categoryTextBox.Text = "Action";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Company	Men")
            {
                categoryTextBox.Text = "Drama";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Way Back")
            {
                categoryTextBox.Text = "Drama";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Waiting for Forever")
            {
                categoryTextBox.Text = "Drama";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Rite")
            {
                categoryTextBox.Text = "Horror";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Roommate")
            {
                categoryTextBox.Text = "Thriller";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Gnomeo and Juliet")
            {
                categoryTextBox.Text = "Family";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Footloose")
            {
                categoryTextBox.Text = "New Release";
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Real Steel")
            {
                categoryTextBox.Text = "New Release";
            }



            if (categoryTextBox.Text == "Comedy" || categoryTextBox.Text == "Drama" || categoryTextBox.Text == "Thriller")
            {
                costTextBox.Text = "$1.99";
            }

            if (categoryTextBox.Text == "Action" || categoryTextBox.Text == "Sci-Fi" || categoryTextBox.Text == "Horror")
            {
                costTextBox.Text = "$2.99";
            }

            if (categoryTextBox.Text == "Family")
            {
                costTextBox.Text = "$0.99";
            }

            if (categoryTextBox.Text == "New Release")
            {
                costTextBox.Text = "$4.99";
            }

        }

    }
}
