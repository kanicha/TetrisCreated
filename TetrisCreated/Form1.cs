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
        private List<Block> blockList;

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
            // ブロックリスト初期化
            blockList = new List<Block>();
            // 初期化と同時に一つ作成を行う
            Block _b = new Block();
            blockList.Add(_b);
        }

        /// <summary>
        /// PictureBox描画関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // blockList呼び出し、変数 b に代入を行い呼び込みUpdate
            foreach (Block b in blockList)
            {
                b.Draw(e.Graphics);
            }
        }

        /// <summary>
        /// 時間経過関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTimer_Tick_1(object sender, EventArgs e)
        {
            // 時間経過も呼出
            foreach (Block b in blockList)
            {
                b.Update(pictureBox1.Height);
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
