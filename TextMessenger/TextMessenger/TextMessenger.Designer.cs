namespace TextMessenger
{
    partial class TextMessenger
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.messengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signIn = new System.Windows.Forms.Button();
            this.remember = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Phonenumber = new System.Windows.Forms.TextBox();
            this.newAccount = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messengerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // messengerToolStripMenuItem
            // 
            this.messengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.messengerToolStripMenuItem.Name = "messengerToolStripMenuItem";
            this.messengerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.messengerToolStripMenuItem.Text = "Messenger";
            // 
            // singOutToolStripMenuItem
            // 
            this.singOutToolStripMenuItem.Name = "singOutToolStripMenuItem";
            this.singOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.singOutToolStripMenuItem.Text = "Sing Out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.signIn);
            this.panel1.Controls.Add(this.remember);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Phonenumber);
            this.panel1.Controls.Add(this.newAccount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 335);
            this.panel1.TabIndex = 1;
            // 
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(96, 177);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(75, 23);
            this.signIn.TabIndex = 6;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            // 
            // remember
            // 
            this.remember.AutoSize = true;
            this.remember.Location = new System.Drawing.Point(29, 131);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(217, 17);
            this.remember.TabIndex = 5;
            this.remember.Text = "Remember phone number and password";
            this.remember.UseVisualStyleBackColor = true;
            this.remember.CheckedChanged += new System.EventHandler(this.remember_CheckedChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(29, 104);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(142, 20);
            this.password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Phonenumber
            // 
            this.Phonenumber.Location = new System.Drawing.Point(29, 56);
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(142, 20);
            this.Phonenumber.TabIndex = 2;
            // 
            // newAccount
            // 
            this.newAccount.AutoSize = true;
            this.newAccount.Location = new System.Drawing.Point(65, 271);
            this.newAccount.Name = "newAccount";
            this.newAccount.Size = new System.Drawing.Size(98, 13);
            this.newAccount.TabIndex = 1;
            this.newAccount.TabStop = true;
            this.newAccount.Text = "Get a new account";
            this.newAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newAccount_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number:";
            // 
            // TextMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextMessenger";
            this.Text = "Text Messenger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem messengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phonenumber;
        private System.Windows.Forms.LinkLabel newAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.CheckBox remember;
    }
}

