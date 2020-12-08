using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwf2tools
{
    public partial class pwf2settings : Form
    {
        public pwf2settings()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
                this.themeSetting.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B");
                this.saveBtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#40444B");
                this.saveBtn.ForeColor = Color.White;
                this.themetxt.ForeColor = Color.White;
                this.EnableRPCBox.ForeColor = Color.White;
                this.enableToolexit.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.themeSetting.BackColor = Color.White;
                this.saveBtn.BackColor = Color.White;
            }
            switch (Properties.Settings.Default.EnableRPC)
            {
                case true:
                    EnableRPCBox.Checked = true;
                    break;
                default:
                    EnableRPCBox.Checked = false;
                    break;
            }
            switch (Properties.Settings.Default.enableExit)
            {
                case true:
                    enableToolexit.Checked = true;
                    break;
                default:
                    enableToolexit.Checked = false;
                    break;
            }

            themeSetting.DropDownStyle = ComboBoxStyle.DropDownList;
            themeSetting.Text = Properties.Settings.Default.Theme;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            switch (EnableRPCBox.Checked)
            {
                case true:
                    Properties.Settings.Default.EnableRPC = true;
                    break;
                default:
                    Properties.Settings.Default.EnableRPC = false;
                    break;
            }
            switch (enableToolexit.Checked)
            {
                case true:
                    Properties.Settings.Default.enableExit = true;
                    break;
                default:
                    Properties.Settings.Default.enableExit = false;
                    break;
            }
            Properties.Settings.Default.Theme = themeSetting.Text;

            Properties.Settings.Default.Save();

            string message = "Saved! You have to restart pwf2tools for changes to take effect.";
            string cap = "Saved your settings";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, cap, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
