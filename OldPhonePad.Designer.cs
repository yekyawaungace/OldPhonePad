namespace OldPhonePadUI
{
    partial class OldPhonePad
    {
        private System.ComponentModel.IContainer components = null;
        private Button[] btngroup;
        private Button btnClear;

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
            this.txtShow = new TextBox();
            this.btngroup = new Button[12];
            this.btnClear = new Button();
            this.SuspendLayout();

            // 
            // TextBoxDisplay
            // 
            this.txtShow.Location = new System.Drawing.Point(50, 20);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(280, 30);
            this.txtShow.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular);
            this.txtShow.TabIndex = 0;
            this.txtShow.TextAlign = HorizontalAlignment.Center;

            // 
            // buttons
            // 
            string[] buttonLabels = new string[]
            {
                "1", "2 abc", "3 def",
                "4 ghi", "5 jkl", "6 mno",
                "7 pqrs", "8 tuv", "9 wxyz",
                "*", "0", "#"
            };
            int buttonWidth = 80;
            int buttonHeight = 60;
            int spacing = 10;

            for (int i = 0; i < 12; i++)
            {
                this.btngroup[i] = new Button();
                this.btngroup[i].Text = buttonLabels[i];
                this.btngroup[i].Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                this.btngroup[i].Click += new System.EventHandler(this.btn_Click);
                this.btngroup[i].Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
                this.btngroup[i].BackColor = Color.LightGray;
                this.btngroup[i].FlatStyle = FlatStyle.Flat;
                this.btngroup[i].FlatAppearance.BorderSize = 2;
                this.btngroup[i].FlatAppearance.BorderColor = Color.DarkGray;

                int row = i / 3;
                int col = i % 3;
                this.btngroup[i].Location = new System.Drawing.Point(50 + col * (buttonWidth + spacing), 70 + row * (buttonHeight + spacing));
                this.Controls.Add(this.btngroup[i]);
            }

            // 
            // buttonClear
            // 
            this.btnClear.Location = new System.Drawing.Point(50, 350); // Moved lower
            this.btnClear.Name = "butClear";
            this.btnClear.Size = new System.Drawing.Size(260, 50);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.BackColor = Color.Salmon;
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.BorderColor = Color.DarkGray;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.Controls.Add(this.btnClear);

            // 
            // OldPhonePad
            // 
            this.ClientSize = new System.Drawing.Size(384, 461); // Adjust form size if needed
            this.Controls.Add(this.txtShow);
            this.Name = "OldPhonePad";
            this.Text = "Keypad Phone";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
