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
    public partial class Main : Form
    {
        DB_Config data = new DB_Config();
        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void Main_Load(object sender, EventArgs e)
        {
            data.conState += constate;
            Thread thread = new Thread(data.Connection_check);
            thread.Start();
        }

        private void constate(bool value)
        {
            Action action = () =>
            {
                switch (value)
                {
                    case (true):
                        tsslCon.Visible = true;
                        tsslCon.Text = Reg_class.DS + " - " + Reg_class.IC;
                        break;
                    case (false):
                        Login connection = new Login();
                        tsslCon.Visible = true;
                        tsslCon.Text = "No connection";
                        connection.Show(this);
                        break;
                }
            };
            Invoke(action);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssldateTime.Text = DateTime.Now.ToLongTimeString() + "/" + DateTime.Now.ToShortDateString();
        }

        private void btconnect_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show(this);
        }

        private void bteng_Click(object sender, EventArgs e)
        {
            Engineer form = new Engineer();
            form.Show(this);
        }

        private void btcle_Click(object sender, EventArgs e)
        {
            Cleaner form = new Cleaner();
            form.Show(this);
        }

        private void btair_Click(object sender, EventArgs e)
        {
            Aircraft form = new Aircraft();
            form.Show(this);
        }

        private void btcom_Click(object sender, EventArgs e)
        {
            Aircraft form = new Aircraft();
            form.Show(this);
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
