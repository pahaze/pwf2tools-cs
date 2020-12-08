namespace pwf2tools
{
    partial class pwf2about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwf2about));
            this.whatIs = new System.Windows.Forms.Label();
            this.whatisText = new System.Windows.Forms.Label();
            this.special = new System.Windows.Forms.Label();
            this.specialText = new System.Windows.Forms.Label();
            this.links = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p2tools = new System.Windows.Forms.Label();
            this.visualgit = new System.Windows.Forms.LinkLabel();
            this.richgit = new System.Windows.Forms.LinkLabel();
            this.mygit = new System.Windows.Forms.LinkLabel();
            this.ptr2serv = new System.Windows.Forms.LinkLabel();
            this.pwf2deb = new System.Windows.Forms.LinkLabel();
            this.failure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // whatIs
            // 
            this.whatIs.AutoSize = true;
            this.whatIs.Location = new System.Drawing.Point(13, 13);
            this.whatIs.Name = "whatIs";
            this.whatIs.Size = new System.Drawing.Size(97, 13);
            this.whatIs.TabIndex = 0;
            this.whatIs.Text = "What is pwf2tools?";
            // 
            // whatisText
            // 
            this.whatisText.AutoSize = true;
            this.whatisText.Location = new System.Drawing.Point(16, 30);
            this.whatisText.Name = "whatisText";
            this.whatisText.Size = new System.Drawing.Size(761, 26);
            this.whatisText.TabIndex = 1;
            this.whatisText.Text = resources.GetString("whatisText.Text");
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.Location = new System.Drawing.Point(13, 67);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(80, 13);
            this.special.TabIndex = 2;
            this.special.Text = "Special thanks:";
            // 
            // specialText
            // 
            this.specialText.AutoSize = true;
            this.specialText.Location = new System.Drawing.Point(19, 84);
            this.specialText.Name = "specialText";
            this.specialText.Size = new System.Drawing.Size(786, 39);
            this.specialText.TabIndex = 3;
            this.specialText.Text = resources.GetString("specialText.Text");
            // 
            // links
            // 
            this.links.AutoSize = true;
            this.links.Location = new System.Drawing.Point(16, 136);
            this.links.Name = "links";
            this.links.Size = new System.Drawing.Size(32, 13);
            this.links.TabIndex = 4;
            this.links.Text = "Links";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pwf2tools.Properties.Resources._43ac58c778b77624fc53187dd1b876ee;
            this.pictureBox1.Location = new System.Drawing.Point(671, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // p2tools
            // 
            this.p2tools.AutoSize = true;
            this.p2tools.Location = new System.Drawing.Point(559, 225);
            this.p2tools.Name = "p2tools";
            this.p2tools.Size = new System.Drawing.Size(106, 13);
            this.p2tools.TabIndex = 6;
            this.p2tools.Text = "pwf2tools, by frylock.";
            // 
            // visualgit
            // 
            this.visualgit.AutoSize = true;
            this.visualgit.Location = new System.Drawing.Point(22, 153);
            this.visualgit.Name = "visualgit";
            this.visualgit.Size = new System.Drawing.Size(78, 13);
            this.visualgit.TabIndex = 7;
            this.visualgit.TabStop = true;
            this.visualgit.Text = "Visual\'s GitHub";
            this.visualgit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.visualgit_LinkClicked);
            // 
            // richgit
            // 
            this.richgit.AutoSize = true;
            this.richgit.Location = new System.Drawing.Point(22, 166);
            this.richgit.Name = "richgit";
            this.richgit.Size = new System.Drawing.Size(72, 13);
            this.richgit.TabIndex = 8;
            this.richgit.TabStop = true;
            this.richgit.Text = "Rich\'s GitHub";
            this.richgit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.richgit_LinkClicked);
            // 
            // mygit
            // 
            this.mygit.AutoSize = true;
            this.mygit.Location = new System.Drawing.Point(22, 179);
            this.mygit.Name = "mygit";
            this.mygit.Size = new System.Drawing.Size(57, 13);
            this.mygit.TabIndex = 9;
            this.mygit.TabStop = true;
            this.mygit.Text = "My GitHub";
            this.mygit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mygit_LinkClicked);
            // 
            // ptr2serv
            // 
            this.ptr2serv.AutoSize = true;
            this.ptr2serv.Location = new System.Drawing.Point(22, 206);
            this.ptr2serv.Name = "ptr2serv";
            this.ptr2serv.Size = new System.Drawing.Size(110, 13);
            this.ptr2serv.TabIndex = 10;
            this.ptr2serv.TabStop = true;
            this.ptr2serv.Text = "PTR2 modding server";
            this.ptr2serv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ptr2serv_LinkClicked);
            // 
            // pwf2deb
            // 
            this.pwf2deb.AutoSize = true;
            this.pwf2deb.Location = new System.Drawing.Point(22, 193);
            this.pwf2deb.Name = "pwf2deb";
            this.pwf2deb.Size = new System.Drawing.Size(169, 13);
            this.pwf2deb.TabIndex = 11;
            this.pwf2deb.TabStop = true;
            this.pwf2deb.Text = "pwf2tools executable source code";
            this.pwf2deb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pwf2deb_LinkClicked);
            // 
            // failure
            // 
            this.failure.AutoSize = true;
            this.failure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failure.Location = new System.Drawing.Point(559, 212);
            this.failure.Name = "failure";
            this.failure.Size = new System.Drawing.Size(96, 13);
            this.failure.TabIndex = 12;
            this.failure.Text = "\"fry\'s little failure...\"";
            // 
            // pwf2about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.failure);
            this.Controls.Add(this.pwf2deb);
            this.Controls.Add(this.ptr2serv);
            this.Controls.Add(this.mygit);
            this.Controls.Add(this.richgit);
            this.Controls.Add(this.visualgit);
            this.Controls.Add(this.p2tools);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.links);
            this.Controls.Add(this.specialText);
            this.Controls.Add(this.special);
            this.Controls.Add(this.whatisText);
            this.Controls.Add(this.whatIs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pwf2about";
            this.Text = "pwf2about";
            this.Activated += new System.EventHandler(this.pwf2about_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whatIs;
        private System.Windows.Forms.Label whatisText;
        private System.Windows.Forms.Label special;
        private System.Windows.Forms.Label specialText;
        private System.Windows.Forms.Label links;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label p2tools;
        private System.Windows.Forms.LinkLabel visualgit;
        private System.Windows.Forms.LinkLabel richgit;
        private System.Windows.Forms.LinkLabel mygit;
        private System.Windows.Forms.LinkLabel ptr2serv;
        private System.Windows.Forms.LinkLabel pwf2deb;
        private System.Windows.Forms.Label failure;
    }
}