using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RussiaBlock.Util;

namespace RussiaBlock.Entities {

    /// <summary>
    /// 背景实体类
    /// </summary>
   public  class Ground {
        /// <summary>
        /// 画背景图
        /// </summary>
        /// <param name="g"></param>
        public void DrawGround(Graphics g){
            for (var row = 0; row < CommonHelper.RowCount; row++) {
                for (var col = 0; col < CommonHelper.ColCount; col++) {
                    g.DrawRectangle(new Pen(CommonHelper.DefaultGridColor), row * CommonHelper.CellWidth, col * CommonHelper.CellWidth, CommonHelper.CellWidth, CommonHelper.CellWidth);
                    //搞清楚这步，理解这步操作。
                    g.FillRectangle(new SolidBrush(CommonHelper.DefaultBgColor), row * CommonHelper.CellWidth + 1, col * CommonHelper.CellWidth + 1, CommonHelper.CellWidth - 1, CommonHelper.CellWidth - 1);
                }
            }
        }
   }
}
