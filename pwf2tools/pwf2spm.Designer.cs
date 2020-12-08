namespace pwf2tools
{
    partial class pwf2spm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwf2spm));
            this.spmfilelocation = new System.Windows.Forms.Label();
            this.SPMFileLocationTB = new System.Windows.Forms.TextBox();
            this.openSPM = new System.Windows.Forms.Button();
            this.outputtex0lab = new System.Windows.Forms.Label();
            this.outputTex0TB = new System.Windows.Forms.TextBox();
            this.outputTex0Button = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.openSPMdiag = new System.Windows.Forms.OpenFileDialog();
            this.saveSPMdiag = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // spmfilelocation
            // 
            this.spmfilelocation.AutoSize = true;
            this.spmfilelocation.Location = new System.Drawing.Point(10, 9);
            this.spmfilelocation.Name = "spmfilelocation";
            this.spmfilelocation.Size = new System.Drawing.Size(89, 13);
            this.spmfilelocation.TabIndex = 0;
            this.spmfilelocation.Text = "SPM file location:";
            // 
            // SPMFileLocationTB
            // 
            this.SPMFileLocationTB.Enabled = false;
            this.SPMFileLocationTB.Location = new System.Drawing.Point(13, 26);
            this.SPMFileLocationTB.Name = "SPMFileLocationTB";
            this.SPMFileLocationTB.ReadOnly = true;
            this.SPMFileLocationTB.Size = new System.Drawing.Size(268, 20);
            this.SPMFileLocationTB.TabIndex = 1;
            // 
            // openSPM
            // 
            this.openSPM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openSPM.Location = new System.Drawing.Point(287, 26);
            this.openSPM.Name = "openSPM";
            this.openSPM.Size = new System.Drawing.Size(89, 20);
            this.openSPM.TabIndex = 2;
            this.openSPM.Text = "Open an SPM";
            this.openSPM.UseVisualStyleBackColor = true;
            this.openSPM.Click += new System.EventHandler(this.openSPM_Click);
            // 
            // outputtex0lab
            // 
            this.outputtex0lab.AutoSize = true;
            this.outputtex0lab.Location = new System.Drawing.Point(10, 49);
            this.outputtex0lab.Name = "outputtex0lab";
            this.outputtex0lab.Size = new System.Drawing.Size(81, 13);
            this.outputtex0lab.TabIndex = 3;
            this.outputtex0lab.Text = "Output tex0 file:";
            // 
            // outputTex0TB
            // 
            this.outputTex0TB.Enabled = false;
            this.outputTex0TB.Location = new System.Drawing.Point(13, 66);
            this.outputTex0TB.Name = "outputTex0TB";
            this.outputTex0TB.ReadOnly = true;
            this.outputTex0TB.Size = new System.Drawing.Size(268, 20);
            this.outputTex0TB.TabIndex = 4;
            // 
            // outputTex0Button
            // 
            this.outputTex0Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outputTex0Button.Location = new System.Drawing.Point(287, 66);
            this.outputTex0Button.Name = "outputTex0Button";
            this.outputTex0Button.Size = new System.Drawing.Size(89, 20);
            this.outputTex0Button.TabIndex = 5;
            this.outputTex0Button.Text = "Save your tex0";
            this.outputTex0Button.UseVisualStyleBackColor = true;
            this.outputTex0Button.Click += new System.EventHandler(this.outputTex0Button_Click);
            // 
            // finishButton
            // 
            this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finishButton.Location = new System.Drawing.Point(158, 94);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(88, 23);
            this.finishButton.TabIndex = 6;
            this.finishButton.Text = "Save your tex0";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // openSPMdiag
            // 
            this.openSPMdiag.FileName = "openSPMdiag";
            // 
            // pwf2spm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 129);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.outputTex0Button);
            this.Controls.Add(this.outputTex0TB);
            this.Controls.Add(this.outputtex0lab);
            this.Controls.Add(this.openSPM);
            this.Controls.Add(this.SPMFileLocationTB);
            this.Controls.Add(this.spmfilelocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pwf2spm";
            this.Text = "pwf2spm";
            this.Activated += new System.EventHandler(this.pwf2spm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label spmfilelocation;
        private System.Windows.Forms.TextBox SPMFileLocationTB;
        private System.Windows.Forms.Button openSPM;
        private System.Windows.Forms.Label outputtex0lab;
        private System.Windows.Forms.TextBox outputTex0TB;
        private System.Windows.Forms.Button outputTex0Button;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.OpenFileDialog openSPMdiag;
        private System.Windows.Forms.SaveFileDialog saveSPMdiag;
    }
}