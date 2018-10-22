#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using DLTLib.Classes;
using DLTVWGPT.Classes;

#endregion

namespace DLTVWGPT
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void lblTop_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            lblTop.Text = pnlTop.Visible ? "∧" : "∨";
        }

        private void lblLeft_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = !pnlLeft.Visible;
            splitter1.Visible = pnlLeft.Visible;
            lblLeft.Text = pnlLeft.Visible ? "<" : ">";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ClsFuncsA funcs = new ClsFuncsA();
            funcsTree.Prepare(funcs);
        }

        private void tsBthLogout_Click(object sender, EventArgs e)
        {
          
            
        }
        private void logout(object sender, EventArgs e)
        {
            
            DialogResult dr = ((Form)sender).DialogResult;
            if(dr==DialogResult.Yes)
            {
                VWGContext.Current.Session.IsLoggedOn = false;
                VWGContext.Current.HttpContext.Session.Abandon();
            }
            
        }

        private void tsBtnLogout_Click(object sender, EventArgs e)
        {
            ClsMsgBox.YesNo("确定要退出系统吗？", logout);
        }

        private void pnlLeft_Click(object sender, EventArgs e)
        {

        }
    }
}