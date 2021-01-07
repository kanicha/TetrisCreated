using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisCreated
{
    abstract  class Block
    {
        // ブロックリスト作成
        public List<Rectangle> rectList;

        // ポジション確認変数
        public Point pos;
        // 色変化変数
        public Color color;

        // 縦横変数
        public int width;
        public int height;
        // 落下確認bool型変数
        public bool fallCheck;

        /// <summary>
        /// ブロック作成クラス
        /// </summary>
        public Block()
        {

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
            using (SolidBrush b = new SolidBrush(color))
            {
                // foreach を使い描画
                foreach (Rectangle rect in rectList)
                {
                    g.FillRectangle(b, new Rectangle(pos.X + rect.Left, pos.Y + rect.Top, rect.Width - 1, rect.Height - 1));
                }
            }
        }

        /// <summary>
        /// テトリミノ移動用関数
        /// </summary>
        /// <param name="offset"></param>
        public void Move(Point offset)
        {
            pos = new Point(pos.X + offset.X, pos.Y + offset.Y);
        }
    }
}
