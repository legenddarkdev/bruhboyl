using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using CmlLib.Core;
using CmlLib.Core.Auth;

namespace BruhBoy_Launcher
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public static string User;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            User = guna2TextBox1.Text;
            MainScreen mainscreen = new MainScreen();
            mainscreen.Show();
            Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
