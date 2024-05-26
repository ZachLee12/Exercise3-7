namespace Exercise3_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NorthButton = new Button();
            WestButton = new Button();
            SouthButton = new Button();
            EastButton = new Button();
            SuspendLayout();
            // 
            // NorthButton
            // 
            NorthButton.Location = new Point(330, 74);
            NorthButton.Name = "NorthButton";
            NorthButton.Size = new Size(100, 71);
            NorthButton.TabIndex = 0;
            NorthButton.Text = "N";
            NorthButton.UseVisualStyleBackColor = true;
            NorthButton.Click += NorthButton_Click;
            // 
            // WestButton
            // 
            WestButton.Location = new Point(168, 198);
            WestButton.Name = "WestButton";
            WestButton.Size = new Size(100, 71);
            WestButton.TabIndex = 1;
            WestButton.Text = "W";
            WestButton.UseVisualStyleBackColor = true;
            WestButton.Click += WestButton_Click;
            // 
            // SouthButton
            // 
            SouthButton.Location = new Point(339, 319);
            SouthButton.Name = "SouthButton";
            SouthButton.Size = new Size(100, 71);
            SouthButton.TabIndex = 2;
            SouthButton.Text = "S";
            SouthButton.UseVisualStyleBackColor = true;
            SouthButton.Click += SouthButton_Click;
            // 
            // EastButton
            // 
            EastButton.Location = new Point(489, 198);
            EastButton.Name = "EastButton";
            EastButton.Size = new Size(100, 71);
            EastButton.TabIndex = 3;
            EastButton.Text = "E";
            EastButton.UseVisualStyleBackColor = true;
            EastButton.Click += EastButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EastButton);
            Controls.Add(SouthButton);
            Controls.Add(WestButton);
            Controls.Add(NorthButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button NorthButton;
        private Button WestButton;
        private Button SouthButton;
        private Button EastButton;
    }
}
