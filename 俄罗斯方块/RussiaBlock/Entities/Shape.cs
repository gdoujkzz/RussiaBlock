using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RussiaBlock.Util;

namespace RussiaBlock.Entities {
   public abstract class Shape {

        /// <summary>
        /// 组成形状的四个单元
        /// </summary>
      public ShapeUnit[] Units { get; set; }=new ShapeUnit[4];


        /// <summary>
        /// 只有子类对象才会调用这个构造方法
        /// </summary>
       protected Shape(){
           for (var i = 0; i < Units.Length; i++){
               Units[i]=new ShapeUnit();
           }
           SetUnits();
       }

        /// <summary>
        /// 父类只是规定
        /// </summary>
       public abstract void SetUnits();

       public void DrawShape(Graphics g){
           for (var i = 0; i < this.Units.Length; i++){
               Units[i].DrawUnit(g);
            }
        }
        
    }
}
