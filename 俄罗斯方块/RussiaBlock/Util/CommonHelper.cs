using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussiaBlock.Util {
    public class CommonHelper {
        //总行数 
        public static int RowCount { get; set; } = 20;

        //总列数
        public static int ColCount { get; set; } = 16;

        //方块的宽和高，由于是正方形
        public static int CellWidth { get; set; }

        /// <summary>
        /// 计算整个游戏中的公用值
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static Size SetValues(int width, int height) {
            int w = width / ColCount;
            int h = height / RowCount;
            MidIndex = ColCount/2;
            //这两个值，取小
            CellWidth = w > h ? h : w;//方块是正方形
            return new Size(CellWidth * ColCount + 1, RowCount * CellWidth + 1);
        }

        /// <summary>
        /// 默认的网格色DefaultGridColor
        /// </summary>
        public static Color DefaultGridColor { get; set; } = Color.Black;
        /// <summary>
        /// 默认的背景色DefaultBgColor
        /// </summary>
        public static Color DefaultBgColor { get; set; } = Color.White;

        /// <summary>
        /// 默认的形状色DefaultShapeColor
        /// </summary>
        public static Color DefaultShapeColor { get; set; } = Color.SkyBlue;

        /// <summary>
        /// 默认的障碍物颜色DefaultObstacleColor
        /// </summary>
        public static Color DefaultObstacleColor { get; set; } = Color.Yellow;


        /// <summary>
        /// 形状出现的中间值坐标MidIndex
        /// </summary>
        public static int MidIndex { get; set; }


    }
}
