using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisCreated
{
    class Block
    {
        // ブロックリスト作成
        List<Rectangle> rectList;

        // ポジション確認変数
        Point pos;
        // 縦横変数
        int width;
        int height;
        // 落下確認bool型変数
        bool fallCheck;

        /// <summary>
        /// ブロック作成クラス
        /// </summary>
        public Block()
        {
            // rectをnewしてその中に呼出し
            rectList = new List<Rectangle>
            {
                // ブロック座標情報リストに追加
                new Rectangle(0, 0, 10, 10),
                new Rectangle(10, 0, 10, 10),
                new Rectangle(10, 10, 10, 10),
                new Rectangle(20, 10, 10, 10)
            };
            // 大きさを代入
            width = 30;
            height = 20;
        }

        /// <summary>
        /// Update処理クラス
        /// </summary>
        /// <returns>フィールドの高さ</returns>
        public void Update(int fieldHeight)
        {
            // 落ちたブロックはそれ以上動かないように制御
            if (fallCheck == false)
            {
                //Updateで秒ごとに座標を 10 増やす
                Point newPos = new Point(pos.X, pos.Y + 10);

                // newPos Y値とミノのZの値がフィールドの高さを超えたら
                if (newPos.Y + height > fieldHeight)
                {
                    // newPos.Yを増えないようにし落下フラグをtrue
                    newPos.Y = fieldHeight - height;
                    fallCheck = true;
                }

                // 同期を行うため代入
                pos = newPos;
            }
        }

        /// <summary>
        /// 描画関数
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            // foreach を使い描画
            foreach (Rectangle rect in rectList)
            {
                g.FillRectangle(Brushes.Red, new Rectangle(pos.X + rect.Left, pos.Y + rect.Top, rect.Width - 1, rect.Height - 1));
            }
        }
    }
}
