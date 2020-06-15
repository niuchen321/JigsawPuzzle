using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JigsawPuzzle
{
    public partial class Form1 : Form
    {
        public Canvas canvas;
        public Form1()
        {
            InitializeComponent();

            //PictureBox所加载的图片刚好填充满
            picBoxCenter.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxThumb.SizeMode = PictureBoxSizeMode.StretchImage;
            //可打开文件分类
            openFileDialog1.Filter = "全部|*.*|png图片|*.png|jpg、jpeg图片|*.jpg;*.jpeg";

            picBoxThumb.Image = picBoxCenter.Image = Properties.Resources._6;
        }
        /// <summary>
        /// 简单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimple_Click(object sender, EventArgs e)
        {           
            if (picBoxCenter.Image==null)
            {
                picBoxThumb.Image = picBoxCenter.Image = Properties.Resources._6;
            }

            canvas = new Canvas(picBoxThumb.Image, 3, 3);
            canvas.GetImages();
           var pathSearch =new PathSearch();
           var path =pathSearch.BroadFirstSearch(canvas);
            label5.Text=  "空白块移动步骤：" + path; 
            Draw();
        }

        /// <summary>
        /// 绘图
        /// </summary>
        /// <param name="isFull">是否绘制全部图块</param>
        private void Draw(bool isFull = false)
        {
            Bitmap bitmap = new Bitmap(picBoxCenter.Width, picBoxCenter.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            //拼图块的宽度
            var width = picBoxCenter.Width / canvas.Columns;
            //拼图块的高度
            var height = picBoxCenter.Height / canvas.Rows;

            for (int i = 0; i < canvas.Rows; i++)
            {
                for (int j = 0; j < canvas.Columns; j++)
                {
                    if (canvas.Blocks[i, j].Location != canvas.Rows * canvas.Columns || isFull)
                    {
                        graphics.DrawImage(canvas.Blocks[i, j].Image, j * width, i * height, width - 1, height - 1);
                    }

                }
            }

            picBoxCenter.Image = bitmap;
            picBoxCenter.Refresh();
        }
        /// <summary>
        /// 鼠标点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxCenter_MouseClick(object sender, MouseEventArgs e)
        {
            if (canvas==null)
            {
                return;
            }

            //拼图块的宽度
            var width = picBoxCenter.Width / canvas.Columns;
            //拼图块的高度
            var height = picBoxCenter.Height / canvas.Rows;

            if (canvas.MoveImages(new Point(e.Y / height, e.X / width)))
            {
                canvas.CurrentSteps++;
                label3.Text = canvas.CurrentSteps.ToString();

                if (canvas.Judge())
                {
                    Draw(true);

                    if (MessageBox.Show("恭喜过关", "是否重新玩一把", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        canvas.BestScores =Math.Min(canvas.BestScores, canvas.CurrentSteps);
                        label4.Text = canvas.BestScores.ToString();
                        canvas.GetImages();
                        var pathSearch = new PathSearch();
                        var path = pathSearch.BroadFirstSearch(canvas);
                        label5.Text = "空白块移动步骤："+ path;
                        Draw();

                    }
                    else
                    {

                        this.Close();
                    }
                }
                else
                {
                    Draw();
                }
            }
        }
        /// <summary>
        /// 普通
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdinary_Click(object sender, EventArgs e)
        {
            if (picBoxCenter.Image == null)
            {
                picBoxThumb.Image = picBoxCenter.Image = Properties.Resources._4;
            }
            canvas = new Canvas(picBoxThumb.Image, 6, 6);
            canvas.GetImages();
            Draw();
        }
        /// <summary>
        /// 困难
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDifficulty_Click(object sender, EventArgs e)
        {
            if (picBoxCenter.Image == null)
            {
                picBoxThumb.Image = picBoxCenter.Image = Properties.Resources._3;
            }
            canvas = new Canvas(picBoxThumb.Image, 9, 9);
            canvas.GetImages();
            Draw();
        }
        /// <summary>
        /// 噩梦
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNightmare_Click(object sender, EventArgs e)
        {
            if (picBoxCenter.Image == null)
            {
                picBoxThumb.Image = picBoxCenter.Image = Properties.Resources._6;
            }
            canvas = new Canvas(picBoxThumb.Image, 12, 12);
            canvas.GetImages(); 
            Draw();
        }
       //图片是否放大
        bool isBig = false;
        /// <summary>
        /// 点击放大图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxThumb_Click(object sender, EventArgs e)
        {
            if (!isBig)
            {
                picBoxMax.Image = picBoxThumb.Image;
                picBoxMax.SizeMode = PictureBoxSizeMode.StretchImage;
                picBoxMax.Show();
                isBig = true;
            }
            else
            {
                picBoxMax.Hide();
                isBig = false;
            }
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            //当弹出选择对话框时，判断是否单击了“打开”键
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //PictureBox加载图片
                picBoxThumb.Image = picBoxCenter.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }
        /// <summary>
        /// 放大图点击关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxMax_Click(object sender, EventArgs e)
        {
            picBoxMax.Hide();
            isBig = false;
        }
    }
}
