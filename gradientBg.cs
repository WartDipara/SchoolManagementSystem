﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SchoolManagementSystem
{
    internal class gradientBg:Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            //获取新改变的值
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom,90F);
            Graphics g=e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            //重新传入参数
            base.OnPaint(e);
        }
    }
}
