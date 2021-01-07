using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisCreated
{
    class I_Block : Block
    {
        public I_Block()
        {
            // rectをnewしてその中に呼出し
            rectList = new List<Rectangle>
            {
                // ブロック座標情報リストに追加
                new Rectangle(0, 0, 10, 10),
                new Rectangle(10, 0, 10, 10),
                new Rectangle(20, 0, 10, 10),
                new Rectangle(30, 0, 10, 10)
            };
            // 大きさを代入
            width = 40;
            height = 10;
            color = Color.Cyan;
        }
    }
}
