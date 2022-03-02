namespace WahChat
{
    partial class Chat
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.chatInbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(11, 9);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(51, 22);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = " Имя";
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageBox.Location = new System.Drawing.Point(3, 296);
            this.messageBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(313, 28);
            this.messageBox.TabIndex = 11;
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(320, 299);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(140, 25);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(320, 11);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(140, 25);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Отключиться";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // chatBox
            // 
            this.chatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 17;
            this.chatBox.Location = new System.Drawing.Point(199, 72);
            this.chatBox.Margin = new System.Windows.Forms.Padding(2);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(261, 191);
            this.chatBox.TabIndex = 14;
            // 
            // chatInbox
            // 
            this.chatInbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chatInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatInbox.FormattingEnabled = true;
            this.chatInbox.ItemHeight = 17;
            this.chatInbox.Location = new System.Drawing.Point(3, 72);
            this.chatInbox.Margin = new System.Windows.Forms.Padding(2);
            this.chatInbox.Name = "chatInbox";
            this.chatInbox.Size = new System.Drawing.Size(184, 191);
            this.chatInbox.TabIndex = 15;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 335);
            this.Controls.Add(this.chatInbox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chat";
            this.Text = "Чат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.ListBox chatInbox;
    }
}