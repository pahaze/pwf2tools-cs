namespace pwf2tools
{
    partial class pwf2tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwf2tools));
            this.pwfint = new System.Windows.Forms.Button();
            this.pwftex = new System.Windows.Forms.Button();
            this.pwfspm = new System.Windows.Forms.Button();
            this.pwfhat = new System.Windows.Forms.Button();
            this.buildtxt = new System.Windows.Forms.Label();
            this.abt = new System.Windows.Forms.LinkLabel();
            this.stngs = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pwfint
            // 
            this.pwfint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwfint.Location = new System.Drawing.Point(12, 13);
            this.pwfint.Name = "pwfint";
            this.pwfint.Size = new System.Drawing.Size(78, 78);
            this.pwfint.TabIndex = 0;
            this.pwfint.Text = "pwf2int";
            this.pwfint.UseVisualStyleBackColor = true;
            this.pwfint.Click += new System.EventHandler(this.pwfint_Click);
            // 
            // pwftex
            // 
            this.pwftex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwftex.Location = new System.Drawing.Point(96, 13);
            this.pwftex.Name = "pwftex";
            this.pwftex.Size = new System.Drawing.Size(78, 78);
            this.pwftex.TabIndex = 1;
            this.pwftex.Text = "pwf2tex\r\n";
            this.pwftex.UseVisualStyleBackColor = true;
            this.pwftex.Click += new System.EventHandler(this.pwftex_Click);
            // 
            // pwfspm
            // 
            this.pwfspm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwfspm.Location = new System.Drawing.Point(180, 13);
            this.pwfspm.Name = "pwfspm";
            this.pwfspm.Size = new System.Drawing.Size(78, 78);
            this.pwfspm.TabIndex = 2;
            this.pwfspm.Text = "pwf2spm";
            this.pwfspm.UseVisualStyleBackColor = true;
            this.pwfspm.Click += new System.EventHandler(this.pwfspm_Click);
            // 
            // pwfhat
            // 
            this.pwfhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwfhat.Location = new System.Drawing.Point(264, 13);
            this.pwfhat.Name = "pwfhat";
            this.pwfhat.Size = new System.Drawing.Size(78, 78);
            this.pwfhat.TabIndex = 3;
            this.pwfhat.Text = "pwf2hat";
            this.pwfhat.UseVisualStyleBackColor = true;
            this.pwfhat.Click += new System.EventHandler(this.pwfhat_Click);
            // 
            // buildtxt
            // 
            this.buildtxt.AutoSize = true;
            this.buildtxt.Location = new System.Drawing.Point(12, 100);
            this.buildtxt.Name = "buildtxt";
            this.buildtxt.Size = new System.Drawing.Size(231, 13);
            this.buildtxt.TabIndex = 5;
            this.buildtxt.Text = "This build was created on December 8th, 2020.";
            // 
            // abt
            // 
            this.abt.AutoSize = true;
            this.abt.Location = new System.Drawing.Point(307, 100);
            this.abt.Name = "abt";
            this.abt.Size = new System.Drawing.Size(35, 13);
            this.abt.TabIndex = 6;
            this.abt.TabStop = true;
            this.abt.Text = "About";
            this.abt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.abt_LinkClicked);
            // 
            // stngs
            // 
            this.stngs.AutoSize = true;
            this.stngs.Location = new System.Drawing.Point(261, 100);
            this.stngs.Name = "stngs";
            this.stngs.Size = new System.Drawing.Size(45, 13);
            this.stngs.TabIndex = 7;
            this.stngs.TabStop = true;
            this.stngs.Text = "Settings";
            this.stngs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.stngs_LinkClicked);
            // 
            // pwf2tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 122);
            this.Controls.Add(this.stngs);
            this.Controls.Add(this.abt);
            this.Controls.Add(this.buildtxt);
            this.Controls.Add(this.pwfhat);
            this.Controls.Add(this.pwfspm);
            this.Controls.Add(this.pwftex);
            this.Controls.Add(this.pwfint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pwf2tools";
            this.Text = "pwf2tools";
            this.Activated += new System.EventHandler(this.pwf2tools_Activated);
            this.Load += new System.EventHandler(this.pwf2tools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pwfint;
        private System.Windows.Forms.Button pwftex;
        private System.Windows.Forms.Button pwfspm;
        private System.Windows.Forms.Button pwfhat;
        private System.Windows.Forms.Label buildtxt;
        private System.Windows.Forms.LinkLabel abt;
        private System.Windows.Forms.LinkLabel stngs;
    }
}

