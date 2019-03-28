using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_Light
{
    public partial class Engineer : Form
    {
        DB_Tables tableInzh = new DB_Tables();
        DB_Procedure procedure = new DB_Procedure();
        string filterInzh
        public Engineer()
        {
            InitializeComponent();
            Thread threadInzh = new Thread(tableInzh.dtInzhFill);
            tableInzh.dtFillFull += dtFillFullInzh;
            threadInzh.Start();
        }

        private void dtFillFullInzh(DataTable data)
        {
            Action action = () =>
            {
                dgvInzh.DataSource = data;
                dgvInzh.Columns[0].Visible = false;
                dgvInzh.Columns[1].HeaderText = "Engineer login";
                dgvInzh.Columns[2].HeaderText = "Surname engineer";
                dgvInzh.Columns[3].HeaderText = "Name engineer";
                dgvInzh.Columns[4].HeaderText = "Middle name engineer";
                Thread threadInzh = new Thread(tableInzh.dtInzhFill);
                tableInzh.dtFillFull += dtFillFullInzh;
                threadInzh.Start();
            };
            Invoke(action);
        }

        private void tbsearch_Enter(object sender, EventArgs e)
        {
            if (tbsearch.Text == "Enter engineer login...")
                tbsearch.Clear();
        }

        private void tbsearch_Leave(object sender, EventArgs e)
        {
            if (tbsearch.Text == "")
                tbsearch.Text = "Enter engineer login...";
        }

        private void dgvInzh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tblog.Text = dgvInzh.CurrentRow.Cells[1].Value.ToString();
            tbsur.Text = dgvInzh.CurrentRow.Cells[2].Value.ToString();
            tbnam.Text = dgvInzh.CurrentRow.Cells[3].Value.ToString();
            tbmid.Text = dgvInzh.CurrentRow.Cells[4].Value.ToString();
        }

        private void btinsert_Click(object sender, EventArgs e)
        {
            procedure.spInzh_Insert(tblog.Text,
            tbsur.Text, tbnam.Text, tbmid.Text);
            tblog.Clear();
            tbsur.Clear();
            tbnam.Clear();
            tbmid.Clear();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            procedure.spInzh_Update(Convert.ToInt32(
            dgvInzh.CurrentRow.Cells[0].Value.ToString()),
            tblog.Text, tbsur.Text, tbnam.Text, tbmid.Text);
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Engineer removal", "Remove engineer?" +
            tbnam.Text + " " + tbsur.Text + "?", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spInzh_Delete(Convert.ToInt32(
                        dgvInzh.CurrentRow.Cells[0].Value.ToString()));
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbfilter_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbfilter.CheckState)
            {
                case (CheckState.Checked):
                    DB_Tables data = new DB_Tables();
                    data.qrInzh = filterInzh + " and [Login_Inzh] like '%"
                        + tbsearch.Text + "%' or [Surname_Inzh] like '%"
                        + tbsearch.Text + "%' or [Name_Inzh] like '%"
                        + tbsearch.Text + "%' or [Middle_name_Inzh] like '%"
                        + tbsearch.Text + "%'";
                    data.dtInzhFill();
                    dgvInzh.Columns[1].HeaderText = "Engineer login";
                    dgvInzh.Columns[2].HeaderText = "Surname engineer";
                    dgvInzh.Columns[3].HeaderText = "Name engineer";
                    dgvInzh.Columns[4].HeaderText = "Middle name engineer";
                    break;
                case (CheckState.Unchecked):
                    //dgvInzhFill();
                    for (int i = 0; i < dgvInzh.RowCount; i++)
                    {
                        for (int j = 0; j < dgvInzh.ColumnCount; j++)
                        {
                            if (dgvInzh.Rows[i].Cells[j].Value != null)
                                if (dgvInzh.Rows[i].Cells[i].Value.ToString().
                                    Contains(tbsearch.Text))
                                {
                                    dgvInzh.Rows[i].Selected = true;
                                    break;
                                }
                        }
                    }

                    break;
            }
        }
    }
}
