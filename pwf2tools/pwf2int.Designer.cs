namespace pwf2tools
{
    partial class pwf2int
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwf2int));
            this.modeTabs = new System.Windows.Forms.TabControl();
            this.ext = new System.Windows.Forms.TabPage();
            this.extbutt = new System.Windows.Forms.Button();
            this.selfolderext = new System.Windows.Forms.Button();
            this.openintext = new System.Windows.Forms.Button();
            this.outputfolddir = new System.Windows.Forms.TextBox();
            this.seloutput = new System.Windows.Forms.Label();
            this.intfilesel = new System.Windows.Forms.TextBox();
            this.selinttext = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.TabPage();
            this.saveINTfinal = new System.Windows.Forms.Button();
            this.INTfolderSelector = new System.Windows.Forms.Button();
            this.intsrcbox = new System.Windows.Forms.TextBox();
            this.intsrcfoldlabel = new System.Windows.Forms.Label();
            this.saveINTbutton = new System.Windows.Forms.Button();
            this.saveINTbox = new System.Windows.Forms.TextBox();
            this.saveINTlabel = new System.Windows.Forms.Label();
            this.openINT = new System.Windows.Forms.OpenFileDialog();
            this.saveINT = new System.Windows.Forms.SaveFileDialog();
            this.modeTabs.SuspendLayout();
            this.ext.SuspendLayout();
            this.create.SuspendLayout();
            this.SuspendLayout();
            // 
            // modeTabs
            // 
            this.modeTabs.Controls.Add(this.ext);
            this.modeTabs.Controls.Add(this.create);
            this.modeTabs.Location = new System.Drawing.Point(0, 0);
            this.modeTabs.Name = "modeTabs";
            this.modeTabs.SelectedIndex = 0;
            this.modeTabs.Size = new System.Drawing.Size(389, 142);
            this.modeTabs.TabIndex = 0;
            // 
            // ext
            // 
            this.ext.Controls.Add(this.extbutt);
            this.ext.Controls.Add(this.selfolderext);
            this.ext.Controls.Add(this.openintext);
            this.ext.Controls.Add(this.outputfolddir);
            this.ext.Controls.Add(this.seloutput);
            this.ext.Controls.Add(this.intfilesel);
            this.ext.Controls.Add(this.selinttext);
            this.ext.Location = new System.Drawing.Point(4, 22);
            this.ext.Name = "ext";
            this.ext.Padding = new System.Windows.Forms.Padding(3);
            this.ext.Size = new System.Drawing.Size(381, 116);
            this.ext.TabIndex = 0;
            this.ext.Text = "extract";
            this.ext.UseVisualStyleBackColor = true;
            // 
            // extbutt
            // 
            this.extbutt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.extbutt.Location = new System.Drawing.Point(141, 90);
            this.extbutt.Name = "extbutt";
            this.extbutt.Size = new System.Drawing.Size(95, 21);
            this.extbutt.TabIndex = 6;
            this.extbutt.Text = "Extract your INT!";
            this.extbutt.UseVisualStyleBackColor = true;
            this.extbutt.Click += new System.EventHandler(this.extbutt_Click);
            // 
            // selfolderext
            // 
            this.selfolderext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selfolderext.Location = new System.Drawing.Point(284, 64);
            this.selfolderext.Name = "selfolderext";
            this.selfolderext.Size = new System.Drawing.Size(88, 20);
            this.selfolderext.TabIndex = 5;
            this.selfolderext.Text = "Select a folder";
            this.selfolderext.UseVisualStyleBackColor = true;
            this.selfolderext.Click += new System.EventHandler(this.selfolderext_Click);
            // 
            // openintext
            // 
            this.openintext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openintext.Location = new System.Drawing.Point(284, 20);
            this.openintext.Name = "openintext";
            this.openintext.Size = new System.Drawing.Size(88, 20);
            this.openintext.TabIndex = 4;
            this.openintext.Text = "Open an INT";
            this.openintext.UseVisualStyleBackColor = true;
            this.openintext.Click += new System.EventHandler(this.openintext_Click);
            // 
            // outputfolddir
            // 
            this.outputfolddir.Enabled = false;
            this.outputfolddir.Location = new System.Drawing.Point(11, 64);
            this.outputfolddir.Name = "outputfolddir";
            this.outputfolddir.ReadOnly = true;
            this.outputfolddir.Size = new System.Drawing.Size(267, 20);
            this.outputfolddir.TabIndex = 3;
            // 
            // seloutput
            // 
            this.seloutput.AutoSize = true;
            this.seloutput.Location = new System.Drawing.Point(8, 48);
            this.seloutput.Name = "seloutput";
            this.seloutput.Size = new System.Drawing.Size(125, 13);
            this.seloutput.TabIndex = 2;
            this.seloutput.Text = "Select your output folder.";
            // 
            // intfilesel
            // 
            this.intfilesel.Enabled = false;
            this.intfilesel.Location = new System.Drawing.Point(11, 20);
            this.intfilesel.Name = "intfilesel";
            this.intfilesel.ReadOnly = true;
            this.intfilesel.Size = new System.Drawing.Size(267, 20);
            this.intfilesel.TabIndex = 1;
            // 
            // selinttext
            // 
            this.selinttext.AutoSize = true;
            this.selinttext.Location = new System.Drawing.Point(8, 3);
            this.selinttext.Name = "selinttext";
            this.selinttext.Size = new System.Drawing.Size(100, 13);
            this.selinttext.TabIndex = 0;
            this.selinttext.Text = "Select your INT file.";
            // 
            // create
            // 
            this.create.Controls.Add(this.saveINTfinal);
            this.create.Controls.Add(this.INTfolderSelector);
            this.create.Controls.Add(this.intsrcbox);
            this.create.Controls.Add(this.intsrcfoldlabel);
            this.create.Controls.Add(this.saveINTbutton);
            this.create.Controls.Add(this.saveINTbox);
            this.create.Controls.Add(this.saveINTlabel);
            this.create.Location = new System.Drawing.Point(4, 22);
            this.create.Name = "create";
            this.create.Padding = new System.Windows.Forms.Padding(3);
            this.create.Size = new System.Drawing.Size(384, 116);
            this.create.TabIndex = 1;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            // 
            // saveINTfinal
            // 
            this.saveINTfinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveINTfinal.Location = new System.Drawing.Point(142, 90);
            this.saveINTfinal.Name = "saveINTfinal";
            this.saveINTfinal.Size = new System.Drawing.Size(88, 23);
            this.saveINTfinal.TabIndex = 6;
            this.saveINTfinal.Text = "Save your INT!";
            this.saveINTfinal.UseVisualStyleBackColor = true;
            this.saveINTfinal.Click += new System.EventHandler(this.saveINTfinal_Click);
            // 
            // INTfolderSelector
            // 
            this.INTfolderSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.INTfolderSelector.Location = new System.Drawing.Point(274, 64);
            this.INTfolderSelector.Name = "INTfolderSelector";
            this.INTfolderSelector.Size = new System.Drawing.Size(98, 20);
            this.INTfolderSelector.TabIndex = 5;
            this.INTfolderSelector.Text = "Select your folder";
            this.INTfolderSelector.UseVisualStyleBackColor = true;
            this.INTfolderSelector.Click += new System.EventHandler(this.INTfolderSelector_Click);
            // 
            // intsrcbox
            // 
            this.intsrcbox.Enabled = false;
            this.intsrcbox.Location = new System.Drawing.Point(9, 64);
            this.intsrcbox.Name = "intsrcbox";
            this.intsrcbox.ReadOnly = true;
            this.intsrcbox.Size = new System.Drawing.Size(259, 20);
            this.intsrcbox.TabIndex = 4;
            // 
            // intsrcfoldlabel
            // 
            this.intsrcfoldlabel.AutoSize = true;
            this.intsrcfoldlabel.Location = new System.Drawing.Point(8, 48);
            this.intsrcfoldlabel.Name = "intsrcfoldlabel";
            this.intsrcfoldlabel.Size = new System.Drawing.Size(155, 13);
            this.intsrcfoldlabel.TabIndex = 3;
            this.intsrcfoldlabel.Text = "Select your INT\'s source folder.";
            // 
            // saveINTbutton
            // 
            this.saveINTbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveINTbutton.Location = new System.Drawing.Point(274, 20);
            this.saveINTbutton.Name = "saveINTbutton";
            this.saveINTbutton.Size = new System.Drawing.Size(98, 20);
            this.saveINTbutton.TabIndex = 2;
            this.saveINTbutton.Text = "Save your INT.";
            this.saveINTbutton.UseVisualStyleBackColor = true;
            this.saveINTbutton.Click += new System.EventHandler(this.saveINTbutton_Click);
            // 
            // saveINTbox
            // 
            this.saveINTbox.Enabled = false;
            this.saveINTbox.Location = new System.Drawing.Point(9, 20);
            this.saveINTbox.Name = "saveINTbox";
            this.saveINTbox.ReadOnly = true;
            this.saveINTbox.Size = new System.Drawing.Size(259, 20);
            this.saveINTbox.TabIndex = 1;
            // 
            // saveINTlabel
            // 
            this.saveINTlabel.AutoSize = true;
            this.saveINTlabel.Location = new System.Drawing.Point(8, 3);
            this.saveINTlabel.Name = "saveINTlabel";
            this.saveINTlabel.Size = new System.Drawing.Size(79, 13);
            this.saveINTlabel.TabIndex = 0;
            this.saveINTlabel.Text = "Save your INT.";
            // 
            // openINT
            // 
            this.openINT.FileName = "openINT";
            // 
            // pwf2int
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 141);
            this.Controls.Add(this.modeTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pwf2int";
            this.Text = "pwf2int";
            this.Activated += new System.EventHandler(this.pwf2int_Activated);
            this.modeTabs.ResumeLayout(false);
            this.ext.ResumeLayout(false);
            this.ext.PerformLayout();
            this.create.ResumeLayout(false);
            this.create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl modeTabs;
        private System.Windows.Forms.TabPage ext;
        private System.Windows.Forms.Button extbutt;
        private System.Windows.Forms.Button selfolderext;
        private System.Windows.Forms.Button openintext;
        private System.Windows.Forms.TextBox outputfolddir;
        private System.Windows.Forms.Label seloutput;
        private System.Windows.Forms.TextBox intfilesel;
        private System.Windows.Forms.Label selinttext;
        private System.Windows.Forms.TabPage create;
        private System.Windows.Forms.OpenFileDialog openINT;
        private System.Windows.Forms.Button saveINTfinal;
        private System.Windows.Forms.Button INTfolderSelector;
        private System.Windows.Forms.TextBox intsrcbox;
        private System.Windows.Forms.Label intsrcfoldlabel;
        private System.Windows.Forms.Button saveINTbutton;
        private System.Windows.Forms.TextBox saveINTbox;
        private System.Windows.Forms.Label saveINTlabel;
        private System.Windows.Forms.SaveFileDialog saveINT;
    }
}