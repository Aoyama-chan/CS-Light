namespace CS_Light
{
    partial class Aircraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aircraft));
            this.gbmanipulation = new System.Windows.Forms.GroupBox();
            this.lblclose = new System.Windows.Forms.Label();
            this.lblmod = new System.Windows.Forms.Label();
            this.lblnam = new System.Windows.Forms.Label();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.tbmod = new System.Windows.Forms.TextBox();
            this.tbnam = new System.Windows.Forms.TextBox();
            this.btinsert = new System.Windows.Forms.Button();
            this.gbsearch = new System.Windows.Forms.GroupBox();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.cbfilter = new System.Windows.Forms.CheckBox();
            this.dgVozsud = new System.Windows.Forms.DataGridView();
            this.lbldescr = new System.Windows.Forms.Label();
            this.gbmanipulation.SuspendLayout();
            this.gbsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVozsud)).BeginInit();
            this.SuspendLayout();
            // 
            // gbmanipulation
            // 
            this.gbmanipulation.Controls.Add(this.lblclose);
            this.gbmanipulation.Controls.Add(this.lblmod);
            this.gbmanipulation.Controls.Add(this.lblnam);
            this.gbmanipulation.Controls.Add(this.btdelete);
            this.gbmanipulation.Controls.Add(this.btupdate);
            this.gbmanipulation.Controls.Add(this.tbmod);
            this.gbmanipulation.Controls.Add(this.tbnam);
            this.gbmanipulation.Controls.Add(this.btinsert);
            this.gbmanipulation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbmanipulation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbmanipulation.Location = new System.Drawing.Point(335, 67);
            this.gbmanipulation.Name = "gbmanipulation";
            this.gbmanipulation.Size = new System.Drawing.Size(227, 143);
            this.gbmanipulation.TabIndex = 31;
            this.gbmanipulation.TabStop = false;
            this.gbmanipulation.Text = "Manipulation";
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblclose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblclose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblclose.Location = new System.Drawing.Point(180, 117);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(41, 16);
            this.lblclose.TabIndex = 24;
            this.lblclose.Text = "Close";
            // 
            // lblmod
            // 
            this.lblmod.AutoSize = true;
            this.lblmod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblmod.ForeColor = System.Drawing.SystemColors.Info;
            this.lblmod.Location = new System.Drawing.Point(14, 67);
            this.lblmod.Name = "lblmod";
            this.lblmod.Size = new System.Drawing.Size(81, 16);
            this.lblmod.TabIndex = 31;
            this.lblmod.Text = "Modification:";
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblnam.ForeColor = System.Drawing.SystemColors.Info;
            this.lblnam.Location = new System.Drawing.Point(14, 21);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(89, 16);
            this.lblnam.TabIndex = 30;
            this.lblnam.Text = "Aircraft name:";
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btdelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btdelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdelete.Location = new System.Drawing.Point(158, 79);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(61, 25);
            this.btdelete.TabIndex = 29;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = false;
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btupdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btupdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btupdate.Location = new System.Drawing.Point(158, 48);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(61, 25);
            this.btupdate.TabIndex = 27;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = false;
            // 
            // tbmod
            // 
            this.tbmod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbmod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbmod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbmod.ForeColor = System.Drawing.SystemColors.Info;
            this.tbmod.Location = new System.Drawing.Point(17, 86);
            this.tbmod.Multiline = true;
            this.tbmod.Name = "tbmod";
            this.tbmod.Size = new System.Drawing.Size(128, 24);
            this.tbmod.TabIndex = 26;
            this.tbmod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbnam
            // 
            this.tbnam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbnam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbnam.ForeColor = System.Drawing.SystemColors.Info;
            this.tbnam.Location = new System.Drawing.Point(17, 40);
            this.tbnam.Multiline = true;
            this.tbnam.Name = "tbnam";
            this.tbnam.Size = new System.Drawing.Size(128, 24);
            this.tbnam.TabIndex = 25;
            this.tbnam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btinsert
            // 
            this.btinsert.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btinsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btinsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinsert.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btinsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btinsert.Location = new System.Drawing.Point(158, 17);
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
            this.gbsearch.Location = new System.Drawing.Point(335, 12);
            this.gbsearch.Name = "gbsearch";
            this.gbsearch.Size = new System.Drawing.Size(227, 49);
            this.gbsearch.TabIndex = 30;
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
            // dgVozsud
            // 
            this.dgVozsud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVozsud.Location = new System.Drawing.Point(12, 38);
            this.dgVozsud.Name = "dgVozsud";
            this.dgVozsud.Size = new System.Drawing.Size(303, 172);
            this.dgVozsud.TabIndex = 29;
            // 
            // lbldescr
            // 
            this.lbldescr.AutoSize = true;
            this.lbldescr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldescr.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldescr.ForeColor = System.Drawing.SystemColors.Window;
            this.lbldescr.Location = new System.Drawing.Point(12, 9);
            this.lbldescr.Name = "lbldescr";
            this.lbldescr.Size = new System.Drawing.Size(303, 17);
            this.lbldescr.TabIndex = 28;
            this.lbldescr.Text = "This book contains information about aircrafts";
            // 
            // Aircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 220);
            this.Controls.Add(this.gbmanipulation);
            this.Controls.Add(this.gbsearch);
            this.Controls.Add(this.dgVozsud);
            this.Controls.Add(this.lbldescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aircraft";
            this.Text = "Aircraft book";
            this.gbmanipulation.ResumeLayout(false);
            this.gbmanipulation.PerformLayout();
            this.gbsearch.ResumeLayout(false);
            this.gbsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVozsud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbmanipulation;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Label lblmod;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.TextBox tbmod;
        private System.Windows.Forms.TextBox tbnam;
        private System.Windows.Forms.Button btinsert;
        private System.Windows.Forms.GroupBox gbsearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.CheckBox cbfilter;
        private System.Windows.Forms.DataGridView dgVozsud;
        private System.Windows.Forms.Label lbldescr;
    }
}