using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JigsawPuzzle
{
    /// <summary>
    /// 拼图图块信息
    /// </summary>
    public class BlockInfo
    {
        /// <summary>
        /// 图块位置
        /// </summary>
        public int Location { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public Image Image { get; set; }
    }
}
