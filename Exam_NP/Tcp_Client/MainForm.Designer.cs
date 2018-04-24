namespace ClassLibrary
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.chat_richTextBox = new System.Windows.Forms.RichTextBox();
            this.sendText_button = new System.Windows.Forms.Button();
            this.message_textBox = new System.Windows.Forms.TextBox();
            this.sendImage_button = new System.Windows.Forms.Button();
            this.chat_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(61, 15);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(212, 24);
            this.login_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(289, 15);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 24);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Вход";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Enabled = false;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout_button.Location = new System.Drawing.Point(377, 15);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 24);
            this.logout_button.TabIndex = 3;
            this.logout_button.Text = "Выход";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // chat_richTextBox
            // 
            this.chat_richTextBox.Location = new System.Drawing.Point(15, 158);
            this.chat_richTextBox.Name = "chat_richTextBox";
            this.chat_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chat_richTextBox.Size = new System.Drawing.Size(437, 153);
            this.chat_richTextBox.TabIndex = 4;
            this.chat_richTextBox.Text = "";
            // 
            // sendText_button
            // 
            this.sendText_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendText_button.Location = new System.Drawing.Point(316, 52);
            this.sendText_button.Name = "sendText_button";
            this.sendText_button.Size = new System.Drawing.Size(136, 30);
            this.sendText_button.TabIndex = 5;
            this.sendText_button.Text = "Отправить";
            this.sendText_button.UseVisualStyleBackColor = true;
            this.sendText_button.Click += new System.EventHandler(this.SendText_button_Click);
            // 
            // message_textBox
            // 
            this.message_textBox.Location = new System.Drawing.Point(15, 52);
            this.message_textBox.Multiline = true;
            this.message_textBox.Name = "message_textBox";
            this.message_textBox.Size = new System.Drawing.Size(295, 68);
            this.message_textBox.TabIndex = 6;
            // 
            // sendImage_button
            // 
            this.sendImage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendImage_button.Location = new System.Drawing.Point(316, 90);
            this.sendImage_button.Name = "sendImage_button";
            this.sendImage_button.Size = new System.Drawing.Size(136, 30);
            this.sendImage_button.TabIndex = 7;
            this.sendImage_button.Text = "Отправить фото";
            this.sendImage_button.UseVisualStyleBackColor = true;
            this.sendImage_button.Click += new System.EventHandler(this.SendImage_button_Click);
            // 
            // chat_label
            // 
            this.chat_label.AutoSize = true;
            this.chat_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat_label.Location = new System.Drawing.Point(12, 138);
            this.chat_label.Name = "chat_label";
            this.chat_label.Size = new System.Drawing.Size(37, 17);
            this.chat_label.TabIndex = 8;
            this.chat_label.Text = "Chat";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 327);
            this.Controls.Add(this.chat_label);
            this.Controls.Add(this.sendImage_button);
            this.Controls.Add(this.message_textBox);
            this.Controls.Add(this.sendText_button);
            this.Controls.Add(this.chat_richTextBox);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_textBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.RichTextBox chat_richTextBox;
        private System.Windows.Forms.Button sendText_button;
        private System.Windows.Forms.TextBox message_textBox;
        private System.Windows.Forms.Button sendImage_button;
        private System.Windows.Forms.Label chat_label;
    }
}

