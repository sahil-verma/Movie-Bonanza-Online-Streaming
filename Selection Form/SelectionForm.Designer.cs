namespace Assignment3_Movie_Bonanza
{
    partial class selectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.movieSelection = new System.Windows.Forms.Label();
            this.currentMovieListBox = new System.Windows.Forms.ListBox();
            this.yourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.moviePictureBox = new System.Windows.Forms.PictureBox();
            this.yourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(31, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(394, 23);
            this.title.TabIndex = 0;
            this.title.Text = "Choose the movie you wish to STREAM from the list below";
            // 
            // movieSelection
            // 
            this.movieSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieSelection.Location = new System.Drawing.Point(45, 48);
            this.movieSelection.Name = "movieSelection";
            this.movieSelection.Size = new System.Drawing.Size(119, 23);
            this.movieSelection.TabIndex = 1;
            this.movieSelection.Text = "Current Movies";
            // 
            // currentMovieListBox
            // 
            this.currentMovieListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMovieListBox.FormattingEnabled = true;
            this.currentMovieListBox.ItemHeight = 16;
            this.currentMovieListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company\tMen",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.currentMovieListBox.Location = new System.Drawing.Point(35, 71);
            this.currentMovieListBox.Name = "currentMovieListBox";
            this.currentMovieListBox.Size = new System.Drawing.Size(167, 244);
            this.currentMovieListBox.Sorted = true;
            this.currentMovieListBox.TabIndex = 2;
            this.currentMovieListBox.SelectedIndexChanged += new System.EventHandler(this._selection);
            // 
            // yourSelectionGroupBox
            // 
            this.yourSelectionGroupBox.Controls.Add(this.costTextBox);
            this.yourSelectionGroupBox.Controls.Add(this.categoryTextBox);
            this.yourSelectionGroupBox.Controls.Add(this.titleTextBox);
            this.yourSelectionGroupBox.Controls.Add(this.costLabel);
            this.yourSelectionGroupBox.Controls.Add(this.categoryLabel);
            this.yourSelectionGroupBox.Controls.Add(this.titleLabel);
            this.yourSelectionGroupBox.Controls.Add(this.moviePictureBox);
            this.yourSelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourSelectionGroupBox.Location = new System.Drawing.Point(218, 71);
            this.yourSelectionGroupBox.Name = "yourSelectionGroupBox";
            this.yourSelectionGroupBox.Size = new System.Drawing.Size(379, 169);
            this.yourSelectionGroupBox.TabIndex = 3;
            this.yourSelectionGroupBox.TabStop = false;
            this.yourSelectionGroupBox.Text = "Your Selection";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(290, 124);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(83, 26);
            this.costTextBox.TabIndex = 6;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(148, 124);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.ReadOnly = true;
            this.categoryTextBox.Size = new System.Drawing.Size(136, 26);
            this.categoryTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(148, 48);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(225, 26);
            this.titleTextBox.TabIndex = 4;
            // 
            // costLabel
            // 
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(307, 91);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(49, 26);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "Cost";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(160, 91);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(76, 26);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(160, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(47, 26);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(522, 297);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 28);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this._nextButton_Click);
            // 
            // moviePictureBox
            // 
            this.moviePictureBox.Location = new System.Drawing.Point(16, 25);
            this.moviePictureBox.Name = "moviePictureBox";
            this.moviePictureBox.Size = new System.Drawing.Size(115, 128);
            this.moviePictureBox.TabIndex = 0;
            this.moviePictureBox.TabStop = false;
            // 
            // selectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 338);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.yourSelectionGroupBox);
            this.Controls.Add(this.currentMovieListBox);
            this.Controls.Add(this.movieSelection);
            this.Controls.Add(this.title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "selectionForm";
            this.ShowIcon = false;
            this.Text = "Movie Bonanza - Your Online Streaming Services";
            this.yourSelectionGroupBox.ResumeLayout(false);
            this.yourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label movieSelection;
        private System.Windows.Forms.ListBox currentMovieListBox;
        private System.Windows.Forms.GroupBox yourSelectionGroupBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox moviePictureBox;
        private System.Windows.Forms.Button nextButton;
    }
}

