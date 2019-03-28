using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CS_Light
{
    public partial class Login : Form
    {
        private DB_Config configuration = new DB_Config();
        private Int32 status;
        public Login()
        {
            InitializeComponent();


        }

        private void Login_Load(object sender, EventArgs e)
        {
            switch (DB_Config.logCon)
            {
                case (true):
                    cbserver.Text = Reg_class.DS;
                    cbdata.Text = Reg_class.IC;
                    cbserver.Enabled = true;
                    cbdata.Enabled = true;
                    tblogin.Enabled = true;
                    tbpass.Enabled = true;
                    btcheck.Enabled = true;
                    break;
                case (false):
                    status = 1;
                    Thread threadMessage = new Thread(tsslMessage);
                    threadMessage.Start();
                    configuration.dtServers += dtservers;
                    Thread thread = new Thread(configuration.Servers_get);
                    thread.Start();
                    break;
            }
        }

        private void dtservers(DataTable table)
        {
            Action action = () =>
            {
                foreach (DataRow r in table.Rows)
                {
                    cbserver.Items.Add(r[0] + @"\" + r[1]);
                }
                status = 0;
                cbserver.Enabled = true;
                tblogin.Enabled = true;
                tbpass.Enabled = true;
                btcheck.Enabled = true;
            };
            Invoke(action);
        }

        private void tsslMessage()
        {
            tsslStatus.Visible = true;
            switch (status)
            {
                case (1):
                    tsslStatus.Text = "Server search";
                    break;
                case (2):
                    tsslStatus.Text = "Search data sources";
                    break;
            }
            do
            {
                Thread.Sleep(750);
                switch (status)
                {
                    case (1):
                        if (tsslStatus.Text == "Server search...")
                            tsslStatus.Text = "Server search";
                        else tsslStatus.Text = tsslStatus.Text + ".";
                        break;
                    case (2):
                        if (tsslStatus.Text == "Search data sources...")
                            tsslStatus.Text = "Search data sources";
                        else tsslStatus.Text = tsslStatus.Text + ".";
                        break;
                }

            } while (status != 0);
            tsslStatus.Text = "-";
            tsslStatus.Visible = false;
            Thread.CurrentThread.Abort();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            configuration.cds = cbserver.Text;
            configuration.cui = tblogin.Text;
            configuration.cpw = tbpass.Text;
            configuration.dtDatabases += databases;
            status = 2;
            Thread threadMessage = new Thread(tsslMessage);
            Thread thread = new Thread(configuration.Databases_get);
            threadMessage.Start();
            thread.Start();
        }

        private void databases(DataTable table)
        {
            Action action = () =>
            {
                foreach (DataRow r in table.Rows)
                {
                    cbdata.Items.Add(r[0]);
                }
                status = 0;
                cbdata.Enabled = true;
                btenter.Enabled = true;
            };
            Invoke(action);
        }

        private void btenter_Click(object sender, EventArgs e)
        {
            Reg_class registry = new Reg_class();
            registry.Reg_set(cbserver.Text,
                cbdata.Text, tblogin.Text, tbpass.Text);
            ((Main)Owner).Main_Load(sender, e);
            DB_Config.logCon = true;
            Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (DB_Config.logCon)
            {
                case (true):
                    e.Cancel = false;
                    break;
                case (false):
                    switch (MessageBox.Show("Connection has not been established. " +
                        "\n Shut down the application?", "Commercial service",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        case DialogResult.Yes:
                            e.Cancel = false;
                            Application.Exit();
                            break;
                        case DialogResult.No:
                            e.Cancel = true;
                            break;
                    }
                    break;
            }
        }
    }
}
