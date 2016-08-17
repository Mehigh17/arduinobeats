namespace ArduinoBeats
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portsBox = new System.Windows.Forms.ComboBox();
            this.portswitchButton = new System.Windows.Forms.Button();
            this.soundLevelCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTextBox.Location = new System.Drawing.Point(12, 68);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.Size = new System.Drawing.Size(259, 177);
            this.consoleTextBox.TabIndex = 1;
            this.consoleTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Communication Port:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // portsBox
            // 
            this.portsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsBox.FormattingEnabled = true;
            this.portsBox.Location = new System.Drawing.Point(113, 14);
            this.portsBox.Name = "portsBox";
            this.portsBox.Size = new System.Drawing.Size(158, 21);
            this.portsBox.TabIndex = 3;
            // 
            // portswitchButton
            // 
            this.portswitchButton.Location = new System.Drawing.Point(11, 39);
            this.portswitchButton.Name = "portswitchButton";
            this.portswitchButton.Size = new System.Drawing.Size(104, 23);
            this.portswitchButton.TabIndex = 4;
            this.portswitchButton.Text = "Open Port";
            this.portswitchButton.UseVisualStyleBackColor = true;
            this.portswitchButton.Click += new System.EventHandler(this.portswitchButton_Click);
            // 
            // soundLevelCheckbox
            // 
            this.soundLevelCheckbox.AutoSize = true;
            this.soundLevelCheckbox.Location = new System.Drawing.Point(156, 43);
            this.soundLevelCheckbox.Name = "soundLevelCheckbox";
            this.soundLevelCheckbox.Size = new System.Drawing.Size(109, 17);
            this.soundLevelCheckbox.TabIndex = 5;
            this.soundLevelCheckbox.Text = "Print sound levels";
            this.soundLevelCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.soundLevelCheckbox);
            this.Controls.Add(this.portswitchButton);
            this.Controls.Add(this.portsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consoleTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 315);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Beats";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portsBox;
        private System.Windows.Forms.Button portswitchButton;
        private System.Windows.Forms.CheckBox soundLevelCheckbox;
    }
}

