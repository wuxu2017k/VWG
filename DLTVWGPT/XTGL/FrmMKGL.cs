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

namespace DLTVWGPT.XTGL
{
    public partial class FrmMKGL : UserControl
    {
        public FrmMKGL()
        {
            InitializeComponent();
        }

        private void FrmMKGL_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        public void Prepare()
        {
            createFuncTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
        }
        private void createFuncTree()
        {
            string cmd = @"SELECT id, mc, bm, jb,id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5 FROM vfuncsa WHERE jb > 0 ORDER BY xh0, xh1, xh2, xh3, xh4, xh5";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            foreach (DataRow r in dt.Rows)
            {
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 1; i <= jb; i++)
                {
                    id = "id" + i;
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    if (tns.Length > 0)
                    {
                        tp = tns[0];
                    }
                    else
                    {
                        tn = createANode(r, i);
                        if (tp == null)
                        {
                            trV.Nodes.Add(tn);
                        }
                        else
                        {
                            tp.Nodes.Add(tn);
                        }
                    }
                }
            }
        }
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            string bm = "bm" + jb;
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            return tn;
        }
    }
}