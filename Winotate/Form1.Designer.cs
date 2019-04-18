namespace Winotate
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
            this.comRotate = new System.Windows.Forms.ComboBox();
            this.btnRotate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comRotate
            // 
            this.comRotate.FormattingEnabled = true;
            this.comRotate.Location = new System.Drawing.Point(45, 49);
            this.comRotate.Name = "comRotate";
            this.comRotate.Size = new System.Drawing.Size(121, 23);
            this.comRotate.TabIndex = 0;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(204, 48);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 1;
            this.btnRotate.Text = "旋转";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 142);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.comRotate);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comRotate;
        private System.Windows.Forms.Button btnRotate;
    }
}

