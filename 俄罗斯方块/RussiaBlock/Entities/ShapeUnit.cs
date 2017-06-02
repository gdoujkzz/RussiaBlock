using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RussiaBlock.Util;

namespace RussiaBlock.Entities {

    //形状单元
   public class ShapeUnit
   {
        /// <summary>
        /// 每一个形状单元的坐标值 CellPosition Positio
        /// </summary>
        public CellPosition Position { get; set; }

       public void DrawUnit(Graphics g)
       {
            g.FillRectangle(new SolidBrush(CommonHelper.DefaultShapeColor), Position.ColIndex * CommonHelper.CellWidth + 1, Position.RowIndex * CommonHelper.CellWidth + 1, CommonHelper.CellWidth - 1, CommonHelper.CellWidth - 1);
        }
   }
}
