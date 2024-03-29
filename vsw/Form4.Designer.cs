namespace vsw
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.createuserlinklable = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.createuserlinklable);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 840);
            this.panel1.TabIndex = 3;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.linkLabel2.Location = new System.Drawing.Point(14, 474);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(74, 24);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Logout";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // createuserlinklable
            // 
            this.createuserlinklable.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.createuserlinklable.AutoSize = true;
            this.createuserlinklable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.createuserlinklable.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.createuserlinklable.Location = new System.Drawing.Point(14, 120);
            this.createuserlinklable.Name = "createuserlinklable";
            this.createuserlinklable.Size = new System.Drawing.Size(118, 24);
            this.createuserlinklable.TabIndex = 1;
            this.createuserlinklable.TabStop = true;
            this.createuserlinklable.Text = "Create user";
            this.createuserlinklable.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.createuserlinklable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createuserlinklable_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.linkLabel1.Location = new System.Drawing.Point(14, 73);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 24);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get all users";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(940, 506);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel createuserlinklable;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}