namespace CS_Light
{
    partial class Cleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cleaner));
            this.gbmanipulation = new System.Windows.Forms.GroupBox();
            this.lblclose = new System.Windows.Forms.Label();
            this.lblmid = new System.Windows.Forms.Label();
            this.tbmid = new System.Windows.Forms.TextBox();
            this.lblnam = new System.Windows.Forms.Label();
            this.lblsur = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.Label();
            this.btdelete = new System.Windows.Forms.Button();
            this.tbnam = new System.Windows.Forms.TextBox();
            this.btupdate = new System.Windows.Forms.Button();
            this.tbsur = new System.Windows.Forms.TextBox();
            this.tblog = new System.Windows.Forms.TextBox();
            this.btinsert = new System.Windows.Forms.Button();
            this.gbsearch = new System.Windows.Forms.GroupBox();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.cbfilter = new System.Windows.Forms.CheckBox();
            this.dgvUbor = new System.Windows.Forms.DataGridView();
            this.lbldescr = new System.Windows.Forms.Label();
            this.gbmanipulation.SuspendLayout();
            this.gbsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbmanipulation
            // 
            this.gbmanipulation.Controls.Add(this.lblclose);
            this.gbmanipulation.Controls.Add(this.lblmid);
            this.gbmanipulation.Controls.Add(this.tbmid);
            this.gbmanipulation.Controls.Add(this.lblnam);
            this.gbmanipulation.Controls.Add(this.lblsur);
            this.gbmanipulation.Controls.Add(this.lbllog);
            this.gbmanipulation.Controls.Add(this.btdelete);
            this.gbmanipulation.Controls.Add(this.tbnam);
            this.gbmanipulation.Controls.Add(this.btupdate);
            this.gbmanipulation.Controls.Add(this.tbsur);
            this.gbmanipulation.Controls.Add(this.tblog);
            this.gbmanipulation.Controls.Add(this.btinsert);
            this.gbmanipulation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbmanipulation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbmanipulation.Location = new System.Drawing.Point(383, 69);
            this.gbmanipulation.Name = "gbmanipulation";
            this.gbmanipulation.Size = new System.Drawing.Size(227, 217);
            this.gbmanipulation.TabIndex = 27;
            this.gbmanipulation.TabStop = false;
            this.gbmanipulation.Text = "Manipulation";
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblclose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblclose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblclose.Location = new System.Drawing.Point(180, 190);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(41, 16);
            this.lblclose.TabIndex = 24;
            this.lblclose.Text = "Close";
            // 
            // lblmid
            // 
            this.lblmid.AutoSize = true;
            this.lblmid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblmid.ForeColor = System.Drawing.SystemColors.Info;
            this.lblmid.Location = new System.Drawing.Point(14, 163);
            this.lblmid.Name = "lblmid";
            this.lblmid.Size = new System.Drawing.Size(86, 16);
            this.lblmid.TabIndex = 34;
            this.lblmid.Text = "Middle name:";
            // 
            // tbmid
            // 
            this.tbmid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbmid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbmid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbmid.ForeColor = System.Drawing.SystemColors.Info;
            this.tbmid.Location = new System.Drawing.Point(17, 182);
            this.tbmid.Multiline = true;
            this.tbmid.Name = "tbmid";
            this.tbmid.Size = new System.Drawing.Size(128, 24);
            this.tbmid.TabIndex = 33;
            this.tbmid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblnam.ForeColor = System.Drawing.SystemColors.Info;
            this.lblnam.Location = new System.Drawing.Point(14, 113);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(46, 16);
            this.lblnam.TabIndex = 32;
            this.lblnam.Text = "Name:";
            // 
            // lblsur
            // 
            this.lblsur.AutoSize = true;
            this.lblsur.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsur.ForeColor = System.Drawing.SystemColors.Info;
            this.lblsur.Location = new System.Drawing.Point(14, 67);
            this.lblsur.Name = "lblsur";
            this.lblsur.Size = new System.Drawing.Size(64, 16);
            this.lblsur.TabIndex = 31;
            this.lblsur.Text = "Surname:";
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllog.ForeColor = System.Drawing.SystemColors.Info;
            this.lbllog.Location = new System.Drawing.Point(14, 21);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(43, 16);
            this.lbllog.TabIndex = 30;
            this.lbllog.Text = "Login:";
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btdelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btdelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdelete.Location = new System.Drawing.Point(158, 102);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(61, 25);
            this.btdelete.TabIndex = 29;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = false;
            // 
            // tbnam
            // 
            this.tbnam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbnam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbnam.ForeColor = System.Drawing.SystemColors.Info;
            this.tbnam.Location = new System.Drawing.Point(17, 132);
            this.tbnam.Multiline = true;
            this.tbnam.Name = "tbnam";
            this.tbnam.Size = new System.Drawing.Size(128, 24);
            this.tbnam.TabIndex = 28;
            this.tbnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btupdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btupdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btupdate.Location = new System.Drawing.Point(158, 71);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(61, 25);
            this.btupdate.TabIndex = 27;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = false;
            // 
            // tbsur
            // 
            this.tbsur.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbsur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbsur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbsur.ForeColor = System.Drawing.SystemColors.Info;
            this.tbsur.Location = new System.Drawing.Point(17, 86);
            this.tbsur.Multiline = true;
            this.tbsur.Name = "tbsur";
            this.tbsur.Size = new System.Drawing.Size(128, 24);
            this.tbsur.TabIndex = 26;
            this.tbsur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblog
            // 
            this.tblog.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tblog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tblog.ForeColor = System.Drawing.SystemColors.Info;
            this.tblog.Location = new System.Drawing.Point(17, 40);
            this.tblog.Multiline = true;
            this.tblog.Name = "tblog";
            this.tblog.Size = new System.Drawing.Size(128, 24);
            this.tblog.TabIndex = 25;
            this.tblog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btinsert
            // 
            this.btinsert.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btinsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btinsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinsert.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btinsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btinsert.Location = new System.Drawing.Point(158, 40);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(61, 25);
            this.btinsert.TabIndex = 16;
            this.btinsert.Text = "Insert";
            this.btinsert.UseVisualStyleBackColor = false;
            // 
            // gbsearch
            // 
            this.gbsearch.Controls.Add(this.tbsearch);
            this.gbsearch.Controls.Add(this.cbfilter);
            this.gbsearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbsearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbsearch.Location = new System.Drawing.Point(383, 14);
            this.gbsearch.Name = "gbsearch";
            this.gbsearch.Size = new System.Drawing.Size(227, 49);
            this.gbsearch.TabIndex = 26;
            this.gbsearch.TabStop = false;
            this.gbsearch.Text = "Search and filtering";
            // 
            // tbsearch
            // 
            this.tbsearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbsearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbsearch.ForeColor = System.Drawing.SystemColors.Info;
            this.tbsearch.Location = new System.Drawing.Point(6, 19);
            this.tbsearch.Multiline = true;
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(139, 24);
            this.tbsearch.TabIndex = 25;
            this.tbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbfilter
            // 
            this.cbfilter.AutoSize = true;
            this.cbfilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbfilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbfilter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbfilter.Location = new System.Drawing.Point(151, 21);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(53, 20);
            this.cbfilter.TabIndex = 24;
            this.cbfilter.Text = "Filter";
            this.cbfilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbfilter.UseVisualStyleBackColor = false;
            // 
            // dgvUbor
            // 
            this.dgvUbor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUbor.Location = new System.Drawing.Point(12, 40);
            this.dgvUbor.Name = "dgvUbor";
            this.dgvUbor.Size = new System.Drawing.Size(352, 246);
            this.dgvUbor.TabIndex = 25;
            // 
            // lbldescr
            // 
            this.lbldescr.AutoSize = true;
            this.lbldescr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldescr.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldescr.ForeColor = System.Drawing.SystemColors.Window;
            this.lbldescr.Location = new System.Drawing.Point(12, 11);
            this.lbldescr.Name = "lbldescr";
            this.lbldescr.Size = new System.Drawing.Size(352, 17);
            this.lbldescr.TabIndex = 24;
            this.lbldescr.Text = "This book contains information about airfield cleaners";
            // 
            // Cleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 296);
            this.Controls.Add(this.gbmanipulation);
            this.Controls.Add(this.gbsearch);
            this.Controls.Add(this.dgvUbor);
            this.Controls.Add(this.lbldescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cleaner";
            this.Text = "Cleaner book";
            this.gbmanipulation.ResumeLayout(false);
            this.gbmanipulation.PerformLayout();
            this.gbsearch.ResumeLayout(false);
            this.gbsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbmanipulation;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Label lblmid;
        private System.Windows.Forms.TextBox tbmid;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.Label lblsur;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox tbnam;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.TextBox tbsur;
        private System.Windows.Forms.TextBox tblog;
        private System.Windows.Forms.Button btinsert;
        private System.Windows.Forms.GroupBox gbsearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.CheckBox cbfilter;
        private System.Windows.Forms.DataGridView dgvUbor;
        private System.Windows.Forms.Label lbldescr;
    }
}