///<summary>
///	Name of Programme - Movie Bonanza - Online Streaming
///	Name - Sahil Verma
///	Student Number - 200335300
///	Date Last Modified or app creation date - March 5, 2017
///	Short revision history - functionality added, structured, gui, splash form
///	Description - the app calculates the cost for the movie as per the selection
/// </summary>
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
    public partial class selectionForm : Form
    {
        //it will store the values in an array to be used further in another form
        public string[] stroingValues = { "", "", "" };
        //movieTitle, Category, Cost

        //it will store the picture used for the movie so that it can be used
        //in another form
        public System.Drawing.Image pictureMovie;

        //3. create a reference to the previous form
        public OrderForm firstForm;

        //constructor for this form
        public selectionForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// this event handler will show the data in text box for title, category,
        /// and cost of the movie as per the selection from drop downLsit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _selection(object sender, EventArgs e)
        {
            titleTextBox.Text = (currentMovieListBox.SelectedItem).ToString();
            if(currentMovieListBox.SelectedItem.ToString() == "Cedar Rapids")
            {
                categoryTextBox.Text = "Comedy";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Cedar_Rapids;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Dilemma")
            {
                categoryTextBox.Text = "Comedy";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.The_Dilemma;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "No Strings Attached")
            {
                categoryTextBox.Text = "Comedy";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.No_Strings_Attached;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Just Go With It")
            {
                categoryTextBox.Text = "Comedy";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Just_Go_With_It;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Season of the Witch")
            {
                categoryTextBox.Text = "Sci-Fi";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Season_of_the_Witch;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "I am Number Four")
            {
                categoryTextBox.Text = "Sci-Fi";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.I_am_Number_Four;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Green Hornet")
            {
                categoryTextBox.Text = "Action";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.The_Green_Hornet;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Death Race 2")
            {
                categoryTextBox.Text = "Action";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Death_Race_2;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Mechanic")
            {
                categoryTextBox.Text = "Action";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.The_Mechanic;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Sanctum")
            {
                categoryTextBox.Text = "Action";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Sanctum;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Other Woman")
            {
                categoryTextBox.Text = "Action";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.The_Other_Woman;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Eagle")
            {
                categoryTextBox.Text = "Action";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.The_Eagle;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Company Men")
            {
                categoryTextBox.Text = "Drama";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Company_Men;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Way Back")
            {
                categoryTextBox.Text = "Drama";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.The_Way_Back;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Waiting for Forever")
            {
                categoryTextBox.Text = "Drama";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Waiting_for_Forever;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Rite")
            {
                categoryTextBox.Text = "Horror";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.The_Rite;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "The Roommate")
            {
                categoryTextBox.Text = "Thriller";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.The_Roommate;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Gnomeo and Juliet")
            {
                categoryTextBox.Text = "Family";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Gnomeo_and_Juliet;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Footloose")
            {
                categoryTextBox.Text = "New Release";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Footloose;
            }

            if (currentMovieListBox.SelectedItem.ToString() == "Real Steel")
            {
                categoryTextBox.Text = "New Release";
                moviePictureBox.Image = Assignment3_Movie_Bonanza.Properties.Resources.Real_Steel;
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

            nextButton.Enabled = true;
            storingValues();
            
        }

        //this method will store the values of title, category, cost, 
        //and movie picture as per the selection from dropDownList
        public void storingValues()
        {
            stroingValues[0] = titleTextBox.Text;
            stroingValues[1] = categoryTextBox.Text;
            stroingValues[2] = costTextBox.Text;
            pictureMovie = moviePictureBox.Image;
        }

        /// <summary>
        /// this event handler will close this form and open the order form
        /// and will send the values stored in storing values method to the textboxes 
        /// of the order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _nextButton_Click(object sender, EventArgs e)
        {

            //1. intantiate 
            OrderForm orderForm = new OrderForm();

            //2. pass a reference to the 
            orderForm.previousForm = this;

            orderForm.Show();
            this.Hide();
            orderForm._storedVales();
        }
    }
}
