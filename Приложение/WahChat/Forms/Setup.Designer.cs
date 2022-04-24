namespace WahChat
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.incomePortBox = new System.Windows.Forms.ComboBox();
            this.outcomePortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.box_speed1 = new System.Windows.Forms.ComboBox();
            this.box_speed2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incomePortBox
            // 
            this.incomePortBox.FormattingEnabled = true;
            resources.ApplyResources(this.incomePortBox, "incomePortBox");
            this.incomePortBox.Name = "incomePortBox";
            // 
            // outcomePortBox
            // 
            this.outcomePortBox.FormattingEnabled = true;
            resources.ApplyResources(this.outcomePortBox, "outcomePortBox");
            this.outcomePortBox.Name = "outcomePortBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Name = "label2";
            // 
            // connectButton
            // 
            resources.ApplyResources(this.connectButton, "connectButton");
            this.connectButton.Name = "connectButton";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // checkBox
            // 
            resources.ApplyResources(this.checkBox, "checkBox");
            this.checkBox.Name = "checkBox";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // box_speed1
            // 
            this.box_speed1.FormattingEnabled = true;
            resources.ApplyResources(this.box_speed1, "box_speed1");
            this.box_speed1.Name = "box_speed1";
            // 
            // box_speed2
            // 
            this.box_speed2.FormattingEnabled = true;
            resources.ApplyResources(this.box_speed2, "box_speed2");
            this.box_speed2.Name = "box_speed2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Setup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_speed2);
            this.Controls.Add(this.box_speed1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outcomePortBox);
            this.Controls.Add(this.incomePortBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox incomePortBox;
        private System.Windows.Forms.ComboBox outcomePortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ComboBox box_speed1;
        private System.Windows.Forms.ComboBox box_speed2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

