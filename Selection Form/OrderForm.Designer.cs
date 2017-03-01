namespace Assignment3_Movie_Bonanza
{
    partial class OrderForm
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
            this.movieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.yourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.streamButton = new System.Windows.Forms.Button();
            this.movieSelectedGroupBox.SuspendLayout();
            this.yourOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // movieSelectedGroupBox
            // 
            this.movieSelectedGroupBox.Controls.Add(this.pictureBox1);
            this.movieSelectedGroupBox.Controls.Add(this.categoryTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.titleTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.categoryLabel);
            this.movieSelectedGroupBox.Controls.Add(this.titleLabel);
            this.movieSelectedGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieSelectedGroupBox.Location = new System.Drawing.Point(12, 31);
            this.movieSelectedGroupBox.Name = "movieSelectedGroupBox";
            this.movieSelectedGroupBox.Size = new System.Drawing.Size(246, 354);
            this.movieSelectedGroupBox.TabIndex = 0;
            this.movieSelectedGroupBox.TabStop = false;
            this.movieSelectedGroupBox.Text = "MovieSelected";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(20, 106);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(204, 26);
            this.categoryTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(20, 52);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(204, 26);
            this.titleTextBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Location = new System.Drawing.Point(16, 83);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(79, 20);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(16, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 21);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yourOrderGroupBox
            // 
            this.yourOrderGroupBox.Controls.Add(this.grandTotalTextBox);
            this.yourOrderGroupBox.Controls.Add(this.salesTaxTextBox);
            this.yourOrderGroupBox.Controls.Add(this.subTotalTextBox);
            this.yourOrderGroupBox.Controls.Add(this.costTextBox);
            this.yourOrderGroupBox.Controls.Add(this.costLabel);
            this.yourOrderGroupBox.Controls.Add(this.subTotalLabel);
            this.yourOrderGroupBox.Controls.Add(this.salesTaxLabel);
            this.yourOrderGroupBox.Controls.Add(this.grandTotalLabel);
            this.yourOrderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourOrderGroupBox.Location = new System.Drawing.Point(264, 31);
            this.yourOrderGroupBox.Name = "yourOrderGroupBox";
            this.yourOrderGroupBox.Size = new System.Drawing.Size(275, 264);
            this.yourOrderGroupBox.TabIndex = 1;
            this.yourOrderGroupBox.TabStop = false;
            this.yourOrderGroupBox.Text = "Your Order";
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Location = new System.Drawing.Point(140, 174);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.grandTotalTextBox.TabIndex = 9;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(140, 142);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.Size = new System.Drawing.Size(100, 26);
            this.salesTaxTextBox.TabIndex = 8;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(140, 110);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.subTotalTextBox.TabIndex = 7;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(140, 50);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 26);
            this.costTextBox.TabIndex = 6;
            // 
            // costLabel
            // 
            this.costLabel.Location = new System.Drawing.Point(6, 53);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(128, 20);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Location = new System.Drawing.Point(6, 113);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(128, 20);
            this.subTotalLabel.TabIndex = 3;
            this.subTotalLabel.Text = "Sub Total";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.Location = new System.Drawing.Point(6, 145);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(128, 20);
            this.salesTaxLabel.TabIndex = 4;
            this.salesTaxLabel.Text = "Sales Tax (13%)";
            this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.Location = new System.Drawing.Point(6, 177);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(128, 20);
            this.grandTotalLabel.TabIndex = 5;
            this.grandTotalLabel.Text = "Grand Total";
            this.grandTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(274, 355);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 29);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(380, 355);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 29);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // streamButton
            // 
            this.streamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamButton.Location = new System.Drawing.Point(464, 355);
            this.streamButton.Name = "streamButton";
            this.streamButton.Size = new System.Drawing.Size(75, 29);
            this.streamButton.TabIndex = 4;
            this.streamButton.Text = "Stream";
            this.streamButton.UseVisualStyleBackColor = true;
            // 
            // yourOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 397);
            this.ControlBox = false;
            this.Controls.Add(this.streamButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.yourOrderGroupBox);
            this.Controls.Add(this.movieSelectedGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "yourOrderForm";
            this.ShowIcon = false;
            this.Text = "Your Order";
            this.movieSelectedGroupBox.ResumeLayout(false);
            this.movieSelectedGroupBox.PerformLayout();
            this.yourOrderGroupBox.ResumeLayout(false);
            this.yourOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox movieSelectedGroupBox;
        private System.Windows.Forms.GroupBox yourOrderGroupBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button streamButton;
    }
}