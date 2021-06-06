using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        public String getPassword()
        {
            return passwordBox.Text;
        }
 
        private void submit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            passwordBox.Text = "";
            this.Close();
        }
    }
}
