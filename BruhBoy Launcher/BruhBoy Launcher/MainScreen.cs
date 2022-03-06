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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void user_name_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            user_name.Text = LoginScreen.User;
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Text = "Starting...";
            guna2Button1.Enabled = false;

            Thread thread = new Thread(() => oyunac());
            thread.IsBackground = true;
            thread.Start();
        }

        async private void oyunac()
        {
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);

            var ayar = new MLaunchOption
            {
                MaximumRamMb = 3072,
                Session = MSession.GetOfflineSession(user_name.Text),
            };

            foreach (var item in launcher.GetAllVersions())
            {
                guna2ComboBox1.Items.Add(item.Name);
            }
            var process = await launcher.CreateProcessAsync(guna2ComboBox1.Text,ayar);
            process.Start();
            Application.Exit();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}