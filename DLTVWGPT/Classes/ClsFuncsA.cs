using DLTLib.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DLTVWGPT.Classes
{
    public class ClsFuncsA:ClsFuncs
    {
        public override void Call(int aId, string aBm, string aMc)
        {
            ClsMsgBox.Jg(aId + "," + aBm + "," + aMc+Environment.NewLine+"此功能正在实现中");
        }
    }
}