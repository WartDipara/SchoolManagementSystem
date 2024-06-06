using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start_loadingbar.Width += 10;

            if(start_loadingbar.Width >= 760)
            {
                timer1.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
