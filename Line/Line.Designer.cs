﻿namespace Line
{
    partial class Line
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Line";
            this.Opacity = 0.5D;
            this.Text = "Line";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Line_Activated);
            this.Deactivate += new System.EventHandler(this.Line_Deactivate);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Line_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Line_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Line_MouseMove);
            this.Resize += new System.EventHandler(this.Line_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

