using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using DiscordRPC;

namespace pwf2tools
{
    public partial class pwf2int : Form
    {
        public pwf2int()
        {
            InitializeComponent();
            openINT = new OpenFileDialog
            {
                Title = "Find your INT file.",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "int",
                Filter = "INT files (*.int)|*.int",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            saveINT = new SaveFileDialog
            {
                Title = "Find your INT file.",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "int",
                Filter = "INT files (*.int)|*.int",
                FilterIndex = 2,
                RestoreDirectory = true,
            };
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); this.create.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); this.ext.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); this.modeTabs.ForeColor = Color.White; this.modeTabs.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); ;
                this.openintext.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.selfolderext.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.extbutt.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.saveINTbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.INTfolderSelector.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B"); this.saveINTfinal.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B");
                this.openintext.ForeColor = Color.White; this.selfolderext.ForeColor = Color.White; this.extbutt.ForeColor = Color.White; this.saveINTbutton.ForeColor = Color.White; this.INTfolderSelector.ForeColor = Color.White; this.saveINTfinal.ForeColor = Color.White;
            }
        }

        private void openintext_Click(object sender, EventArgs e)
        {
            if(openINT.ShowDialog() == DialogResult.OK)
            {
                intfilesel.Text = openINT.FileName;
            }
        }

        private void selfolderext_Click(object sender, EventArgs e)
        {
            FolderSelectDialog extractFolder = new FolderSelectDialog();
            extractFolder.Title = "Choose your folder to extract INTs to";
            extractFolder.InitialDirectory = @"C:\";
            if (extractFolder.ShowDialog(IntPtr.Zero))
            {
                outputfolddir.Text = extractFolder.FileName;
            }
        }

        private void extbutt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openINT.FileName) && !string.IsNullOrEmpty(intfilesel.Text) && !string.IsNullOrEmpty(outputfolddir.Text))
            {
                try
                {
                    var pwf2intprocess = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = ".\\bin\\pwf2int",
                            Arguments = string.Format("extract \"{0}\" \"{1}\"",intfilesel.Text,outputfolddir.Text),
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                        }
                    };

                    pwf2intprocess.Start();

                    while (!pwf2intprocess.StandardOutput.EndOfStream)
                    {
                        var line = pwf2intprocess.StandardOutput.ReadLine();

                    }

                    pwf2intprocess.WaitForExit();
                    Close();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message, "Error while using pwf2int", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(intfilesel.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2int.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(outputfolddir.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2int.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveINTbutton_Click(object sender, EventArgs e)
        {
            if(saveINT.ShowDialog() == DialogResult.OK)
            {
                saveINTbox.Text = saveINT.FileName;
            }
        }

        private void INTfolderSelector_Click(object sender, EventArgs e)
        {
            FolderSelectDialog extractFolder = new FolderSelectDialog();
            extractFolder.Title = "Choose your source INT folder!";
            extractFolder.InitialDirectory = @"C:\";
            if (extractFolder.ShowDialog(IntPtr.Zero))
            {
                intsrcbox.Text = extractFolder.FileName;
            }
        }

        private void saveINTfinal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(saveINT.FileName) && !string.IsNullOrEmpty(saveINTbox.Text) && !string.IsNullOrEmpty(intsrcbox.Text))
            {
                try
                {
                    var pwf2intprocess = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = ".\\bin\\pwf2int",
                            Arguments = string.Format("extract \"{0}\" \"{1}\"", saveINTbox.Text, intsrcbox.Text),
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                        }
                    };

                    pwf2intprocess.Start();

                    while (!pwf2intprocess.StandardOutput.EndOfStream)
                    {
                        var line = pwf2intprocess.StandardOutput.ReadLine();

                    }

                    pwf2intprocess.WaitForExit();
                    Close();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message, "Error while using pwf2int", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrEmpty(intfilesel.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2int.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(outputfolddir.Text))
            {
                MessageBox.Show("You can't leave a directory box blank.", "Error while using pwf2int.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pwf2int_Activated(object sender, EventArgs e)
        {
            pwf2tools.SetPresence(new RichPresence()
            {
                Details = "Using pwf2int",
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
