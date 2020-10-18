namespace DrawCayleyTree
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
            this.button1 = new System.Windows.Forms.Button();
            this.depth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mainlength = new System.Windows.Forms.TextBox();
            this.rightRatio = new System.Windows.Forms.TextBox();
            this.leftRatio = new System.Windows.Forms.TextBox();
            this.rightAngle = new System.Windows.Forms.TextBox();
            this.leftAngle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "绘制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(659, 51);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(88, 21);
            this.depth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "主干长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "左分支长度比";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "左分支角度";
            // 
            // mainlength
            // 
            this.mainlength.Location = new System.Drawing.Point(659, 105);
            this.mainlength.Name = "mainlength";
            this.mainlength.Size = new System.Drawing.Size(87, 21);
            this.mainlength.TabIndex = 8;
            // 
            // rightRatio
            // 
            this.rightRatio.Location = new System.Drawing.Point(659, 159);
            this.rightRatio.Name = "rightRatio";
            this.rightRatio.Size = new System.Drawing.Size(87, 21);
            this.rightRatio.TabIndex = 9;
            // 
            // leftRatio
            // 
            this.leftRatio.Location = new System.Drawing.Point(659, 208);
            this.leftRatio.Name = "leftRatio";
            this.leftRatio.Size = new System.Drawing.Size(87, 21);
            this.leftRatio.TabIndex = 10;
            // 
            // rightAngle
            // 
            this.rightAngle.Location = new System.Drawing.Point(659, 250);
            this.rightAngle.Name = "rightAngle";
            this.rightAngle.Size = new System.Drawing.Size(87, 21);
            this.rightAngle.TabIndex = 11;
            // 
            // leftAngle
            // 
            this.leftAngle.Location = new System.Drawing.Point(659, 306);
            this.leftAngle.Name = "leftAngle";
            this.leftAngle.Size = new System.Drawing.Size(87, 21);
            this.leftAngle.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "颜色选择";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "红色",
            "绿色",
            "蓝色"});
            this.comboBox1.Location = new System.Drawing.Point(659, 361);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 20);
            this.comboBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.leftAngle);
            this.Controls.Add(this.rightAngle);
            this.Controls.Add(this.leftRatio);
            this.Controls.Add(this.rightRatio);
            this.Controls.Add(this.mainlength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mainlength;
        private System.Windows.Forms.TextBox rightRatio;
        private System.Windows.Forms.TextBox leftRatio;
        private System.Windows.Forms.TextBox rightAngle;
        private System.Windows.Forms.TextBox leftAngle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

