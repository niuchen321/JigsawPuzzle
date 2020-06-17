namespace JigsawPuzzle
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimple = new System.Windows.Forms.Button();
            this.btnOrdinary = new System.Windows.Forms.Button();
            this.btnDifficulty = new System.Windows.Forms.Button();
            this.btnNightmare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picBoxMax = new System.Windows.Forms.PictureBox();
            this.picBoxThumb = new System.Windows.Forms.PictureBox();
            this.picBoxCenter = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(683, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "移动步数：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(683, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "最好成绩：";
            // 
            // btnSimple
            // 
            this.btnSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimple.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimple.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSimple.ForeColor = System.Drawing.Color.White;
            this.btnSimple.Location = new System.Drawing.Point(687, 352);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(167, 40);
            this.btnSimple.TabIndex = 3;
            this.btnSimple.Text = "简单";
            this.btnSimple.UseVisualStyleBackColor = false;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // btnOrdinary
            // 
            this.btnOrdinary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdinary.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOrdinary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdinary.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrdinary.ForeColor = System.Drawing.Color.White;
            this.btnOrdinary.Location = new System.Drawing.Point(687, 417);
            this.btnOrdinary.Name = "btnOrdinary";
            this.btnOrdinary.Size = new System.Drawing.Size(167, 40);
            this.btnOrdinary.TabIndex = 3;
            this.btnOrdinary.Text = "普通";
            this.btnOrdinary.UseVisualStyleBackColor = false;
            this.btnOrdinary.Click += new System.EventHandler(this.btnOrdinary_Click);
            // 
            // btnDifficulty
            // 
            this.btnDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDifficulty.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDifficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDifficulty.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDifficulty.ForeColor = System.Drawing.Color.White;
            this.btnDifficulty.Location = new System.Drawing.Point(687, 482);
            this.btnDifficulty.Name = "btnDifficulty";
            this.btnDifficulty.Size = new System.Drawing.Size(167, 40);
            this.btnDifficulty.TabIndex = 3;
            this.btnDifficulty.Text = "困难";
            this.btnDifficulty.UseVisualStyleBackColor = false;
            this.btnDifficulty.Click += new System.EventHandler(this.btnDifficulty_Click);
            // 
            // btnNightmare
            // 
            this.btnNightmare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNightmare.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNightmare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNightmare.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNightmare.ForeColor = System.Drawing.Color.White;
            this.btnNightmare.Location = new System.Drawing.Point(687, 547);
            this.btnNightmare.Name = "btnNightmare";
            this.btnNightmare.Size = new System.Drawing.Size(167, 40);
            this.btnNightmare.TabIndex = 3;
            this.btnNightmare.Text = "噩梦";
            this.btnNightmare.UseVisualStyleBackColor = false;
            this.btnNightmare.Click += new System.EventHandler(this.btnNightmare_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(787, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(793, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(44, 21);
            this.tsmFile.Text = "文件";
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(100, 22);
            this.tsmOpen.Text = "打开";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picBoxMax
            // 
            this.picBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMax.BackColor = System.Drawing.Color.White;
            this.picBoxMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxMax.Location = new System.Drawing.Point(74, 45);
            this.picBoxMax.Name = "picBoxMax";
            this.picBoxMax.Padding = new System.Windows.Forms.Padding(5);
            this.picBoxMax.Size = new System.Drawing.Size(654, 666);
            this.picBoxMax.TabIndex = 6;
            this.picBoxMax.TabStop = false;
            this.picBoxMax.Visible = false;
            this.picBoxMax.Click += new System.EventHandler(this.picBoxMax_Click);
            // 
            // picBoxThumb
            // 
            this.picBoxThumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxThumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxThumb.Location = new System.Drawing.Point(687, 32);
            this.picBoxThumb.Name = "picBoxThumb";
            this.picBoxThumb.Size = new System.Drawing.Size(167, 98);
            this.picBoxThumb.TabIndex = 2;
            this.picBoxThumb.TabStop = false;
            this.picBoxThumb.Click += new System.EventHandler(this.picBoxThumb_Click);
            // 
            // picBoxCenter
            // 
            this.picBoxCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxCenter.BackColor = System.Drawing.Color.White;
            this.picBoxCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxCenter.Location = new System.Drawing.Point(0, 25);
            this.picBoxCenter.Name = "picBoxCenter";
            this.picBoxCenter.Size = new System.Drawing.Size(654, 757);
            this.picBoxCenter.TabIndex = 0;
            this.picBoxCenter.TabStop = false;
            this.picBoxCenter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoxCenter_MouseClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(666, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 122);
            this.label5.TabIndex = 7;
            // 
            // btnHint
            // 
            this.btnHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHint.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHint.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHint.ForeColor = System.Drawing.Color.White;
            this.btnHint.Location = new System.Drawing.Point(687, 287);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(167, 40);
            this.btnHint.TabIndex = 3;
            this.btnHint.Text = "提示";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(874, 774);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBoxMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNightmare);
            this.Controls.Add(this.btnDifficulty);
            this.Controls.Add(this.btnOrdinary);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.picBoxThumb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxCenter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 675);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "拼图游戏";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxThumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btnOrdinary;
        private System.Windows.Forms.Button btnDifficulty;
        private System.Windows.Forms.Button btnNightmare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picBoxMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHint;
    }
}

