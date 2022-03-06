using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruhBoy_Launcher
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            load.Width += 1;
            if (load.Width >= 500)
            {
                timer1.Stop();
                LoginScreen LS = new LoginScreen();
                LS.Show();
                Hide();
            }
        }
    }
}
