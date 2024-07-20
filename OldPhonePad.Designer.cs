namespace OldPhonePadUI
{
    partial class OldPhonePad
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button[] buttons;
        private System.Windows.Forms.Button buttonClear;

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
            this.SuspendLayout();

            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(260, 20);
            this.textBoxDisplay.TabIndex = 0;

            // 
            // buttons
            // 
            for (int i = 0; i < 12; i++)
            {
                this.buttons[i] = new System.Windows.Forms.Button();
                this.buttons[i].Size = new System.Drawing.Size(50, 50);
                this.buttons[i].Click += new System.EventHandler(this.button_Click);
                this.Controls.Add(this.buttons[i]);
            }

            this.buttons[0].Text = "1";
            this.buttons[1].Text = "2 ABC";
            this.buttons[2].Text = "3 DEF";
            this.buttons[3].Text = "4 GHI";
            this.buttons[4].Text = "5 JKL";
            this.buttons[5].Text = "6 MNO";
            this.buttons[6].Text = "7 PQRS";
            this.buttons[7].Text = "8 TUV";
            this.buttons[8].Text = "9 WXYZ";
            this.buttons[9].Text = "*";
            this.buttons[10].Text = "0";
            this.buttons[11].Text = "#";

            // Positioning buttons
            for (int i = 0; i < 12; i++)
            {
                int row = i / 3;
                int col = i % 3;
                this.buttons[i].Location = new System.Drawing.Point(12 + col * 60, 40 + row * 60);
            }

            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 220);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(260, 30);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);

            // 
            // OldPhonePad
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonClear);
            this.Name = "OldPhonePad";
            this.Text = "Old Phone Pad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
