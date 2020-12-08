namespace pwf2tools
{
    partial class pwf2tex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwf2tex));
            this.texTabControl = new System.Windows.Forms.TabControl();
            this.extractTab = new System.Windows.Forms.TabPage();
            this.injectTab = new System.Windows.Forms.TabPage();
            this.SelTex0FolderLabl = new System.Windows.Forms.Label();
            this.Tex0FolderTB = new System.Windows.Forms.TextBox();
            this.SelTex0FileLabl = new System.Windows.Forms.Label();
            this.Tex0FileTB = new System.Windows.Forms.TextBox();
            this.SelOutputPngFolder = new System.Windows.Forms.Label();
            this.OutputPngTB = new System.Windows.Forms.TextBox();
            this.SelTex0FolderButton = new System.Windows.Forms.Button();
            this.SelTex0But = new System.Windows.Forms.Button();
            this.SelOutputFolderButt = new System.Windows.Forms.Button();
            this.extButton = new System.Windows.Forms.Button();
            this.openTex0 = new System.Windows.Forms.OpenFileDialog();
            this.seltex0foldinj = new System.Windows.Forms.Label();
            this.seltex0foldtbinj = new System.Windows.Forms.TextBox();
            this.seltex0fileinj = new System.Windows.Forms.Label();
            this.seltex0fileinjtb = new System.Windows.Forms.TextBox();
            this.outpnglab = new System.Windows.Forms.Label();
            this.outputpngtbinj = new System.Windows.Forms.TextBox();
            this.seltexfolderinj = new System.Windows.Forms.Button();
            this.seltex0file = new System.Windows.Forms.Button();
            this.selpngfold = new System.Windows.Forms.Button();
            this.injpng = new System.Windows.Forms.Button();
            this.texTabControl.SuspendLayout();
            this.extractTab.SuspendLayout();
            this.injectTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // texTabControl
            // 
            this.texTabControl.Controls.Add(this.extractTab);
            this.texTabControl.Controls.Add(this.injectTab);
            this.texTabControl.Location = new System.Drawing.Point(0, -1);
            this.texTabControl.Name = "texTabControl";
            this.texTabControl.SelectedIndex = 0;
            this.texTabControl.Size = new System.Drawing.Size(488, 189);
            this.texTabControl.TabIndex = 0;
            // 
            // extractTab
            // 
            this.extractTab.Controls.Add(this.extButton);
            this.extractTab.Controls.Add(this.SelOutputFolderButt);
            this.extractTab.Controls.Add(this.SelTex0But);
            this.extractTab.Controls.Add(this.SelTex0FolderButton);
            this.extractTab.Controls.Add(this.OutputPngTB);
            this.extractTab.Controls.Add(this.SelOutputPngFolder);
            this.extractTab.Controls.Add(this.Tex0FileTB);
            this.extractTab.Controls.Add(this.SelTex0FileLabl);
            this.extractTab.Controls.Add(this.Tex0FolderTB);
            this.extractTab.Controls.Add(this.SelTex0FolderLabl);
            this.extractTab.Location = new System.Drawing.Point(4, 22);
            this.extractTab.Name = "extractTab";
            this.extractTab.Padding = new System.Windows.Forms.Padding(3);
            this.extractTab.Size = new System.Drawing.Size(483, 163);
            this.extractTab.TabIndex = 0;
            this.extractTab.Text = "extract";
            this.extractTab.UseVisualStyleBackColor = true;
            // 
            // injectTab
            // 
            this.injectTab.Controls.Add(this.injpng);
            this.injectTab.Controls.Add(this.selpngfold);
            this.injectTab.Controls.Add(this.seltex0file);
            this.injectTab.Controls.Add(this.seltexfolderinj);
            this.injectTab.Controls.Add(this.outputpngtbinj);
            this.injectTab.Controls.Add(this.outpnglab);
            this.injectTab.Controls.Add(this.seltex0fileinjtb);
            this.injectTab.Controls.Add(this.seltex0fileinj);
            this.injectTab.Controls.Add(this.seltex0foldtbinj);
            this.injectTab.Controls.Add(this.seltex0foldinj);
            this.injectTab.Location = new System.Drawing.Point(4, 22);
            this.injectTab.Name = "injectTab";
            this.injectTab.Padding = new System.Windows.Forms.Padding(3);
            this.injectTab.Size = new System.Drawing.Size(480, 163);
            this.injectTab.TabIndex = 1;
            this.injectTab.Text = "inject";
            this.injectTab.UseVisualStyleBackColor = true;
            // 
            // SelTex0FolderLabl
            // 
            this.SelTex0FolderLabl.AutoSize = true;
            this.SelTex0FolderLabl.Location = new System.Drawing.Point(8, 8);
            this.SelTex0FolderLabl.Name = "SelTex0FolderLabl";
            this.SelTex0FolderLabl.Size = new System.Drawing.Size(297, 13);
            this.SelTex0FolderLabl.TabIndex = 0;
            this.SelTex0FolderLabl.Text = "Select your tex0 folder (This will be TEXTURES from pwf2int).";
            // 
            // Tex0FolderTB
            // 
            this.Tex0FolderTB.Enabled = false;
            this.Tex0FolderTB.Location = new System.Drawing.Point(10, 24);
            this.Tex0FolderTB.Name = "Tex0FolderTB";
            this.Tex0FolderTB.ReadOnly = true;
            this.Tex0FolderTB.Size = new System.Drawing.Size(354, 20);
            this.Tex0FolderTB.TabIndex = 1;
            // 
            // SelTex0FileLabl
            // 
            this.SelTex0FileLabl.AutoSize = true;
            this.SelTex0FileLabl.Location = new System.Drawing.Point(8, 47);
            this.SelTex0FileLabl.Name = "SelTex0FileLabl";
            this.SelTex0FileLabl.Size = new System.Drawing.Size(336, 13);
            this.SelTex0FileLabl.TabIndex = 2;
            this.SelTex0FileLabl.Text = "Select your tex0 file (If you don\'t know where to get this, it\'s pwf2spm).";
            // 
            // Tex0FileTB
            // 
            this.Tex0FileTB.Enabled = false;
            this.Tex0FileTB.Location = new System.Drawing.Point(10, 64);
            this.Tex0FileTB.Name = "Tex0FileTB";
            this.Tex0FileTB.ReadOnly = true;
            this.Tex0FileTB.Size = new System.Drawing.Size(354, 20);
            this.Tex0FileTB.TabIndex = 3;
            // 
            // SelOutputPngFolder
            // 
            this.SelOutputPngFolder.AutoSize = true;
            this.SelOutputPngFolder.Location = new System.Drawing.Point(8, 92);
            this.SelOutputPngFolder.Name = "SelOutputPngFolder";
            this.SelOutputPngFolder.Size = new System.Drawing.Size(396, 13);
            this.SelOutputPngFolder.TabIndex = 4;
            this.SelOutputPngFolder.Text = "Select your output PNG folder (This is where the textures (PNGs) will be extracte" +
    "d).";
            // 
            // OutputPngTB
            // 
            this.OutputPngTB.Enabled = false;
            this.OutputPngTB.Location = new System.Drawing.Point(10, 108);
            this.OutputPngTB.Name = "OutputPngTB";
            this.OutputPngTB.ReadOnly = true;
            this.OutputPngTB.Size = new System.Drawing.Size(354, 20);
            this.OutputPngTB.TabIndex = 5;
            // 
            // SelTex0FolderButton
            // 
            this.SelTex0FolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelTex0FolderButton.Location = new System.Drawing.Point(370, 24);
            this.SelTex0FolderButton.Name = "SelTex0FolderButton";
            this.SelTex0FolderButton.Size = new System.Drawing.Size(101, 20);
            this.SelTex0FolderButton.TabIndex = 6;
            this.SelTex0FolderButton.Text = "Select your folder.";
            this.SelTex0FolderButton.UseVisualStyleBackColor = true;
            this.SelTex0FolderButton.Click += new System.EventHandler(this.SelTex0FolderButton_Click);
            // 
            // SelTex0But
            // 
            this.SelTex0But.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelTex0But.Location = new System.Drawing.Point(370, 64);
            this.SelTex0But.Name = "SelTex0But";
            this.SelTex0But.Size = new System.Drawing.Size(101, 20);
            this.SelTex0But.TabIndex = 7;
            this.SelTex0But.Text = "Select your tex0.";
            this.SelTex0But.UseVisualStyleBackColor = true;
            this.SelTex0But.Click += new System.EventHandler(this.SelTex0But_Click);
            // 
            // SelOutputFolderButt
            // 
            this.SelOutputFolderButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelOutputFolderButt.Location = new System.Drawing.Point(370, 108);
            this.SelOutputFolderButt.Name = "SelOutputFolderButt";
            this.SelOutputFolderButt.Size = new System.Drawing.Size(101, 20);
            this.SelOutputFolderButt.TabIndex = 8;
            this.SelOutputFolderButt.Text = "Select your folder.";
            this.SelOutputFolderButt.UseVisualStyleBackColor = true;
            this.SelOutputFolderButt.Click += new System.EventHandler(this.SelOutputFolderButt_Click);
            // 
            // extButton
            // 
            this.extButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.extButton.Location = new System.Drawing.Point(184, 134);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(112, 23);
            this.extButton.TabIndex = 9;
            this.extButton.Text = "Extract your textures";
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // openTex0
            // 
            this.openTex0.FileName = " ";
            // 
            // seltex0foldinj
            // 
            this.seltex0foldinj.AutoSize = true;
            this.seltex0foldinj.Location = new System.Drawing.Point(9, 7);
            this.seltex0foldinj.Name = "seltex0foldinj";
            this.seltex0foldinj.Size = new System.Drawing.Size(297, 13);
            this.seltex0foldinj.TabIndex = 0;
            this.seltex0foldinj.Text = "Select your tex0 folder (This will be TEXTURES from pwf2int).";
            // 
            // seltex0foldtbinj
            // 
            this.seltex0foldtbinj.Enabled = false;
            this.seltex0foldtbinj.Location = new System.Drawing.Point(12, 24);
            this.seltex0foldtbinj.Name = "seltex0foldtbinj";
            this.seltex0foldtbinj.ReadOnly = true;
            this.seltex0foldtbinj.Size = new System.Drawing.Size(353, 20);
            this.seltex0foldtbinj.TabIndex = 1;
            // 
            // seltex0fileinj
            // 
            this.seltex0fileinj.AutoSize = true;
            this.seltex0fileinj.Location = new System.Drawing.Point(9, 47);
            this.seltex0fileinj.Name = "seltex0fileinj";
            this.seltex0fileinj.Size = new System.Drawing.Size(336, 13);
            this.seltex0fileinj.TabIndex = 2;
            this.seltex0fileinj.Text = "Select your tex0 file (If you don\'t know where to get this, it\'s pwf2spm).";
            // 
            // seltex0fileinjtb
            // 
            this.seltex0fileinjtb.Enabled = false;
            this.seltex0fileinjtb.Location = new System.Drawing.Point(12, 63);
            this.seltex0fileinjtb.Name = "seltex0fileinjtb";
            this.seltex0fileinjtb.ReadOnly = true;
            this.seltex0fileinjtb.Size = new System.Drawing.Size(353, 20);
            this.seltex0fileinjtb.TabIndex = 3;
            // 
            // outpnglab
            // 
            this.outpnglab.AutoSize = true;
            this.outpnglab.Location = new System.Drawing.Point(9, 86);
            this.outpnglab.Name = "outpnglab";
            this.outpnglab.Size = new System.Drawing.Size(396, 13);
            this.outpnglab.TabIndex = 4;
            this.outpnglab.Text = "Select your output PNG folder (This is where the textures (PNGs) will be extracte" +
    "d).";
            // 
            // outputpngtbinj
            // 
            this.outputpngtbinj.Enabled = false;
            this.outputpngtbinj.Location = new System.Drawing.Point(12, 103);
            this.outputpngtbinj.Name = "outputpngtbinj";
            this.outputpngtbinj.ReadOnly = true;
            this.outputpngtbinj.Size = new System.Drawing.Size(353, 20);
            this.outputpngtbinj.TabIndex = 5;
            // 
            // seltexfolderinj
            // 
            this.seltexfolderinj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seltexfolderinj.Location = new System.Drawing.Point(371, 24);
            this.seltexfolderinj.Name = "seltexfolderinj";
            this.seltexfolderinj.Size = new System.Drawing.Size(100, 20);
            this.seltexfolderinj.TabIndex = 6;
            this.seltexfolderinj.Text = "Select your folder.";
            this.seltexfolderinj.UseVisualStyleBackColor = true;
            this.seltexfolderinj.Click += new System.EventHandler(this.seltexfolderinj_Click);
            // 
            // seltex0file
            // 
            this.seltex0file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seltex0file.Location = new System.Drawing.Point(371, 63);
            this.seltex0file.Name = "seltex0file";
            this.seltex0file.Size = new System.Drawing.Size(100, 20);
            this.seltex0file.TabIndex = 7;
            this.seltex0file.Text = "Select your tex0.";
            this.seltex0file.UseVisualStyleBackColor = true;
            this.seltex0file.Click += new System.EventHandler(this.seltex0file_Click);
            // 
            // selpngfold
            // 
            this.selpngfold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selpngfold.Location = new System.Drawing.Point(371, 103);
            this.selpngfold.Name = "selpngfold";
            this.selpngfold.Size = new System.Drawing.Size(100, 20);
            this.selpngfold.TabIndex = 8;
            this.selpngfold.Text = "Select your folder.";
            this.selpngfold.UseVisualStyleBackColor = true;
            this.selpngfold.Click += new System.EventHandler(this.selpngfold_Click);
            // 
            // injpng
            // 
            this.injpng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.injpng.Location = new System.Drawing.Point(188, 134);
            this.injpng.Name = "injpng";
            this.injpng.Size = new System.Drawing.Size(108, 23);
            this.injpng.TabIndex = 9;
            this.injpng.Text = "Inject your PNGs!";
            this.injpng.UseVisualStyleBackColor = true;
            this.injpng.Click += new System.EventHandler(this.injpng_Click);
            // 
            // pwf2tex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 186);
            this.Controls.Add(this.texTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pwf2tex";
            this.Text = "pwf2tex";
            this.Activated += new System.EventHandler(this.pwf2tex_Activated);
            this.texTabControl.ResumeLayout(false);
            this.extractTab.ResumeLayout(false);
            this.extractTab.PerformLayout();
            this.injectTab.ResumeLayout(false);
            this.injectTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl texTabControl;
        private System.Windows.Forms.TabPage extractTab;
        private System.Windows.Forms.TabPage injectTab;
        private System.Windows.Forms.TextBox OutputPngTB;
        private System.Windows.Forms.Label SelOutputPngFolder;
        private System.Windows.Forms.TextBox Tex0FileTB;
        private System.Windows.Forms.Label SelTex0FileLabl;
        private System.Windows.Forms.TextBox Tex0FolderTB;
        private System.Windows.Forms.Label SelTex0FolderLabl;
        private System.Windows.Forms.Button SelTex0But;
        private System.Windows.Forms.Button SelTex0FolderButton;
        private System.Windows.Forms.Button SelOutputFolderButt;
        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.OpenFileDialog openTex0;
        private System.Windows.Forms.TextBox seltex0foldtbinj;
        private System.Windows.Forms.Label seltex0foldinj;
        private System.Windows.Forms.TextBox outputpngtbinj;
        private System.Windows.Forms.Label outpnglab;
        private System.Windows.Forms.TextBox seltex0fileinjtb;
        private System.Windows.Forms.Label seltex0fileinj;
        private System.Windows.Forms.Button injpng;
        private System.Windows.Forms.Button selpngfold;
        private System.Windows.Forms.Button seltex0file;
        private System.Windows.Forms.Button seltexfolderinj;
    }
}