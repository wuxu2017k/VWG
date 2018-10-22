using DLTLib.Classes;
using DLTVWGPT.XTGL;
using Gizmox.WebGUI.Forms;
using System;

namespace DLTVWGPT.Classes
{
    public class ClsFuncsA:ClsFuncs
    {
        private TabPage tp;
        public ClsFuncsA(TabPage aTp)
        {
            tp = aTp;
        }
        public override void Call(int aId, string aBm, string aMc)
        {
            #region 系统管理
            //模块管理
            if (string.Compare(aBm, "xtgl-mkgl", true) == 0)
            {
                FrmMKGL c = new FrmMKGL();
                tp.Controls.Clear();
                tp.Controls.Add(c);
                return;
            }
            #endregion
            ClsMsgBox.Jg(aId + "," + aBm + "," + aMc+Environment.NewLine+"此功能正在实现中");
        }
    }
}