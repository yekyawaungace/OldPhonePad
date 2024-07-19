namespace OldPhonePadUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button[] buttons;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttons = new System.Windows.Forms.Button[12];
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(92, 58); // Adjusted position to fit the image
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(100, 20); // Adjusted size to fit the image
            this.textBoxDisplay.TabIndex = 0;

            // 
            // buttons
            // 
            string[] buttonLabels = new string[]
            {
                "1 &(", "2 abc", "3 def",
                "4 ghi", "5 jkl", "6 mno",
                "7 pqrs", "8 tuv", "9 wxyz",
                "*", "0", "#"
            };
            int buttonWidth = 40;
            int buttonHeight = 40;

            for (int i = 0; i < 12; i++)
            {
                this.buttons[i] = new System.Windows.Forms.Button();
                this.buttons[i].Text = buttonLabels[i];
                this.buttons[i].Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                this.buttons[i].Click += new System.EventHandler(this.button_Click);
                this.buttons[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                int row = i / 3;
                int col = i % 3;
                this.buttons[i].Location = new System.Drawing.Point(72 + col * buttonWidth, 100 + row * buttonHeight); // Adjusted positions to fit the image
                this.Controls.Add(this.buttons[i]);
            }

            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(72, 280); // Adjusted position to fit the image
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 30); // Adjusted size to fit the image
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.Controls.Add(this.buttonClear);



            // 
            // pictureBox
            // 
           // this.pictureBox.Image = global::OldPhonePadUI.Properties.Resources.NokiaPhone; // Ensure the image is added as a resource
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(260, 300); // Adjust size to match the image
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Keypad Phone Input";
            this.ResumeLayout(false);
            this.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
        }
    }
}
