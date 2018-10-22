#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using DLTLib.Classes;

#endregion

namespace DLTVWGPT
{
    public partial class FrmPractice : Form
    {
        public FrmPractice()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lst.Items.Add(ClsQ.Q1(txtA.Text));
            lst.Items.Add(ClsQ.Q2(txtA.Text));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '('));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '['));
            lst.Items.Add(ClsQ.Q0(txtA.Text, 'бо'));
            lst.Items.Add(ClsQ.Q0(txtA.Text, 'б░'));

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst.Items.Add(ClsDBCon.ConStrKj);
            string cmd = "SELECT * FROM tlogin";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            dgv.DataSource = dt;
            tabControl1.SelectedTab = tpDgv;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}