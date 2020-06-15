using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JigsawPuzzle
{
    /// <summary>
    /// 主题画板
    /// </summary>
    public class Canvas
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="image"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public Canvas(Image image,int rows,int columns)
        {
            CurrentImage = image;
            Rows = rows;
            Columns = columns;
            CurrentSteps = 0;
            BestScores = int.MaxValue;
        }
        /// <summary>
        /// 当前拼图图片
        /// </summary>
        public Image CurrentImage { get; set; }
        /// <summary>
        /// 行数
        /// </summary>
        public int Rows { get; set; }
        /// <summary>
        /// 列数
        /// </summary>
        public int Columns { get; set; }
        /// <summary>
        /// 当前高度
        /// </summary>
        public int CurrentHeight { get; set; }
        /// <summary>
        /// 最好成绩
        /// </summary>
        public int BestScores { get; set; }
        /// <summary>
        /// 当前步数
        /// </summary>
        public int CurrentSteps { get; set; }
        /// <summary>
        /// 拼图图块集合
        /// </summary>
        public BlockInfo[,] Blocks { get; set; }
        /// <summary>
        /// 空白拼图块位置
        /// </summary>
        public Point CurrentLocation { get; set; }

        public void GetImages()
        {
            BlockInfo[,] blocks= new BlockInfo[Rows, Columns];
            //拼图块的宽度
            var width = CurrentImage.Width / Columns;
            //拼图块的高度
            var height = CurrentImage.Height / Rows;
            var location = 1;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    blocks[i, j] = new BlockInfo();
                    //创建位图
                    Bitmap bitmap = new Bitmap(width, height);
                    //创建作图区域
                    Graphics graphics = Graphics.FromImage(bitmap);
                    //截取原图相应区域到新图
                    graphics.DrawImage(CurrentImage, 0, 0, new Rectangle(width * j, height * i, width, height), GraphicsUnit.Pixel);
                    blocks[i, j].Image = Image.FromHbitmap(bitmap.GetHbitmap());
                    blocks[i, j].Location = location;
                    location++;
                }
            }
            Blocks = blocks;
            CurrentLocation = new Point(Rows-1,Columns-1);
            UpsetBlock();
        }

        /// <summary>
        /// 移动图块
        /// </summary>
        /// <param name="currentPoint">点击图块位置</param>
        public bool MoveImages(Point currentPoint )
        {
            //最大位置（保存空白块）
            var maxLocation = Rows * Columns;

            //左移
            if (currentPoint.X>0&&Blocks[currentPoint.X-1,currentPoint.Y].Location==maxLocation)
            {
                Swap(currentPoint, new Point(currentPoint.X - 1, currentPoint.Y));
                return true;
            }//右移
            else if(currentPoint.X<Rows-1&&Blocks[currentPoint.X+1,currentPoint.Y].Location==maxLocation)
            {
                Swap(currentPoint, new Point(currentPoint.X + 1, currentPoint.Y));
                return true;
            }//上移
            else if (currentPoint.Y<Columns-1&&Blocks[currentPoint.X,currentPoint.Y+1].Location==maxLocation)
            {
                Swap(currentPoint, new Point(currentPoint.X, currentPoint.Y + 1));
                return true;
            }//下移
            else if (currentPoint.Y >0 && Blocks[currentPoint.X, currentPoint.Y - 1].Location == maxLocation)
            {
                Swap(currentPoint, new Point(currentPoint.X, currentPoint.Y - 1));
                return true;
            }
            return false;
        }

        /// <summary>
        /// 交换图块位置
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Swap(Point a,Point b)
        {
            BlockInfo temp = new BlockInfo();
            temp = Blocks[a.X, a.Y];
            Blocks[a.X, a.Y] = Blocks[b.X, b.Y];
            Blocks[b.X, b.Y] = temp;

            if (a==CurrentLocation)
            {
                CurrentLocation = b;
            }
            if (b==CurrentLocation)
            {
                CurrentLocation = a;
            }
        }

        /// <summary>
        /// 打乱图块（从最后空白图块随机移动一定次数）
        /// </summary>
        private void UpsetBlock()
        {
            var random = new Random((int)DateTime.Now.Ticks);

            Point point = new Point(Rows - 1, Columns - 1);

            for (int i = 0; i < 1000; i++)
            {                
                switch (random.Next(0, 4))//随机0-3表示上下左右
                {
                    case 0:
                        if (point.Y<Columns-1)
                        {
                           if(MoveImages(new Point(point.X, point.Y + 1)))
                            {
                                point.Y++;
                            }
                        }
                        break;
                    case 1:
                        if (point.Y >0)
                        {
                            if (MoveImages(new Point(point.X, point.Y - 1)))
                            {
                                point.Y--;
                            }
                        }
                        break;
                    case 2:
                        if (point.X>0)
                        {
                            if (MoveImages(new Point(point.X-1, point.Y)))
                            {
                                point.X--;
                            }
                        }
                        break;
                    case 3:
                        if (point.X<Rows-1)
                        {
                            if (MoveImages(new Point(point.X+1, point.Y )))
                            {
                                point.X++;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }                      
        }
        /// <summary>
        /// 判断是否完成游戏
        /// </summary>
        /// <returns></returns>
        public bool Judge()
        {
            var location = 1;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                   if(Blocks[i, j].Location != location)
                    {
                        return false;
                    }
                    location++;
                }
            }
            return true;
        }


        public Point GetPoint(BlockInfo[,] blocks)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (Blocks[i, j].Location == Rows*Columns)
                    {
                        return new Point(i,j);
                    }
                }
            }
            return new Point();
        }
    }
}
