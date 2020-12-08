namespace pwf2tools
{
    partial class pwf2settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwf2settings));
            this.themeSetting = new System.Windows.Forms.ComboBox();
            this.themetxt = new System.Windows.Forms.Label();
            this.EnableRPCBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.enableToolexit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // themeSetting
            // 
            this.themeSetting.FormattingEnabled = true;
            this.themeSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.themeSetting.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.themeSetting.Location = new System.Drawing.Point(12, 29);
            this.themeSetting.Name = "themeSetting";
            this.themeSetting.Size = new System.Drawing.Size(121, 21);
            this.themeSetting.TabIndex = 0;
            // 
            // themetxt
            // 
            this.themetxt.AutoSize = true;
            this.themetxt.Location = new System.Drawing.Point(9, 13);
            this.themetxt.Name = "themetxt";
            this.themetxt.Size = new System.Drawing.Size(43, 13);
            this.themetxt.TabIndex = 1;
            this.themetxt.Text = "Theme:";
            // 
            // EnableRPCBox
            // 
            this.EnableRPCBox.AutoSize = true;
            this.EnableRPCBox.Location = new System.Drawing.Point(222, 13);
            this.EnableRPCBox.Name = "EnableRPCBox";
            this.EnableRPCBox.Size = new System.Drawing.Size(120, 17);
            this.EnableRPCBox.TabIndex = 2;
            this.EnableRPCBox.Text = "Enable DiscordRPC";
            this.EnableRPCBox.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(141, 67);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // enableToolexit
            // 
            this.enableToolexit.AutoSize = true;
            this.enableToolexit.Location = new System.Drawing.Point(222, 32);
            this.enableToolexit.Name = "enableToolexit";
            this.enableToolexit.Size = new System.Drawing.Size(133, 17);
            this.enableToolexit.TabIndex = 4;
            this.enableToolexit.Text = "Enable exit on tool use";
            this.enableToolexit.UseVisualStyleBackColor = true;
            // 
            // pwf2settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 98);
            this.Controls.Add(this.enableToolexit);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.EnableRPCBox);
            this.Controls.Add(this.themetxt);
            this.Controls.Add(this.themeSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pwf2settings";
            this.Text = "pwf2settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox themeSetting;
        private System.Windows.Forms.Label themetxt;
        private System.Windows.Forms.CheckBox EnableRPCBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox enableToolexit;
    }
}