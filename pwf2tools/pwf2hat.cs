//Copyright (C) 2014+ Marco (Phoenix) Calautti.

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, version 2.0.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License 2.0 for more details.

//A copy of the GPL 2.0 should have been included with the program.
//If not, see http://www.gnu.org/licenses/

//Official repository and contact information can be found at
//http://github.com/marco-calautti/Rainbow

using pwf2tools.Controls;
using Rainbow.App.GUI.Model;
using Rainbow.ImgLib.Formats;
using Rainbow.ImgLib.Formats.Serialization;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using DiscordRPC;

namespace pwf2tools
{
    public partial class pwf2hat : Form
    {
        private TextureFormat texture;
        private TextureFormatSerializer serializer;
        private string filename;
        private ListViewItemComparer listviewSorter = new ListViewItemComparer();

        public pwf2hat(string filename)
            : this()
        {
            try
            {
                using (Stream s = File.Open(filename, FileMode.Open))
                    OpenImportStream(s, filename, TextureFormatMode.Format);

                FillListView(new string[] { filename });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public pwf2hat()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.listView.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); this.transparentPictureBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); this.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); this.menuStrip.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F");
                this.menuStrip.BackColor = System.Drawing.ColorTranslator.FromHtml("#36393F"); this.menuStrip.ForeColor = Color.White; 
            }
                Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Ptr2hat_Activated(object sender, EventArgs e)
        {

        }

        private void OnLoad(object sender, EventArgs e)
        {
            splitContainer1.Panel2.MouseWheel += new MouseEventHandler(OnMouseWheel);
            splitContainer1.Panel2.MouseEnter += (s, ev) => splitContainer1.Panel2.Select();

            listView.ListViewItemSorter = listviewSorter;
        }

        private void OnListViewColumnClicked(object sender, ColumnClickEventArgs e)
        {
            listviewSorter.ColumnIndex = e.Column;
            if (listviewSorter.SortOrder == SortOrder.Ascending)
            {
                listviewSorter.SortOrder = SortOrder.Descending;
            }
            else
            {
                listviewSorter.SortOrder = SortOrder.Ascending;
            }

            listView.Sort();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                return;
            }

            TextureFormatProxy proxy = (TextureFormatProxy)listView.SelectedItems[0].Tag;
            try
            {
                FileTextureFormatProxy fproxy = proxy as FileTextureFormatProxy;
                string fullPath = null;
                if (fproxy != null)
                {
                    fullPath = fproxy.FullPath;
                }

                using (Stream s = proxy.GetTextureStream())
                    OpenImportStream(s, fullPath, TextureFormatMode.Unspecified);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnMouseWheel(Object sender, MouseEventArgs e)
        {
            Zoom(e.Delta > 0 ? 1.2f : 0.8f);
        }

        private void pwf2hat_Activated(object sender, EventArgs e)
        {
            pwf2tools.SetPresence(new RichPresence()
            {
                State = "Using pwf2hat",
                Assets = new Assets()
                {
                    LargeImageKey = "pwf2tools",
                    LargeImageText = "pwf2tools",
                    SmallImageKey = "fry",
                    SmallImageText = "By fry!"
                }
            });
        }
    }
}
