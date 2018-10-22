using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace DLTVWGPT
{
    partial class FrmPractice
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
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.textBox1 = new Gizmox.WebGUI.Forms.TextBox();
            this.button1 = new Gizmox.WebGUI.Forms.Button();
            this.btnClear = new Gizmox.WebGUI.Forms.Button();
            this.txtA = new Gizmox.WebGUI.Forms.TextBox();
            this.btnTest = new Gizmox.WebGUI.Forms.Button();
            this.tabControl1 = new Gizmox.WebGUI.Forms.TabControl();
            this.tcA = new Gizmox.WebGUI.Forms.TabPage();
            this.lst = new Gizmox.WebGUI.Forms.ListBox();
            this.tpDgv = new Gizmox.WebGUI.Forms.TabPage();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tcA.SuspendLayout();
            this.tpDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Linen;
            this.pnlTop.Controls.Add(this.textBox1);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.btnClear);
            this.pnlTop.Controls.Add(this.txtA);
            this.pnlTop.Controls.Add(this.btnTest);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.Size = new System.Drawing.Size(419, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.ExcludeFromUniqueId = false;
            this.textBox1.Location = new System.Drawing.Point(292, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.PerformLayoutEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.ExcludeFromUniqueId = false;
            this.button1.Location = new System.Drawing.Point(188, 21);
            this.button1.Name = "button1";
            this.button1.PerformLayoutEnabled = true;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Êý¾Ý¿â²âÊÔ";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.ExcludeFromUniqueId = false;
            this.btnClear.Location = new System.Drawing.Point(94, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.PerformLayoutEnabled = true;
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Çå³ý";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtA
            // 
            this.txtA.ExcludeFromUniqueId = false;
            this.txtA.Font = new System.Drawing.Font("ËÎÌå", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(9, 71);
            this.txtA.Name = "txtA";
            this.txtA.PerformLayoutEnabled = true;
            this.txtA.Size = new System.Drawing.Size(398, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "Hello world";
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // btnTest
            // 
            this.btnTest.ExcludeFromUniqueId = false;
            this.btnTest.Font = new System.Drawing.Font("ËÎÌå", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(9, 21);
            this.btnTest.Name = "btnTest";
            this.btnTest.PerformLayoutEnabled = true;
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "²âÊÔ";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tcA);
            this.tabControl1.Controls.Add(this.tpDgv);
            this.tabControl1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabControl1.ExcludeFromUniqueId = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PerformLayoutEnabled = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 366);
            this.tabControl1.TabIndex = 1;
            // 
            // tcA
            // 
            this.tcA.Controls.Add(this.lst);
            this.tcA.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tcA.ExcludeFromUniqueId = false;
            this.tcA.Location = new System.Drawing.Point(4, 22);
            this.tcA.Name = "tcA";
            this.tcA.PerformLayoutEnabled = true;
            this.tcA.Size = new System.Drawing.Size(411, 340);
            this.tcA.TabIndex = 0;
            this.tcA.Text = "Lst";
            // 
            // lst
            // 
            this.lst.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lst.ExcludeFromUniqueId = false;
            this.lst.Location = new System.Drawing.Point(3, 3);
            this.lst.Name = "lst";
            this.lst.PerformLayoutEnabled = true;
            this.lst.Size = new System.Drawing.Size(411, 329);
            this.lst.TabIndex = 0;
            // 
            // tpDgv
            // 
            this.tpDgv.Controls.Add(this.dgv);
            this.tpDgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpDgv.ExcludeFromUniqueId = false;
            this.tpDgv.Location = new System.Drawing.Point(4, 22);
            this.tpDgv.Name = "tpDgv";
            this.tpDgv.PerformLayoutEnabled = true;
            this.tpDgv.Size = new System.Drawing.Size(411, 340);
            this.tpDgv.TabIndex = 0;
            this.tpDgv.Text = "Dgv";
            // 
            // dgv
            // 
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.ExcludeFromUniqueId = false;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.PerformLayoutEnabled = true;
            this.dgv.RenderCellPanelsAsText = false;
            this.dgv.RowTemplate.Enabled = true;
            this.dgv.Size = new System.Drawing.Size(405, 334);
            this.dgv.TabIndex = 0;
            // 
            // FrmPractice
            // 
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlTop);
            this.Size = new System.Drawing.Size(419, 466);
            this.Text = "FrmPractice";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tcA.ResumeLayout(false);
            this.tpDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel pnlTop;
        private TextBox txtA;
        private Button btnTest;
        private TabControl tabControl1;
        private TabPage tcA;
        private ListBox lst;
        private TabPage tpDgv;
        private DataGridView dgv;
        private Button btnClear;
        private Button button1;
        private TextBox textBox1;
    }
}