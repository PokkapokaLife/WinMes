namespace sendmessagec
{
    partial class FomSendMessage
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
            this.butSend = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.txtInt1 = new System.Windows.Forms.TextBox();
            this.lblMessage3 = new System.Windows.Forms.Label();
            this.txtInt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(191, 201);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(53, 23);
            this.butSend.TabIndex = 0;
            this.butSend.Text = "送信";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(183, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "メッセージを送るアプリケーションの名前";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 19);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "メッセージ受信";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(17, 75);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(223, 79);
            this.txtMessage.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(19, 60);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(71, 12);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "送るメッセージ";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(19, 171);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(56, 12);
            this.lblMessage2.TabIndex = 5;
            this.lblMessage2.Text = "送る数値1";
            // 
            // txtInt1
            // 
            this.txtInt1.Location = new System.Drawing.Point(71, 167);
            this.txtInt1.Name = "txtInt1";
            this.txtInt1.Size = new System.Drawing.Size(50, 19);
            this.txtInt1.TabIndex = 6;
            // 
            // lblMessage3
            // 
            this.lblMessage3.AutoSize = true;
            this.lblMessage3.Location = new System.Drawing.Point(130, 174);
            this.lblMessage3.Name = "lblMessage3";
            this.lblMessage3.Size = new System.Drawing.Size(56, 12);
            this.lblMessage3.TabIndex = 7;
            this.lblMessage3.Text = "送る数値2";
            // 
            // txtInt2
            // 
            this.txtInt2.Location = new System.Drawing.Point(189, 169);
            this.txtInt2.Name = "txtInt2";
            this.txtInt2.Size = new System.Drawing.Size(50, 19);
            this.txtInt2.TabIndex = 8;
            // 
            // FomSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 229);
            this.Controls.Add(this.txtInt2);
            this.Controls.Add(this.lblMessage3);
            this.Controls.Add(this.txtInt1);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.butSend);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FomSendMessage";
            this.Text = "メッセージ送信";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.TextBox txtInt1;
        private System.Windows.Forms.Label lblMessage3;
        private System.Windows.Forms.TextBox txtInt2;
    }
}

