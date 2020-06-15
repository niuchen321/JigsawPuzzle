using JigsawPuzzle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JigsawPuzzle
{
    /// <summary>
    /// 路径搜索算法
    /// </summary>
    public class PathSearch
    {

        /// <summary>
        /// 广度优先搜索
        /// </summary>
        /// <param name="currentBlocks">当前拼图信息</param>
        /// <param name="endBlocks">最终拼图信息</param>
        public string BroadFirstSearch(Canvas canvas)
        {
            Queue<Nodes> openQueue = new Queue<Nodes>();
            Queue<string> closeQueue = new Queue<string>();

            BlockInfo[,] blockInfos=new BlockInfo[canvas.Rows,canvas.Columns];

            Array.Copy(canvas.Blocks,blockInfos,canvas.Blocks.Length);
           openQueue.Enqueue(new Nodes()
            {
                Blocks = blockInfos,
                CurrentPoint =canvas.CurrentLocation,
                GameStapes = ""
            });

            while (true)
            {
                if (openQueue.Count < 1)
                {
                    return "";
                }

                var node = openQueue.Dequeue();

                closeQueue.Enqueue(GetStrng(node.Blocks,canvas));

                //空白块位置
                var point = node.CurrentPoint;
                //空白块上移
                if (point.X > 0)
                {
                    var nodeLeft = new Nodes()
                    {                
                        GameStapes = node.GameStapes,
                        Blocks=new BlockInfo[canvas.Rows,canvas.Columns]
                    };

                    Array.Copy(node.Blocks, nodeLeft.Blocks, canvas.Blocks.Length);

                    nodeLeft.Blocks[point.X, point.Y] = node.Blocks[point.X - 1, point.Y];
                    nodeLeft.Blocks[point.X - 1, point.Y] = node.Blocks[point.X, point.Y];
                    nodeLeft.CurrentPoint = new Point(point.X - 1, point.Y);
                    if (Judge(nodeLeft.Blocks, canvas))
                    {
                        return nodeLeft.GameStapes + "上";
                    }
                    if (!openQueue.Contains(nodeLeft) && !closeQueue.Contains(GetStrng(nodeLeft.Blocks, canvas)))
                    {
                        nodeLeft.GameStapes += "上";
                        openQueue.Enqueue(nodeLeft);
                    }
                }
                //空白块下移
                if (point.X < canvas.Rows - 1)
                {
                    var nodeRight = new Nodes()
                    {
                        GameStapes = node.GameStapes,
                        Blocks = new BlockInfo[canvas.Rows, canvas.Columns]
                    };
                    Array.Copy(node.Blocks, nodeRight.Blocks, canvas.Blocks.Length);
                    nodeRight.Blocks[point.X, point.Y] = node.Blocks[point.X + 1, point.Y];
                    nodeRight.Blocks[point.X + 1, point.Y] = node.Blocks[point.X, point.Y];
                    nodeRight.CurrentPoint = new Point(point.X + 1, point.Y);
                    if (Judge(nodeRight.Blocks, canvas))
                    {
                        return nodeRight.GameStapes + "下";
                    }

                    if (!openQueue.Contains(nodeRight) && !closeQueue.Contains(GetStrng(nodeRight.Blocks, canvas)))
                    {
                        nodeRight.GameStapes += "下";
                        openQueue.Enqueue(nodeRight);
                    }
                }
                //空白块左移
                if (point.Y > 0)
                {
                    var nodeUp = new Nodes()
                    {
                        GameStapes = node.GameStapes,
                        Blocks = new BlockInfo[canvas.Rows, canvas.Columns]
                    };
                    Array.Copy(node.Blocks, nodeUp.Blocks, canvas.Blocks.Length);
                    nodeUp.Blocks[point.X, point.Y] = node.Blocks[point.X, point.Y - 1];
                    nodeUp.Blocks[point.X, point.Y - 1] = node.Blocks[point.X, point.Y];
                    nodeUp.CurrentPoint = new Point(point.X, point.Y - 1);
                    if (Judge(nodeUp.Blocks, canvas))
                    {
                        return nodeUp.GameStapes + "左";
                    }

                    if (!openQueue.Contains(nodeUp) && !closeQueue.Contains(GetStrng(nodeUp.Blocks, canvas)))
                    {
                        nodeUp.GameStapes += "左";
                        openQueue.Enqueue(nodeUp);
                    }
                }
                //空白块右移
                if (point.Y < canvas.Columns - 1)
                {
                    var nodeDown = new Nodes()
                    {
                        GameStapes = node.GameStapes,
                        Blocks = new BlockInfo[canvas.Rows, canvas.Columns]
                    };
                    Array.Copy(node.Blocks, nodeDown.Blocks, canvas.Blocks.Length);
                    nodeDown.Blocks[point.X, point.Y] = node.Blocks[point.X, point.Y + 1];
                    nodeDown.Blocks[point.X, point.Y + 1] = node.Blocks[point.X, point.Y];
                    nodeDown.CurrentPoint = new Point(point.X, point.Y + 1);
                    if (Judge(nodeDown.Blocks, canvas))
                    {
                        return nodeDown.GameStapes + "右";
                    }

                    if (!openQueue.Contains(nodeDown) && !closeQueue.Contains(GetStrng(nodeDown.Blocks, canvas)))
                    {
                        nodeDown.GameStapes += "右";
                        openQueue.Enqueue(nodeDown);
                    }
                }
            }
        }

        /// <summary>
        /// 判断是否完成游戏
        /// </summary>
        /// <returns></returns>
        public bool Judge(BlockInfo[,] blocks, Canvas canvas)
        {
            var location = 1;
            for (int i = 0; i < canvas.Rows; i++)
            {
                for (int j = 0; j < canvas.Columns; j++)
                {
                    if (blocks[i, j].Location != location)
                    {
                        return false;
                    }
                    location++;
                }
            }
            return true;
        }

        /// <summary>
        /// 判断是否完成游戏
        /// </summary>
        /// <returns></returns>
        public string GetStrng(BlockInfo[,] blocks, Canvas canvas)
        {
            var str = "";
            for (int i = 0; i < canvas.Rows; i++)
            {
                for (int j = 0; j < canvas.Columns; j++)
                {
                    str += blocks[i, j].Location;
                }
            }
            return str;
        }

        /// <summary>
        /// 深度优先搜索
        /// </summary>
        public void DepthFirstSearch()
        {

        }

    }

    public class Nodes
    {
        /// <summary>
        /// 空白块位置
        /// </summary>
        public Point CurrentPoint { get; set; }
        /// <summary>
        /// 游戏步骤
        /// </summary>
        public string GameStapes { get; set; }
        /// <summary>
        /// 图块信息
        /// </summary>
        public BlockInfo[,] Blocks { get; set; }
    }
}
