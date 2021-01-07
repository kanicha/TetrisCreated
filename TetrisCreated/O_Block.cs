using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisCreated
{
    class O_Block : Block
    {
        public O_Block()
        {
            // rectをnewしてその中に呼出し
            rectList = new List<Rectangle>
            {
                // ブロック座標情報リストに追加
                new Rectangle(0, 0, 10, 10),
                new Rectangle(10, 0, 10, 10),
                new Rectangle(0, 10, 10, 10),
                new Rectangle(10, 10, 10, 10)
            };
            // 大きさを代入
            width = 20;
            height = 20;
            color = Color.Yellow;
        }
    }
}
