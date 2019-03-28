namespace CS_Light
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.btenter = new System.Windows.Forms.Button();
            this.lblquest = new System.Windows.Forms.Label();
            this.lblgosign = new System.Windows.Forms.Label();
            this.lbldescr = new System.Windows.Forms.Label();
            this.lblserv = new System.Windows.Forms.Label();
            this.cbserver = new System.Windows.Forms.ComboBox();
            this.cbdata = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btcheck = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.statusConnect = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblogin
            // 
            this.tblogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tblogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tblogin.ForeColor = System.Drawing.SystemColors.Info;
            this.tblogin.Location = new System.Drawing.Point(7, 129);
            this.tblogin.Multiline = true;
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(181, 24);
            this.tblogin.TabIndex = 0;
            this.tblogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbpass
            // 
            this.tbpass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpass.ForeColor = System.Drawing.SystemColors.Info;
            this.tbpass.Location = new System.Drawing.Point(7, 162);
            this.tbpass.Multiline = true;
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(138, 24);
            this.tbpass.TabIndex = 1;
            this.tbpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btenter
            // 
            this.btenter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btenter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btenter.Location = new System.Drawing.Point(202, 126);
            this.btenter.Name = "btenter";
            this.btenter.Size = new System.Drawing.Size(75, 30);
            this.btenter.TabIndex = 3;
            this.btenter.Text = "Enter";
            this.btenter.UseVisualStyleBackColor = false;
            this.btenter.Click += new System.EventHandler(this.btenter_Click);
            // 
            // lblquest
            // 
            this.lblquest.AutoSize = true;
            this.lblquest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblquest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblquest.Location = new System.Drawing.Point(151, 170);
            this.lblquest.Name = "lblquest";
            this.lblquest.Size = new System.Drawing.Size(81, 16);
            this.lblquest.TabIndex = 5;
            this.lblquest.Text = "No account?";
            // 
            // lblgosign
            // 
            this.lblgosign.AutoSize = true;
            this.lblgosign.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblgosign.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblgosign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblgosign.Location = new System.Drawing.Point(227, 170);
            this.lblgosign.Name = "lblgosign";
            this.lblgosign.Size = new System.Drawing.Size(52, 16);
            this.lblgosign.TabIndex = 6;
            this.lblgosign.Text = "Sign up";
            // 
            // lbldescr
            // 
            this.lbldescr.AutoSize = true;
            this.lbldescr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldescr.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldescr.ForeColor = System.Drawing.SystemColors.Window;
            this.lbldescr.Location = new System.Drawing.Point(4, 103);
            this.lbldescr.Name = "lbldescr";
            this.lbldescr.Size = new System.Drawing.Size(277, 17);
            this.lbldescr.TabIndex = 7;
            this.lbldescr.Text = "Enter your login and password to connect";
            // 
            // lblserv
            // 
            this.lblserv.AutoSize = true;
            this.lblserv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblserv.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblserv.ForeColor = System.Drawing.SystemColors.Window;
            this.lblserv.Location = new System.Drawing.Point(10, 6);
            this.lblserv.Name = "lblserv";
            this.lblserv.Size = new System.Drawing.Size(176, 17);
            this.lblserv.TabIndex = 9;
            this.lblserv.Text = "Choose server to connect";
            // 
            // cbserver
            // 
            this.cbserver.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbserver.FormattingEnabled = true;
            this.cbserver.Location = new System.Drawing.Point(7, 26);
            this.cbserver.Name = "cbserver";
            this.cbserver.Size = new System.Drawing.Size(181, 21);
            this.cbserver.TabIndex = 10;
            // 
            // cbdata
            // 
            this.cbdata.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdata.FormattingEnabled = true;
            this.cbdata.Location = new System.Drawing.Point(7, 70);
            this.cbdata.Name = "cbdata";
            this.cbdata.Size = new System.Drawing.Size(181, 21);
            this.cbdata.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose data source to use";
            // 
            // btcheck
            // 
            this.btcheck.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btcheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.btcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcheck.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btcheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcheck.Location = new System.Drawing.Point(202, 21);
            this.btcheck.Name = "btcheck";
            this.btcheck.Size = new System.Drawing.Size(75, 30);
            this.btcheck.TabIndex = 13;
            this.btcheck.Text = "Check";
            this.btcheck.UseVisualStyleBackColor = false;
            this.btcheck.Click += new System.EventHandler(this.btcheck_Click);
            // 
            // btcancel
            // 
            this.btcancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btcancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btcancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcancel.Location = new System.Drawing.Point(202, 62);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 30);
            this.btcancel.TabIndex = 14;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = false;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // statusConnect
            // 
            this.statusConnect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusConnect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusConnect.Location = new System.Drawing.Point(0, 198);
            this.statusConnect.Name = "statusConnect";
            this.statusConnect.Size = new System.Drawing.Size(284, 22);
            this.statusConnect.TabIndex = 15;
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(12, 17);
            this.tsslStatus.Text = "-";
            this.tsslStatus.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.statusConnect);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btcheck);
            this.Controls.Add(this.cbdata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbserver);
            this.Controls.Add(this.lblserv);
            this.Controls.Add(this.lbldescr);
            this.Controls.Add(this.lblgosign);
            this.Controls.Add(this.lblquest);
            this.Controls.Add(this.btenter);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tblogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select connection settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.statusConnect.ResumeLayout(false);
            this.statusConnect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Button btenter;
        private System.Windows.Forms.Label lblquest;
        private System.Windows.Forms.Label lblgosign;
        private System.Windows.Forms.Label lbldescr;
        private System.Windows.Forms.Label lblserv;
        private System.Windows.Forms.ComboBox cbserver;
        private System.Windows.Forms.ComboBox cbdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btcheck;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.StatusStrip statusConnect;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    }
}

