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
            //��ȡcookie�е�ֵ
            //Context.Cookies��VWGContext.Current.Cookies��ͬһ������
            string cookieAccount = Context.Cookies["Account"];
            string cookiePassword = Context.Cookies["Password"];
            //�ж�Cookies��ֵ�Ƿ���ֵ
            if (cookieAccount != "" && cookiePassword != "")
            {
                txtLoginName.Text = cookieAccount;
                txtPassword.Text = cookiePassword;
                chkAutoSave.Checked = true;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            #region �˻������Ϊ���ж�
            txtLoginName.Text = txtLoginName.Text.Trim();
            if(string.IsNullOrEmpty(txtLoginName.Text))
            {
                ClsMsgBox.Jg("�˺Ų���Ϊ��!");
                return;
            }
            txtPassword.Text = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ClsMsgBox.Jg("�����Ϊ�գ�");
                return;
            }
            #endregion
            #region  �˻���������Ч���ж�
            if (!ClsMSSQL.Exists("tlogin", "loginname", txtLoginName.Text, ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("�˻������ڣ�");
                return;
            }
            #endregion
            string cmd = string.Format("SELECT * FROM tlogin WHERE loginname = '{0}' AND " + "password = '{1}'", txtLoginName.Text, txtPassword.Text);
            if(!ClsMSSQL.Exists(cmd,ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("�����ȷ");
                return;
            }
            #region �Ƿ񱣴浽cookie
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