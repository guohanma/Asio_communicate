namespace 音乐播放器
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
            this.b_open = new System.Windows.Forms.Button();
            this.b_up = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.b_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_open
            // 
            this.b_open.Location = new System.Drawing.Point(176, 51);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(75, 23);
            this.b_open.TabIndex = 0;
            this.b_open.Text = "b_open";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // b_up
            // 
            this.b_up.Location = new System.Drawing.Point(176, 93);
            this.b_up.Name = "b_up";
            this.b_up.Size = new System.Drawing.Size(75, 23);
            this.b_up.TabIndex = 1;
            this.b_up.Text = "b_up";
            this.b_up.UseVisualStyleBackColor = true;
            this.b_up.Click += new System.EventHandler(this.b_up_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // b_next
            // 
            this.b_next.Location = new System.Drawing.Point(176, 134);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(75, 23);
            this.b_next.TabIndex = 3;
            this.b_next.Text = "b_next";
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.b_up);
            this.Controls.Add(this.b_open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.Button b_up;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button b_next;
    }
}

