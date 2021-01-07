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

        /// <summary>
        /// Iミノボタン押し込み作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 初期化と同時に一つ作成を行う
            Block _b = new I_Block();
            blockList.Add(_b);
        }

        /// <summary>
        /// Jミノボタン押し込み作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // 初期化と同時に一つ作成を行う
            Block _b = new J_Block();
            blockList.Add(_b);
        }

        /// <summary>
        ///  Lミノボタン押し込み作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // 初期化と同時に一つ作成を行う
            Block _b = new L_Block();
            blockList.Add(_b);
        }

        /// <summary>
        /// Oミノボタン押し込み作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            // 初期化と同時に一つ作成を行う
            Block _b = new O_Block();
            blockList.Add(_b);
        }

        /// <summary>
        /// Sミノボタン押し込み作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            // 初期化と同時に一つ作成を行う
            Block _b = new S_Block();
            blockList.Add(_b);
        }

        /// <summary>
        /// Zミノボタン押し込み作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            // 初期化と同時に一つ作成を行う
            Block _b = new Z_Block();
            blockList.Add(_b);
        }

        /// <summary>
        /// Tミノボタン押し込み作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            // 初期化と同時に一つ作成を行う
            Block _b = new T_Block();
            blockList.Add(_b);
        }
    }
}
