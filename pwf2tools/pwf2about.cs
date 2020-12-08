using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;

namespace pwf2tools
{
    public partial class pwf2about : Form
    {
        public pwf2about()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
                this.whatIs.ForeColor = Color.White; this.whatisText.ForeColor = Color.White; this.special.ForeColor = Color.White; this.specialText.ForeColor = Color.White; this.links.ForeColor = Color.White; this.p2tools.ForeColor = Color.White; this.failure.ForeColor = Color.White;
            } 
            else
            {
                this.BackColor = Color.White;
                this.whatIs.ForeColor = Color.Black; this.whatisText.ForeColor = Color.Black; this.special.ForeColor = Color.Black; this.specialText.ForeColor = Color.Black; this.links.ForeColor = Color.Black; this.p2tools.ForeColor = Color.Black;
            }
        }

        private void visualgit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/VisualDevelopment");
        }

        private void richgit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mgrich");
        }

        private void mygit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/pahaze");
        }

        private void ptr2serv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/NvBRK6m");
        }

        private void pwf2deb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/pahaze/pwf2tools-execs");
        }

        private void pwf2about_Activated(object sender, EventArgs e)
        {
            pwf2tools.SetPresence(new RichPresence()
            {
                Details = "Reading about pwf2tools",
                Assets = new Assets()
                {
                    LargeImageKey = "pwf2tools",
                    LargeImageText = "pwf2tools",
                    SmallImageText = "By fry!",
                    SmallImageKey = "fry"
                }
            });
        }
    }
}
