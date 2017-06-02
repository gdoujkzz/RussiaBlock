﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussiaBlock.Entities { 
    class ShapeL:Shape {
        public override void SetUnits()
        {
            Units[0].Position=new CellPosition() {RowIndex = 0,ColIndex = Util.CommonHelper.MidIndex};
            Units[1].Position = new CellPosition() { RowIndex = 1, ColIndex = Util.CommonHelper.MidIndex };
            Units[2].Position = new CellPosition() { RowIndex = 2, ColIndex = Util.CommonHelper.MidIndex };
            Units[3].Position = new CellPosition() { RowIndex = 2, ColIndex = Util.CommonHelper.MidIndex+1 };
        }
    }
}
