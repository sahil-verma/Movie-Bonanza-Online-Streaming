namespace Assignment3_Movie_Bonanza
{
    partial class streamForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.thanksLabel = new System.Windows.Forms.Label();
            this.notifyCreditLabel = new System.Windows.Forms.Label();
            this.notifyMovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(121, 168);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 30);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // thanksLabel
            // 
            this.thanksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanksLabel.Location = new System.Drawing.Point(12, 43);
            this.thanksLabel.Name = "thanksLabel";
            this.thanksLabel.Size = new System.Drawing.Size(301, 23);
            this.thanksLabel.TabIndex = 1;
            this.thanksLabel.Text = "Thank you for choosing Movie Bonanza!";
            // 
            // notifyCreditLabel
            // 
            this.notifyCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyCreditLabel.Location = new System.Drawing.Point(36, 86);
            this.notifyCreditLabel.Name = "notifyCreditLabel";
            this.notifyCreditLabel.Size = new System.Drawing.Size(226, 23);
            this.notifyCreditLabel.TabIndex = 2;
            // 
            // notifyMovieLabel
            // 
            this.notifyMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyMovieLabel.Location = new System.Drawing.Point(36, 126);
            this.notifyMovieLabel.Name = "notifyMovieLabel";
            this.notifyMovieLabel.Size = new System.Drawing.Size(226, 23);
            this.notifyMovieLabel.TabIndex = 3;
            // 
            // streamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 210);
            this.ControlBox = false;
            this.Controls.Add(this.notifyMovieLabel);
            this.Controls.Add(this.notifyCreditLabel);
            this.Controls.Add(this.thanksLabel);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "streamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Movie is about to start!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label thanksLabel;
        private System.Windows.Forms.Label notifyCreditLabel;
        private System.Windows.Forms.Label notifyMovieLabel;
    }
}