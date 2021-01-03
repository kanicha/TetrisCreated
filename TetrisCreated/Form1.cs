// Sakamaki Daiki

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisCreated
{
    public partial class Form1 : Form
    {


        // ブロックリスト作成
        List<Rectangle> rectList;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 各ロード関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
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
        }

        /// <summary>
        /// PictureBox描画関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // foreach を使い描画
            foreach (Rectangle rect in rectList)
            {
                e.Graphics.FillRectangle(Brushes.Red, rect);
            }
        }

        /// <summary>
        /// 時間経過関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTimer_Tick_1(object sender, EventArgs e)
        {
            // for文でListのCountをループさせる
            for (int i = 0; i < rectList.Count; i++)
            {
                // rectListの i 配列分を Rectangle 型の _r に代入を行う
                Rectangle _r = rectList[i];
                // rectListの中身を引き継いだ _r 変数を使って時間経過とともに座標を動かす
                _r = new Rectangle(_r.Left, _r.Top + 10, _r.Width, _r.Height);
                // 最終的にlistに代入
                rectList[i] = _r;
            }
        }

        /// <summary>
        /// 時間経過描画初期化処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawTimer_Tick(object sender, EventArgs e)
        {
            // Refreshをかけ更新処理
            pictureBox1.Refresh();
        }

    }
}
