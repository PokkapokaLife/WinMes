namespace getmessagec
{
    partial class FomGetMessage
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInt1 = new System.Windows.Forms.TextBox();
            this.txtInt2 = new System.Windows.Forms.TextBox();
            this.butCls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(7, 29);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(231, 78);
            this.txtMessage.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(74, 12);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "受信メッセージ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "受信数値1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "受信数値２";
            // 
            // txtInt1
            // 
            this.txtInt1.Location = new System.Drawing.Point(70, 117);
            this.txtInt1.Name = "txtInt1";
            this.txtInt1.Size = new System.Drawing.Size(52, 19);
            this.txtInt1.TabIndex = 8;
            // 
            // txtInt2
            // 
            this.txtInt2.Location = new System.Drawing.Point(188, 115);
            this.txtInt2.Name = "txtInt2";
            this.txtInt2.Size = new System.Drawing.Size(52, 19);
            this.txtInt2.TabIndex = 9;
            // 
            // butCls
            // 
            this.butCls.Location = new System.Drawing.Point(174, 161);
            this.butCls.Name = "butCls";
            this.butCls.Size = new System.Drawing.Size(66, 23);
            this.butCls.TabIndex = 10;
            this.butCls.Text = "CLS";
            this.butCls.UseVisualStyleBackColor = true;
            this.butCls.Click += new System.EventHandler(this.butCls_Click);
            // 
            // FomGetMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 203);
            this.Controls.Add(this.butCls);
            this.Controls.Add(this.txtInt2);
            this.Controls.Add(this.txtInt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FomGetMessage";
            this.Text = "メッセージ受信";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInt1;
        private System.Windows.Forms.TextBox txtInt2;
        private System.Windows.Forms.Button butCls;
    }
}

