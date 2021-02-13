using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using DiscordRPC;

namespace pwf2tools
{
    public partial class pwf2spm : Form
    {
        public pwf2spm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
                this.openSPM.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.outputTex0Button.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.finishButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B");
                this.openSPM.ForeColor = Color.White; this.outputTex0Button.ForeColor = Color.White; this.finishButton.ForeColor = Color.White; this.outputtex0lab.ForeColor = Color.White; this.spmfilelocation.ForeColor = Color.White;
            }
            openSPMdiag = new OpenFileDialog
            {
                Title = "Find your SPM file.",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "spm",
                Filter = "SPM files (*.spm)|*.spm",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            saveSPMdiag = new SaveFileDialog
            {
                Title = "Export your tex0 file.",

                CheckPathExists = true,

                DefaultExt = "tex0",
                Filter = "tex0 files (*.tex0)|*.tex0",
                FilterIndex = 2,
                RestoreDirectory = true,
            };
        }

        private void pwf2spm_Activated(object sender, EventArgs e)
        {
            pwf2tools.SetPresence(new RichPresence()
            {
                Details = "Using pwf2spm",
                Assets = new Assets()
                {
                    LargeImageKey = "pwf2tools",
                    LargeImageText = "pwf2tools",
                    SmallImageText = "By fry!",
                    SmallImageKey = "fry"
                }
            });
        }

        private void openSPM_Click(object sender, EventArgs e)
        {
            if (openSPMdiag.ShowDialog() == DialogResult.OK)
            {
                SPMFileLocationTB.Text = openSPMdiag.FileName;
            }
        }

        private void outputTex0Button_Click(object sender, EventArgs e)
        {
            if (saveSPMdiag.ShowDialog() == DialogResult.OK)
            {
                outputTex0TB.Text = saveSPMdiag.FileName;
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SPMFileLocationTB.Text) && !string.IsNullOrEmpty(outputTex0TB.Text))
            {
                try
                {
                    var pwf2spmprocess = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = ".\\bin\\pwf2spm",
                            Arguments = string.Format("gtex0 \"{0}\" \"{1}\"", SPMFileLocationTB.Text, outputTex0TB.Text),
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                        }
                    };

                    pwf2spmprocess.Start();

                    while (!pwf2spmprocess.StandardOutput.EndOfStream)
                    {
                        var line = pwf2spmprocess.StandardOutput.ReadLine();

                    }

                    pwf2spmprocess.WaitForExit();
                    switch (Properties.Settings.Default.enableExit)
                    {
                        case true:
                            Close();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message, "Error while using pwf2spm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(SPMFileLocationTB.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2spm.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(outputTex0TB.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2spm.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
