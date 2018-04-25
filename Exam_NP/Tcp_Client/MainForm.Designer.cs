namespace Tcp_Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sendImage_btn = new System.Windows.Forms.Button();
            this.sendText_btn = new System.Windows.Forms.Button();
            this.chat_textBox = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.msg_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.msg_textBox);
            this.splitContainer1.Panel1.Controls.Add(this.sendImage_btn);
            this.splitContainer1.Panel1.Controls.Add(this.sendText_btn);
            this.splitContainer1.Panel1.Controls.Add(this.chat_textBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(501, 315);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 1;
            // 
            // sendImage_btn
            // 
            this.sendImage_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendImage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendImage_btn.Location = new System.Drawing.Point(126, 93);
            this.sendImage_btn.Name = "sendImage_btn";
            this.sendImage_btn.Size = new System.Drawing.Size(102, 61);
            this.sendImage_btn.TabIndex = 2;
            this.sendImage_btn.Text = "Отправить фото";
            this.sendImage_btn.UseVisualStyleBackColor = true;
            // 
            // sendText_btn
            // 
            this.sendText_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendText_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendText_btn.Location = new System.Drawing.Point(12, 93);
            this.sendText_btn.Name = "sendText_btn";
            this.sendText_btn.Size = new System.Drawing.Size(102, 61);
            this.sendText_btn.TabIndex = 1;
            this.sendText_btn.Text = "Отправить";
            this.sendText_btn.UseVisualStyleBackColor = true;
            this.sendText_btn.Click += new System.EventHandler(this.SendText_btn_Click);
            // 
            // chat_textBox
            // 
            this.chat_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat_textBox.Location = new System.Drawing.Point(12, 175);
            this.chat_textBox.Multiline = true;
            this.chat_textBox.Name = "chat_textBox";
            this.chat_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chat_textBox.Size = new System.Drawing.Size(216, 140);
            this.chat_textBox.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(254, 315);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // msg_textBox
            // 
            this.msg_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msg_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msg_textBox.Location = new System.Drawing.Point(12, 12);
            this.msg_textBox.Multiline = true;
            this.msg_textBox.Name = "msg_textBox";
            this.msg_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msg_textBox.Size = new System.Drawing.Size(216, 62);
            this.msg_textBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 315);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(517, 354);
            this.MinimumSize = new System.Drawing.Size(517, 354);
            this.Name = "MainForm";
            this.Text = "Chat";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button sendImage_btn;
        private System.Windows.Forms.Button sendText_btn;
        private System.Windows.Forms.TextBox chat_textBox;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox msg_textBox;
    }
}