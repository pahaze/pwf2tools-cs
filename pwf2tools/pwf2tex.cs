using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using DiscordRPC;


namespace pwf2tools
{
    public partial class pwf2tex : Form
    {
        public pwf2tex()
        {
            InitializeComponent();
            openTex0 = new OpenFileDialog
            {
                Title = "Find your tex0 file.",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "tex0",
                Filter = "tex0 files (*.tex0)|*.tex0",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); this.extractTab.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); this.injectTab.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
                this.SelTex0FolderButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.SelTex0But.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.SelOutputFolderButt.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.extButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B");
                this.seltexfolderinj.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.seltex0file.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.selpngfold.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.injpng.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B");
                this.SelTex0FolderButton.ForeColor = Color.White; this.SelTex0But.ForeColor = Color.White; this.SelOutputFolderButt.ForeColor = Color.White; this.extButton.ForeColor = Color.White;
                this.seltexfolderinj.ForeColor = Color.White; this.seltex0file.ForeColor = Color.White; this.selpngfold.ForeColor = Color.White; this.injpng.ForeColor = Color.White;
                this.SelTex0FileLabl.ForeColor = Color.White; this.SelTex0FolderLabl.ForeColor = Color.White; this.SelOutputPngFolder.ForeColor = Color.White; this.seltex0foldinj.ForeColor = Color.White; 
                this.seltex0fileinj.ForeColor = Color.White; this.outpnglab.ForeColor = Color.White;
            }
        }

        private void SelTex0FolderButton_Click(object sender, EventArgs e)
        {
            FolderSelectDialog extractFolder = new FolderSelectDialog();
            extractFolder.Title = "Choose your TEXTURES folder!";
            extractFolder.InitialDirectory = @"C:\";
            if (extractFolder.ShowDialog(IntPtr.Zero))
            {
                Tex0FolderTB.Text = extractFolder.FileName;
            }
        }

        private void SelTex0But_Click(object sender, EventArgs e)
        {
            if (openTex0.ShowDialog() == DialogResult.OK)
            {
                Tex0FileTB.Text = openTex0.FileName;
            }
        }

        private void SelOutputFolderButt_Click(object sender, EventArgs e)
        {
            FolderSelectDialog extractFolder = new FolderSelectDialog();
            extractFolder.Title = "Choose your folder to extract PNGs to.";
            extractFolder.InitialDirectory = @"C:\";
            if (extractFolder.ShowDialog(IntPtr.Zero))
            {
                OutputPngTB.Text = extractFolder.FileName;
            }
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tex0FolderTB.Text) && !string.IsNullOrEmpty(Tex0FileTB.Text) && !string.IsNullOrEmpty(OutputPngTB.Text))
            {
                try
                {
                    var pwf2texprocess = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = ".\\bin\\pwf2tex",
                            Arguments = string.Format("extract \"{0}\" \"{1}\" \"{2}\"", Tex0FolderTB.Text, Tex0FileTB.Text, OutputPngTB.Text),
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                        }
                    };

                    pwf2texprocess.Start();

                    while (!pwf2texprocess.StandardOutput.EndOfStream)
                    {
                        var line = pwf2texprocess.StandardOutput.ReadLine();

                    }

                    pwf2texprocess.WaitForExit();
                    Close();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message, "Error while using pwf2tex", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(Tex0FolderTB.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2tex.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Tex0FileTB.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2tex.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(OutputPngTB.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2tex.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seltexfolderinj_Click(object sender, EventArgs e)
        {
            FolderSelectDialog extractFolder = new FolderSelectDialog();
            extractFolder.Title = "Choose your TEXTURES folder!";
            extractFolder.InitialDirectory = @"C:\";
            if (extractFolder.ShowDialog(IntPtr.Zero))
            {
                seltex0foldtbinj.Text = extractFolder.FileName;
            }
        }

        private void seltex0file_Click(object sender, EventArgs e)
        {
            if (openTex0.ShowDialog() == DialogResult.OK)
            {
                seltex0fileinjtb.Text = openTex0.FileName;
            }
        }

        private void selpngfold_Click(object sender, EventArgs e)
        {
            FolderSelectDialog extractFolder = new FolderSelectDialog();
            extractFolder.Title = "Choose your folder with edited PNGs!";
            extractFolder.InitialDirectory = @"C:\";
            if (extractFolder.ShowDialog(IntPtr.Zero))
            {
                outputpngtbinj.Text = extractFolder.FileName;
            }
        }

        private void injpng_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(seltex0foldtbinj.Text) && !string.IsNullOrEmpty(seltex0fileinjtb.Text) && !string.IsNullOrEmpty(outputpngtbinj.Text))
            {
                try
                {
                    var pwf2texprocess = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = ".\\bin\\pwf2tex",
                            Arguments = string.Format("inject \"{0}\" \"{1}\" \"{2}\"", seltex0foldtbinj.Text, seltex0fileinjtb.Text, outputpngtbinj.Text),
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                        }
                    };

                    pwf2texprocess.Start();

                    while (!pwf2texprocess.StandardOutput.EndOfStream)
                    {
                        var line = pwf2texprocess.StandardOutput.ReadLine();

                    }

                    pwf2texprocess.WaitForExit();
                    Close();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message, "Error while using pwf2tex", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(seltex0foldtbinj.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2tex.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(seltex0fileinjtb.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2tex.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(outputpngtbinj.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2tex.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pwf2tex_Activated(object sender, EventArgs e)
        {
            pwf2tools.SetPresence(new RichPresence()
            {
                Details = "Using pwf2tex",
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
