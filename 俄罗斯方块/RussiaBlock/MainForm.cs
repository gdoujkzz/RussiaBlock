using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RussiaBlock.Entities;
using RussiaBlock.Util;

namespace RussiaBlock {
    public partial class frm_main : Form {
        public frm_main() {
            InitializeComponent();
            //进行重置
          this.pnl_game.Size= Util.CommonHelper.SetValues(this.pnl_game.Width,this.pnl_game.Height);
        }

        private void btn_star_Click(object sender, EventArgs e) {

            #region 开始游戏欢迎词
            //这里需要放开始游戏的时候的相关迎接代码 
            #endregion

            #region 绘制背景网格
            //先有一个画家
            Graphics g = Graphics.FromHwnd(this.pnl_game.Handle); 
             //如何把这个网格画出来呢。
            Ground ground=new Ground();
            ground.DrawGround(g);
            #endregion

            #region 绘制形状（其实就是填充单元格(四个），然后改相应的左标）
            Shape shape=new ShapeL();
            shape.DrawShape(g);

            #endregion

        }
    }
}
