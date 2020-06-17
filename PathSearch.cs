using JigsawPuzzle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JigsawPuzzle
{
    /// <summary>
    /// 路径搜索算法
    /// </summary>
    public class PathSearch
    {

        private static Queue<string> openQueue = new Queue<string>();
        private static Dictionary<string, Nodes> keyValues = new Dictionary<string, Nodes>();

        public PathSearch()
        {
            openQueue = new Queue<string>();
            keyValues = new Dictionary<string, Nodes>();
        }

        /// <summary>
        /// 广度优先搜索（BFS）
        /// </summary>
        /// <param name="canvas"></param>
        /// <param name="rows">行数</param>
        /// <param name="columns">列数</param>
        /// <param name="startBlockInfos">开始数组</param>
        /// <param name="endLocationStr">结束位置字符串</param>
        /// <param name="emptyPoint">空白块坐标</param>
        /// <returns></returns>
        public async Task<string> BroadFirstSearch(int rows, int columns, BlockInfo[,] startBlockInfos, string endLocation, Point emptyPoint)
        {
            var blockStr = GetString(startBlockInfos, rows, columns);

            openQueue.Enqueue(blockStr);

            BlockInfo[,] blockInfos = new BlockInfo[rows, columns];

            Array.Copy(startBlockInfos, blockInfos, startBlockInfos.Length);

            keyValues.Add(blockStr, new Nodes()
            {
                Blocks = blockInfos,
                CurrentPoint = emptyPoint,
                GameStapes = ""
            });

            while (true)
            {
                try
                {

                    if (openQueue.Count < 1 || keyValues.Count >= 1000000)
                    {
                        return "";
                    }

                    var nodeStr = openQueue.Dequeue();

                    if (keyValues.TryGetValue(nodeStr, out Nodes node))
                    {
                        //空白块位置
                        var point = node.CurrentPoint;
                        //空白块上移
                        if (point.X > 0)
                        {
                            var childNode = new Nodes()
                            {
                                GameStapes = node.GameStapes,
                                Blocks = new BlockInfo[rows, columns]
                            };

                            Array.Copy(node.Blocks, childNode.Blocks, node.Blocks.Length);

                            childNode.Blocks[point.X, point.Y] = node.Blocks[point.X - 1, point.Y];
                            childNode.Blocks[point.X - 1, point.Y] = node.Blocks[point.X, point.Y];
                            childNode.CurrentPoint = new Point(point.X - 1, point.Y);

                            var childNodeStr = GetString(childNode.Blocks, rows, columns);

                            if (childNodeStr == endLocation)
                            {
                                return childNode.GameStapes + "上";
                            }
                            if (!keyValues.ContainsKey(childNodeStr))
                            {
                                childNode.GameStapes += "上";
                                openQueue.Enqueue(childNodeStr);
                                keyValues.Add(childNodeStr, childNode);
                            }
                        }
                        //空白块下移
                        if (point.X < rows - 1)
                        {
                            var childNode = new Nodes()
                            {
                                GameStapes = node.GameStapes,
                                Blocks = new BlockInfo[rows, columns]
                            };
                            Array.Copy(node.Blocks, childNode.Blocks, node.Blocks.Length);
                            childNode.Blocks[point.X, point.Y] = node.Blocks[point.X + 1, point.Y];
                            childNode.Blocks[point.X + 1, point.Y] = node.Blocks[point.X, point.Y];
                            childNode.CurrentPoint = new Point(point.X + 1, point.Y);

                            var childNodeStr = GetString(childNode.Blocks, rows, columns);

                            if (childNodeStr == endLocation)
                            {
                                return childNode.GameStapes + "下";
                            }

                            if (!keyValues.ContainsKey(childNodeStr))
                            {
                                childNode.GameStapes += "下";
                                openQueue.Enqueue(childNodeStr);
                                keyValues.Add(childNodeStr, childNode);
                            }
                        }
                        //空白块左移
                        if (point.Y > 0)
                        {
                            var childNode = new Nodes()
                            {
                                GameStapes = node.GameStapes,
                                Blocks = new BlockInfo[rows, columns]
                            };
                            Array.Copy(node.Blocks, childNode.Blocks, node.Blocks.Length);
                            childNode.Blocks[point.X, point.Y] = node.Blocks[point.X, point.Y - 1];
                            childNode.Blocks[point.X, point.Y - 1] = node.Blocks[point.X, point.Y];
                            childNode.CurrentPoint = new Point(point.X, point.Y - 1);
                            var childNodeStr = GetString(childNode.Blocks, rows, columns);

                            if (childNodeStr == endLocation)
                            {
                                return childNode.GameStapes + "左";
                            }

                            if (!keyValues.ContainsKey(childNodeStr))
                            {
                                childNode.GameStapes += "左";
                                openQueue.Enqueue(childNodeStr);
                                keyValues.Add(childNodeStr, childNode);
                            }
                        }
                        //空白块右移
                        if (point.Y < columns - 1)
                        {
                            var childNode = new Nodes()
                            {
                                GameStapes = node.GameStapes,
                                Blocks = new BlockInfo[rows, columns]
                            };
                            Array.Copy(node.Blocks, childNode.Blocks, node.Blocks.Length);
                            childNode.Blocks[point.X, point.Y] = node.Blocks[point.X, point.Y + 1];
                            childNode.Blocks[point.X, point.Y + 1] = node.Blocks[point.X, point.Y];
                            childNode.CurrentPoint = new Point(point.X, point.Y + 1);
                            var childNodeStr = GetString(childNode.Blocks, rows, columns);

                            if (childNodeStr == endLocation)
                            {
                                return childNode.GameStapes + "右";
                            }

                            if (!keyValues.ContainsKey(childNodeStr))
                            {
                                childNode.GameStapes += "右";
                                openQueue.Enqueue(childNodeStr);
                                keyValues.Add(childNodeStr, childNode);
                            }
                        }
                    }


                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// 双向广度优先搜索（DBFS）
        /// </summary>
        /// <param name="canvas"></param>
        /// <returns></returns>
        public async Task<string> DoubleBroadFirstSearch(Canvas canvas)
        {
            //最优路径
            var optimumPath = "";
            if (canvas==null)
            {
                return optimumPath;
            }
            List<Task<string>> tasks = new List<Task<string>>();

            var task1 = BroadFirstSearch(canvas.Rows, canvas.Columns, canvas.Blocks, canvas.EndLocationStr, canvas.CurrentLocation);
            tasks.Add(task1);
            var task2 = BroadFirstSearch(canvas.Rows, canvas.Columns, canvas.Blocks, canvas.EndLocationStr, canvas.CurrentLocation);
            tasks.Add(task2);
            var task = await Task.WhenAny(tasks).ConfigureAwait(false);



            return task.Result;
        }

        /// <summary>
        /// 根据位置数组获取位置排序字符串
        /// </summary>
        /// <param name="blocks">数组信息</param>
        /// <param name="rows">行数</param>
        /// <param name="columns">列数</param>
        /// <returns></returns>
        public string GetString(BlockInfo[,] blocks, int rows, int columns)
        {
            var str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)

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
