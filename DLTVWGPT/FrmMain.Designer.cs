using System;
using Gizmox.WebGUI.Forms;

namespace DLTVWGPT
{
    partial class FrmMain
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.stat = new Gizmox.WebGUI.Forms.StatusStrip();
            this.lblTop = new Gizmox.WebGUI.Forms.Label();
            this.pnlLeft = new Gizmox.WebGUI.Forms.Panel();
            this.pnlLTitle = new Gizmox.WebGUI.Forms.Panel();
            this.splitter1 = new Gizmox.WebGUI.Forms.Splitter();
            this.lblLeft = new Gizmox.WebGUI.Forms.Label();
            this.pnlMain = new Gizmox.WebGUI.Forms.Panel();
            this.tcMain = new Gizmox.WebGUI.Forms.TabControl();
            this.tpMain = new Gizmox.WebGUI.Forms.TabPage();
            this.tpHTML = new Gizmox.WebGUI.Forms.TabPage();
            this.pnlMTitle = new Gizmox.WebGUI.Forms.Panel();
            this.tsMTools = new Gizmox.WebGUI.Forms.ToolStrip();
            this.tsBtnLogout = new Gizmox.WebGUI.Forms.ToolStripLabel();
            this.funcsTree = new DLTVWGPT.Controls.UCFuncsTree();
            this.pnlLeft.SuspendLayout();
            this.pnlLTitle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Linen;
            this.pnlTop.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pnlTop.BackgroundImage"));
            this.pnlTop.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.Size = new System.Drawing.Size(600, 80);
            this.pnlTop.TabIndex = 0;
            // 
            // stat
            // 
            this.stat.BackColor = System.Drawing.Color.Linen;
            this.stat.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.stat.DockPadding.Left = 1;
            this.stat.DockPadding.Right = 14;
            this.stat.ExcludeFromUniqueId = false;
            this.stat.Location = new System.Drawing.Point(0, 428);
            this.stat.Name = "stat";
            this.stat.PerformLayoutEnabled = true;
            this.stat.Size = new System.Drawing.Size(600, 22);
            this.stat.TabIndex = 1;
            this.stat.Text = "statusStrip1";
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.Wheat;
            this.lblTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.lblTop.ExcludeFromUniqueId = false;
            this.lblTop.Font = new System.Drawing.Font("ËÎÌå", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.Blue;
            this.lblTop.Location = new System.Drawing.Point(0, 80);
            this.lblTop.Name = "lblTop";
            this.lblTop.PerformLayoutEnabled = true;
            this.lblTop.Size = new System.Drawing.Size(600, 13);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "¡Ä";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlLeft.Controls.Add(this.funcsTree);
            this.pnlLeft.Controls.Add(this.pnlLTitle);
            this.pnlLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlLeft.ExcludeFromUniqueId = false;
            this.pnlLeft.Location = new System.Drawing.Point(0, 93);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PerformLayoutEnabled = true;
            this.pnlLeft.Size = new System.Drawing.Size(200, 335);
            this.pnlLeft.TabIndex = 3;
            this.pnlLeft.Click += new System.EventHandler(this.pnlLeft_Click);
            // 
            // pnlLTitle
            // 
            this.pnlLTitle.BackColor = System.Drawing.Color.Linen;
            this.pnlLTitle.Controls.Add(this.tsMTools);
            this.pnlLTitle.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlLTitle.ExcludeFromUniqueId = false;
            this.pnlLTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlLTitle.Name = "pnlLTitle";
            this.pnlLTitle.PerformLayoutEnabled = true;
            this.pnlLTitle.Size = new System.Drawing.Size(200, 22);
            this.pnlLTitle.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Wheat;
            this.splitter1.ExcludeFromUniqueId = false;
            this.splitter1.Location = new System.Drawing.Point(200, 93);
            this.splitter1.Name = "splitter1";
            this.splitter1.PerformLayoutEnabled = true;
            this.splitter1.Size = new System.Drawing.Size(3, 335);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.Beige;
            this.lblLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.lblLeft.ExcludeFromUniqueId = false;
            this.lblLeft.Font = new System.Drawing.Font("ËÎÌå", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.ForeColor = System.Drawing.Color.Blue;
            this.lblLeft.Location = new System.Drawing.Point(203, 93);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.PerformLayoutEnabled = true;
            this.lblLeft.Size = new System.Drawing.Size(10, 335);
            this.lblLeft.TabIndex = 5;
            this.lblLeft.Text = "£¼";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeft.Click += new System.EventHandler(this.lblLeft_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlMain.Controls.Add(this.tcMain);
            this.pnlMain.Controls.Add(this.pnlMTitle);
            this.pnlMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.pnlMain.ExcludeFromUniqueId = false;
            this.pnlMain.Location = new System.Drawing.Point(213, 93);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.PerformLayoutEnabled = true;
            this.pnlMain.Size = new System.Drawing.Size(387, 335);
            this.pnlMain.TabIndex = 6;
            // 
            // tcMain
            // 
            this.tcMain.Appearance = Gizmox.WebGUI.Forms.TabAppearance.Logical;
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Controls.Add(this.tpHTML);
            this.tcMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tcMain.ExcludeFromUniqueId = false;
            this.tcMain.Location = new System.Drawing.Point(0, 22);
            this.tcMain.Name = "tcMain";
            this.tcMain.PerformLayoutEnabled = true;
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(387, 313);
            this.tcMain.TabIndex = 1;
            // 
            // tpMain
            // 
            this.tpMain.AutoScroll = true;
            this.tpMain.BackColor = System.Drawing.Color.PapayaWhip;
            this.tpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpMain.ExcludeFromUniqueId = false;
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.PerformLayoutEnabled = true;
            this.tpMain.Size = new System.Drawing.Size(379, 287);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "tpMain";
            // 
            // tpHTML
            // 
            this.tpHTML.AutoScroll = true;
            this.tpHTML.BackColor = System.Drawing.Color.PapayaWhip;
            this.tpHTML.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpHTML.ExcludeFromUniqueId = false;
            this.tpHTML.Location = new System.Drawing.Point(4, 22);
            this.tpHTML.Name = "tpHTML";
            this.tpHTML.PerformLayoutEnabled = true;
            this.tpHTML.Size = new System.Drawing.Size(379, 287);
            this.tpHTML.TabIndex = 0;
            this.tpHTML.Text = "tpHTML";
            // 
            // pnlMTitle
            // 
            this.pnlMTitle.BackColor = System.Drawing.Color.Linen;
            this.pnlMTitle.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlMTitle.ExcludeFromUniqueId = false;
            this.pnlMTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMTitle.Name = "pnlMTitle";
            this.pnlMTitle.PerformLayoutEnabled = true;
            this.pnlMTitle.Size = new System.Drawing.Size(387, 22);
            this.pnlMTitle.TabIndex = 0;
            // 
            // tsMTools
            // 
            this.tsMTools.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tsMTools.ExcludeFromUniqueId = false;
            this.tsMTools.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.tsBtnLogout});
            this.tsMTools.Location = new System.Drawing.Point(0, 0);
            this.tsMTools.Name = "tsMTools";
            this.tsMTools.PerformLayoutEnabled = true;
            this.tsMTools.Size = new System.Drawing.Size(200, 25);
            this.tsMTools.TabIndex = 0;
            this.tsMTools.Text = "toolStrip1";
            // 
            // tsBtnLogout
            // 
            this.tsBtnLogout.ExcludeFromUniqueId = false;
            this.tsBtnLogout.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("tsBtnLogout.Image"));
            this.tsBtnLogout.Name = "tsBtnLogout";
            this.tsBtnLogout.Size = new System.Drawing.Size(47, 16);
            this.tsBtnLogout.Text = "×¢Ïú";
            this.tsBtnLogout.Click += new System.EventHandler(this.tsBtnLogout_Click);
            // 
            // funcsTree
            // 
            this.funcsTree.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.funcsTree.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.funcsTree.ExcludeFromUniqueId = false;
            this.funcsTree.Location = new System.Drawing.Point(0, 22);
            this.funcsTree.Name = "funcsTree";
            this.funcsTree.PerformLayoutEnabled = true;
            this.funcsTree.Size = new System.Drawing.Size(200, 313);
            this.funcsTree.TabIndex = 1;
            this.funcsTree.Text = "UCFuncsTree";
            // 
            // FrmMain
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Size = new System.Drawing.Size(600, 450);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLTitle.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void tsMTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #endregion

        private Gizmox.WebGUI.Forms.Panel pnlTop;
        private Gizmox.WebGUI.Forms.StatusStrip stat;
        private Gizmox.WebGUI.Forms.Label lblTop;
        private Gizmox.WebGUI.Forms.Panel pnlLeft;
        private Gizmox.WebGUI.Forms.Panel pnlLTitle;
        private Gizmox.WebGUI.Forms.Splitter splitter1;
        private Gizmox.WebGUI.Forms.Label lblLeft;
        private Gizmox.WebGUI.Forms.Panel pnlMain;
        private Gizmox.WebGUI.Forms.Panel pnlMTitle;
        private Gizmox.WebGUI.Forms.TabControl tcMain;
        private Gizmox.WebGUI.Forms.TabPage tpMain;
        private Gizmox.WebGUI.Forms.TabPage tpHTML;
        private ToolStrip tsMTools;
        private ToolStripLabel tsBtnLogout;
        private Controls.UCFuncsTree funcsTree;
    }
}