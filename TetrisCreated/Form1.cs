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
            // AddBlock関数呼び出し
            AddBlock();
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
            if (blockList.Count > 0)
            {
                // 最後のブロックを習得しUpdate関数でUpdate処理
                Block lastBlock = blockList.Last();
                lastBlock.Update(pictureBox1.Height);

                // 最後のブロックが落下したらAddBlockを呼び出す
                if (lastBlock.fallCheck)
                {
                    AddBlock();
                }
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

        /* ここから各ブロック制御*/

        /// <summary>
        /// ブロックランダム作成と追加
        /// </summary>
        private void AddBlock()
        {
            // ランダム生成されたBlockを代入用変数と初期化
            Block newBlock = null;
            // Random型の変数宣言
            Random rand = new Random();

            // Switch文で分岐しrand変数をつかいランダム生成
            switch (rand.Next(7))
            {
                case 0:
                    newBlock = new I_Block();
                    break;
                case 1:
                    newBlock = new J_Block();
                    break;
                case 2:
                    newBlock = new L_Block();
                    break;
                case 3:
                    newBlock = new O_Block();
                    break;
                case 4:
                    newBlock = new S_Block();
                    break;
                case 5:
                    newBlock = new Z_Block();
                    break;
                case 6:
                    newBlock = new T_Block();
                    break;
            }
            // ランダム生成されたBlockをblockListに代入
            blockList.Add(newBlock);
        }

        /// <summary>
        /// キー入力関数
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        [System.Security.Permissions.UIPermission(
            System.Security.Permissions.SecurityAction.Demand,
            Window = System.Security.Permissions.UIPermissionWindow.AllWindows)]
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (blockList.Count > 0)
            {
                // ブロックリストのラスト取り出す
                Block lastBlock = blockList.Last();

                /* 各キーで分岐 */
                // ↓キーで y +10
                if ((keyData & Keys.KeyCode) == Keys.Down)
                {
                    lastBlock.Move(new Point(0, 10), pictureBox1.Size);
                }
                // ←キーで x -10
                else if ((keyData & Keys.KeyCode) == Keys.Left)
                {
                    lastBlock.Move(new Point(-10, 0), pictureBox1.Size);
                }
                // →キーで x +10
                else if ((keyData & Keys.KeyCode) == Keys.Right)
                {
                    lastBlock.Move(new Point(10, 0), pictureBox1.Size);
                }
            }

            // 押されたキーを返す
            return base.ProcessDialogKey(keyData);
        }


        ///// <summary>
            ///// Iミノボタン押し込み作成
            ///// </summary>
            ///// <param name="sender"></param>
            ///// <param name="e"></param>
            //private void button1_Click(object sender, EventArgs e)
            //{
            //    // 初期化と同時に一つ作成を行う
            //    Block _b = new I_Block();
            //    blockList.Add(_b);
            //}

            ///// <summary>
            ///// Jミノボタン押し込み作成
            ///// </summary>
            ///// <param name="sender"></param>
            ///// <param name="e"></param>
            //private void button2_Click(object sender, EventArgs e)
            //{
            //    // 初期化と同時に一つ作成を行う
            //    Block _b = new J_Block();
            //    blockList.Add(_b);
            //}

            ///// <summary>
            /////  Lミノボタン押し込み作成
            ///// </summary>
            ///// <param name="sender"></param>
            ///// <param name="e"></param>
            //private void button3_Click(object sender, EventArgs e)
            //{
            //    // 初期化と同時に一つ作成を行う
            //    Block _b = new L_Block();
            //    blockList.Add(_b);
            //}

            ///// <summary>
            ///// Oミノボタン押し込み作成
            ///// </summary>
            ///// <param name="sender"></param>
            ///// <param name="e"></param>
            //private void button4_Click(object sender, EventArgs e)
            //{
            //    // 初期化と同時に一つ作成を行う
            //    Block _b = new O_Block();
            //    blockList.Add(_b);
            //}

            ///// <summary>
            ///// Sミノボタン押し込み作成
            ///// </summary>
            ///// <param name="sender"></param>
            ///// <param name="e"></param>
            //private void button5_Click(object sender, EventArgs e)
            //{
            //    // 初期化と同時に一つ作成を行う
            //    Block _b = new S_Block();
            //    blockList.Add(_b);
            //}

            ///// <summary>
            ///// Zミノボタン押し込み作成
            ///// </summary>
            ///// <param name="sender"></param>
            ///// <param name="e"></param>
            //private void button6_Click(object sender, EventArgs e)
            //{
            //    // 初期化と同時に一つ作成を行う
            //    Block _b = new Z_Block();
            //    blockList.Add(_b);
            //}

            ///// <summary>
            ///// Tミノボタン押し込み作成
            ///// </summary>
            ///// <param name="sender"></param>
            ///// <param name="e"></param>
            //private void button7_Click(object sender, EventArgs e)
            //{
            //    // 初期化と同時に一つ作成を行う
            //    Block _b = new T_Block();
            //    blockList.Add(_b);
            //}
        }
}
