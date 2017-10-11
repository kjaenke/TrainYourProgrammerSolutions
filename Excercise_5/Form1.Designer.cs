namespace Excercise_5
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
            this.leftListBox = new System.Windows.Forms.ListBox();
            this.rightListBox = new System.Windows.Forms.ListBox();
            this.toRightButton = new System.Windows.Forms.Button();
            this.toLeftButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftListBox
            // 
            this.leftListBox.FormattingEnabled = true;
            this.leftListBox.Location = new System.Drawing.Point(12, 12);
            this.leftListBox.Name = "leftListBox";
            this.leftListBox.Size = new System.Drawing.Size(201, 225);
            this.leftListBox.TabIndex = 1;
            // 
            // rightListBox
            // 
            this.rightListBox.FormattingEnabled = true;
            this.rightListBox.Location = new System.Drawing.Point(341, 12);
            this.rightListBox.Name = "rightListBox";
            this.rightListBox.Size = new System.Drawing.Size(206, 225);
            this.rightListBox.TabIndex = 2;
            // 
            // toRightButton
            // 
            this.toRightButton.Location = new System.Drawing.Point(239, 100);
            this.toRightButton.Name = "toRightButton";
            this.toRightButton.Size = new System.Drawing.Size(75, 23);
            this.toRightButton.TabIndex = 3;
            this.toRightButton.Text = ">>";
            this.toRightButton.UseVisualStyleBackColor = true;
            this.toRightButton.Click += new System.EventHandler(this.toRightButton_Click);
            // 
            // toLeftButton
            // 
            this.toLeftButton.Location = new System.Drawing.Point(239, 129);
            this.toLeftButton.Name = "toLeftButton";
            this.toLeftButton.Size = new System.Drawing.Size(75, 23);
            this.toLeftButton.TabIndex = 4;
            this.toLeftButton.Text = "<<";
            this.toLeftButton.UseVisualStyleBackColor = true;
            this.toLeftButton.Click += new System.EventHandler(this.toLeftButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 248);
            this.Controls.Add(this.toLeftButton);
            this.Controls.Add(this.toRightButton);
            this.Controls.Add(this.rightListBox);
            this.Controls.Add(this.leftListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox leftListBox;
        private System.Windows.Forms.ListBox rightListBox;
        private System.Windows.Forms.Button toRightButton;
        private System.Windows.Forms.Button toLeftButton;
    }
}

