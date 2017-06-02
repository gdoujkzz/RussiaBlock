namespace RussiaBlock {
    partial class frm_main {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.btn_star = new System.Windows.Forms.Button();
            this.pnl_game = new System.Windows.Forms.Panel();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_star
            // 
            this.btn_star.Location = new System.Drawing.Point(21, 12);
            this.btn_star.Name = "btn_star";
            this.btn_star.Size = new System.Drawing.Size(75, 23);
            this.btn_star.TabIndex = 0;
            this.btn_star.Text = "开始游戏";
            this.btn_star.UseVisualStyleBackColor = true;
            this.btn_star.Click += new System.EventHandler(this.btn_star_Click);
            // 
            // pnl_game
            // 
            this.pnl_game.Location = new System.Drawing.Point(1, 59);
            this.pnl_game.Name = "pnl_game";
            this.pnl_game.Size = new System.Drawing.Size(321, 401);
            this.pnl_game.TabIndex = 1;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(173, 12);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "暂停";
            this.btn_pause.UseVisualStyleBackColor = true;
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(254, 12);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(64, 23);
            this.btn_setting.TabIndex = 3;
            this.btn_setting.Text = "设置";
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "分数";
            // 
            // txt_score
            // 
            this.txt_score.Location = new System.Drawing.Point(281, 41);
            this.txt_score.Multiline = true;
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(34, 12);
            this.txt_score.TabIndex = 5;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 460);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.pnl_game);
            this.Controls.Add(this.btn_star);
            this.Name = "frm_main";
            this.Text = "俄罗斯方块";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_star;
        private System.Windows.Forms.Panel pnl_game;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_score;
    }
}

