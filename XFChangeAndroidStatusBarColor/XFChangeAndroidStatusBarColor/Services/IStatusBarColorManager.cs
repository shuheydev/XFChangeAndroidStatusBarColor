using System;
using System.Collections.Generic;
using System.Text;

namespace XFChangeAndroidStatusBarColor.Services
{
    public interface IStatusBarColorManager
    {
        void SetColor(System.Drawing.Color color, bool darkStatusBarTint);
    }
}
