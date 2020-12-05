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
    public partial class pwf2tools : Form
    {
        public pwf2tools()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
                this.buildtxt.ForeColor = Color.White; this.pwfint.ForeColor = Color.White; this.pwfspm.ForeColor = Color.White; this.pwftex.ForeColor = Color.White; this.pwfhat.ForeColor = Color.White;
                this.pwfint.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.pwfspm.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.pwftex.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.pwfhat.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B");
            }
            else
            {
                //Call this unoptimized if you want I don't care I worked on this at like midnight it won't kill you or your PC
                this.BackColor = Color.White;
                this.buildtxt.ForeColor = Color.Black;
                this.pwfint.BackColor = Color.White; this.pwfspm.BackColor = Color.White; this.pwftex.BackColor = Color.White; this.pwfhat.BackColor = Color.White;
            }
        }
        static DiscordRpcClient DiscordClient = new DiscordRpcClient("776654779979399198");

        public static void SetPresence(RichPresence Presence)
        {
            DiscordClient.SetPresence(Presence);
        }

        public static void DisposePresence()
        {
            DiscordClient.Dispose();
        }

        private void pwf2tools_Activated(object sender, EventArgs e)
        {
            SetPresence(new RichPresence()
            {
                Details = "Choosing an action",
                Assets = new Assets()
                {
                    LargeImageKey = "pwf2tools",
                    LargeImageText = "pwf2tools",
                    SmallImageText = "By fry!",
                    SmallImageKey = "fry"
                }
            });
        }

        private void pwf2tools_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.EnableRPC == true)
            {
                DiscordClient.Initialize();
            }
            
        }

        private void stngs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pwf2settings f1 = new pwf2settings();
            f1.ShowDialog();
        }

        private void abt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pwf2about f1 = new pwf2about();
            f1.ShowDialog();
        }

        private void pwfint_Click(object sender, EventArgs e)
        {
            pwf2int f1 = new pwf2int();
            f1.ShowDialog();
        }

        private void pwfspm_Click(object sender, EventArgs e)
        {
            pwf2spm f1 = new pwf2spm();
            f1.ShowDialog();
        }

        private void pwfhat_Click(object sender, EventArgs e)
        {
            pwf2hat f1 = new pwf2hat();
            f1.ShowDialog();
        }

        private void pwftex_Click(object sender, EventArgs e)
        {
            pwf2tex f1 = new pwf2tex();
            f1.ShowDialog();
        }
    }
}
