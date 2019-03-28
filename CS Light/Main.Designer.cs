namespace CS_Light
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.strpInfo = new System.Windows.Forms.StatusStrip();
            this.tssldateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbbooks = new System.Windows.Forms.GroupBox();
            this.btcom = new System.Windows.Forms.Button();
            this.lblcomplains = new System.Windows.Forms.Label();
            this.btair = new System.Windows.Forms.Button();
            this.lblaircraft = new System.Windows.Forms.Label();
            this.btcle = new System.Windows.Forms.Button();
            this.lblcleaner = new System.Windows.Forms.Label();
            this.bteng = new System.Windows.Forms.Button();
            this.lblengineer = new System.Windows.Forms.Label();
            this.lblquest = new System.Windows.Forms.Label();
            this.lbldesc2 = new System.Windows.Forms.Label();
            this.lbldesc1 = new System.Windows.Forms.Label();
            this.gbsystem = new System.Windows.Forms.GroupBox();
            this.btclose = new System.Windows.Forms.Button();
            this.btconnect = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.strpInfo.SuspendLayout();
            this.gbbooks.SuspendLayout();
            this.gbsystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // strpInfo
            // 
            this.strpInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strpInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssldateTime,
            this.tsslCon});
            this.strpInfo.Location = new System.Drawing.Point(0, 225);
            this.strpInfo.Name = "strpInfo";
            this.strpInfo.Size = new System.Drawing.Size(398, 22);
            this.strpInfo.TabIndex = 26;
            this.strpInfo.Text = "statusStrip1";
            // 
            // tssldateTime
            // 
            this.tssldateTime.Name = "tssldateTime";
            this.tssldateTime.Size = new System.Drawing.Size(126, 17);
            this.tssldateTime.Text = "00:00:00/00.00.0000";
            // 
            // tsslCon
            // 
            this.tsslCon.Name = "tsslCon";
            this.tsslCon.Size = new System.Drawing.Size(12, 17);
            this.tsslCon.Text = "-";
            this.tsslCon.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbbooks
            // 
            this.gbbooks.Controls.Add(this.lblquest);
            this.gbbooks.Controls.Add(this.lbldesc2);
            this.gbbooks.Controls.Add(this.lbldesc1);
            this.gbbooks.Controls.Add(this.btcom);
            this.gbbooks.Controls.Add(this.lblcomplains);
            this.gbbooks.Controls.Add(this.btair);
            this.gbbooks.Controls.Add(this.lblaircraft);
            this.gbbooks.Controls.Add(this.btcle);
            this.gbbooks.Controls.Add(this.lblcleaner);
            this.gbbooks.Controls.Add(this.bteng);
            this.gbbooks.Controls.Add(this.lblengineer);
            this.gbbooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbbooks.Location = new System.Drawing.Point(12, 12);
            this.gbbooks.Name = "gbbooks";
            this.gbbooks.Size = new System.Drawing.Size(374, 137);
            this.gbbooks.TabIndex = 27;
            this.gbbooks.TabStop = false;
            this.gbbooks.Text = "Books available to you";
            // 
            // btcom
            // 
            this.btcom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btcom.Cursor = System.Windows.Forms.Cursors.Default;
            this.btcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btcom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcom.Location = new System.Drawing.Point(324, 57);
            this.btcom.Name = "btcom";
            this.btcom.Size = new System.Drawing.Size(37, 25);
            this.btcom.TabIndex = 29;
            this.btcom.Text = "Go";
            this.btcom.UseVisualStyleBackColor = false;
            this.btcom.Click += new System.EventHandler(this.btcom_Click);
            // 
            // lblcomplains
            // 
            this.lblcomplains.AutoSize = true;
            this.lblcomplains.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcomplains.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcomplains.ForeColor = System.Drawing.SystemColors.Window;
            this.lblcomplains.Location = new System.Drawing.Point(187, 64);
            this.lblcomplains.Name = "lblcomplains";
            this.lblcomplains.Size = new System.Drawing.Size(126, 18);
            this.lblcomplains.TabIndex = 28;
            this.lblcomplains.Text = "Complaints book";
            // 
            // btair
            // 
            this.btair.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btair.Cursor = System.Windows.Forms.Cursors.Default;
            this.btair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btair.Location = new System.Drawing.Point(324, 20);
            this.btair.Name = "btair";
            this.btair.Size = new System.Drawing.Size(37, 25);
            this.btair.TabIndex = 27;
            this.btair.Text = "Go";
            this.btair.UseVisualStyleBackColor = false;
            this.btair.Click += new System.EventHandler(this.btair_Click);
            // 
            // lblaircraft
            // 
            this.lblaircraft.AutoSize = true;
            this.lblaircraft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblaircraft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblaircraft.ForeColor = System.Drawing.SystemColors.Window;
            this.lblaircraft.Location = new System.Drawing.Point(187, 27);
            this.lblaircraft.Name = "lblaircraft";
            this.lblaircraft.Size = new System.Drawing.Size(97, 18);
            this.lblaircraft.TabIndex = 26;
            this.lblaircraft.Text = "Aircraft book";
            // 
            // btcle
            // 
            this.btcle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btcle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btcle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btcle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcle.Location = new System.Drawing.Point(122, 60);
            this.btcle.Name = "btcle";
            this.btcle.Size = new System.Drawing.Size(37, 25);
            this.btcle.TabIndex = 25;
            this.btcle.Text = "Go";
            this.btcle.UseVisualStyleBackColor = false;
            this.btcle.Click += new System.EventHandler(this.btcle_Click);
            // 
            // lblcleaner
            // 
            this.lblcleaner.AutoSize = true;
            this.lblcleaner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcleaner.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcleaner.ForeColor = System.Drawing.SystemColors.Window;
            this.lblcleaner.Location = new System.Drawing.Point(6, 64);
            this.lblcleaner.Name = "lblcleaner";
            this.lblcleaner.Size = new System.Drawing.Size(102, 18);
            this.lblcleaner.TabIndex = 24;
            this.lblcleaner.Text = "Cleaner book";
            // 
            // bteng
            // 
            this.bteng.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bteng.Cursor = System.Windows.Forms.Cursors.Default;
            this.bteng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteng.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bteng.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bteng.Location = new System.Drawing.Point(122, 23);
            this.bteng.Name = "bteng";
            this.bteng.Size = new System.Drawing.Size(37, 25);
            this.bteng.TabIndex = 23;
            this.bteng.Text = "Go";
            this.bteng.UseVisualStyleBackColor = false;
            this.bteng.Click += new System.EventHandler(this.bteng_Click);
            // 
            // lblengineer
            // 
            this.lblengineer.AutoSize = true;
            this.lblengineer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblengineer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblengineer.ForeColor = System.Drawing.SystemColors.Window;
            this.lblengineer.Location = new System.Drawing.Point(6, 27);
            this.lblengineer.Name = "lblengineer";
            this.lblengineer.Size = new System.Drawing.Size(110, 18);
            this.lblengineer.TabIndex = 22;
            this.lblengineer.Text = "Engineer book";
            // 
            // lblquest
            // 
            this.lblquest.AutoSize = true;
            this.lblquest.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblquest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblquest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblquest.Location = new System.Drawing.Point(160, 115);
            this.lblquest.Name = "lblquest";
            this.lblquest.Size = new System.Drawing.Size(195, 16);
            this.lblquest.TabIndex = 32;
            this.lblquest.Text = "For questions contact the admin";
            // 
            // lbldesc2
            // 
            this.lbldesc2.AutoSize = true;
            this.lbldesc2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldesc2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbldesc2.Location = new System.Drawing.Point(6, 116);
            this.lbldesc2.Name = "lbldesc2";
            this.lbldesc2.Size = new System.Drawing.Size(156, 16);
            this.lbldesc2.TabIndex = 31;
            this.lbldesc2.Text = "provided by your account.";
            // 
            // lbldesc1
            // 
            this.lbldesc1.AutoSize = true;
            this.lbldesc1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldesc1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbldesc1.Location = new System.Drawing.Point(6, 100);
            this.lbldesc1.Name = "lbldesc1";
            this.lbldesc1.Size = new System.Drawing.Size(349, 16);
            this.lbldesc1.TabIndex = 30;
            this.lbldesc1.Text = "Keep in mind that you have access to those books that are";
            // 
            // gbsystem
            // 
            this.gbsystem.Controls.Add(this.btclose);
            this.gbsystem.Controls.Add(this.btconnect);
            this.gbsystem.Controls.Add(this.btlogout);
            this.gbsystem.Controls.Add(this.btlogin);
            this.gbsystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbsystem.Location = new System.Drawing.Point(12, 155);
            this.gbsystem.Name = "gbsystem";
            this.gbsystem.Size = new System.Drawing.Size(374, 63);
            this.gbsystem.TabIndex = 28;
            this.gbsystem.TabStop = false;
            this.gbsystem.Text = "System";
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btclose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btclose.Location = new System.Drawing.Point(280, 20);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(81, 31);
            this.btclose.TabIndex = 29;
            this.btclose.Text = "Quit app";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btconnect
            // 
            this.btconnect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btconnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btconnect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btconnect.Location = new System.Drawing.Point(153, 20);
            this.btconnect.Name = "btconnect";
            this.btconnect.Size = new System.Drawing.Size(121, 31);
            this.btconnect.TabIndex = 27;
            this.btconnect.Text = "Connection setup";
            this.btconnect.UseVisualStyleBackColor = false;
            this.btconnect.Click += new System.EventHandler(this.btconnect_Click);
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btlogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btlogout.Location = new System.Drawing.Point(79, 20);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(63, 31);
            this.btlogout.TabIndex = 25;
            this.btlogout.Text = "Log out";
            this.btlogout.UseVisualStyleBackColor = false;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btlogin.Location = new System.Drawing.Point(9, 20);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(58, 31);
            this.btlogin.TabIndex = 23;
            this.btlogin.Text = "Log in";
            this.btlogin.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(398, 247);
            this.Controls.Add(this.gbsystem);
            this.Controls.Add(this.gbbooks);
            this.Controls.Add(this.strpInfo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your book";
            this.Load += new System.EventHandler(this.Main_Load);
            this.strpInfo.ResumeLayout(false);
            this.strpInfo.PerformLayout();
            this.gbbooks.ResumeLayout(false);
            this.gbbooks.PerformLayout();
            this.gbsystem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip strpInfo;
        private System.Windows.Forms.ToolStripStatusLabel tssldateTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslCon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbbooks;
        private System.Windows.Forms.Label lblquest;
        private System.Windows.Forms.Label lbldesc2;
        private System.Windows.Forms.Label lbldesc1;
        private System.Windows.Forms.Button btcom;
        private System.Windows.Forms.Label lblcomplains;
        private System.Windows.Forms.Button btair;
        private System.Windows.Forms.Label lblaircraft;
        private System.Windows.Forms.Button btcle;
        private System.Windows.Forms.Label lblcleaner;
        private System.Windows.Forms.Button bteng;
        private System.Windows.Forms.Label lblengineer;
        private System.Windows.Forms.GroupBox gbsystem;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Button btconnect;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btlogin;
    }
}