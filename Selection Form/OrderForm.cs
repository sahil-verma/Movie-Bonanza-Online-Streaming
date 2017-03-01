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
    public partial class OrderForm : Form
    {
        //3. create a reference to the previous form
        public selectionForm previousForm;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
