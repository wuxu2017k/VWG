using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace DLTVWGPT.Controls
{
    partial class UCFuncsTree
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

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFuncsTree));
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.imageList1 = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // trV
            // 
            this.trV.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.trV.ExcludeFromUniqueId = false;
            this.trV.ImageKey = "Folders.Folder_yellow_close.ico";
            this.trV.ImageList = this.imageList1;
            this.trV.Location = new System.Drawing.Point(0, 0);
            this.trV.Name = "trV";
            this.trV.PerformLayoutEnabled = true;
            this.trV.SelectedImageKey = "Folders.Folder_yellow_open.ico";
            this.trV.SelectOnRightClick = true;
            this.trV.Size = new System.Drawing.Size(270, 470);
            this.trV.TabIndex = 0;
            this.trV.NodeMouseDoubleClick += new Gizmox.WebGUI.Forms.TreeNodeMouseClickEventHandler(this.trV_NodeMouseDoubleClick);
            this.trV.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.trV_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imageList1.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imageList1.Images1"))});
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.Images.SetKeyName(0, "Folders.Folder_yellow_close.ico");
            this.imageList1.Images.SetKeyName(1, "Folders.Folder_yellow_open.ico");
            // 
            // UCFuncsTree
            // 
            this.Controls.Add(this.trV);
            this.Size = new System.Drawing.Size(270, 470);
            this.Text = "UCFuncsTree";
            this.ResumeLayout(false);

        }


        #endregion

        private TreeView trV;
        private ImageList imageList1;
    }
}