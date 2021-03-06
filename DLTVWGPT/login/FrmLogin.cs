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
using Gizmox.WebGUI.Forms.Authentication;
using DLTLib.Classes;

#endregion

namespace DLTVWGPT.login
{
    public partial class FrmLogin : LogonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            readCookie();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void readCookie()
        {
            //读取cookie中的值
            //Context.Cookies与VWGContext.Current.Cookies是同一个东西
            string cookieAccount = Context.Cookies["Account"];
            string cookiePassword = Context.Cookies["Password"];
            //判断Cookies的值是否有值
            if (cookieAccount != "" && cookiePassword != "")
            {
                txtLoginName.Text = cookieAccount;
                txtPassword.Text = cookiePassword;
                chkAutoSave.Checked = true;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            #region 账户或口令为空判断
            txtLoginName.Text = txtLoginName.Text.Trim();
            if(string.IsNullOrEmpty(txtLoginName.Text))
            {
                ClsMsgBox.Jg("账号不能为空!");
                return;
            }
            txtPassword.Text = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ClsMsgBox.Jg("口令不能为空！");
                return;
            }
            #endregion
            #region  账户、口令有效性判断
            if (!ClsMSSQL.Exists("tlogin", "loginname", txtLoginName.Text, ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("账户不存在！");
                return;
            }
            #endregion
            string cmd = string.Format("SELECT * FROM tlogin WHERE loginname = '{0}' AND " + "password = '{1}'", txtLoginName.Text, txtPassword.Text);
            if(!ClsMSSQL.Exists(cmd,ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("口令不正确");
                return;
            }
            #region 是否保存到cookie
            if (chkAutoSave.Checked)
            {
                Context.Cookies["Account"] = txtLoginName.Text;
                Context.Cookies["Password"] = txtPassword.Text;
            }
            else
            {
                Context.Cookies["Account"] = "";
                Context.Cookies["Password"] = "";
            }
            #endregion
            this.Context.Session.IsLoggedOn = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}