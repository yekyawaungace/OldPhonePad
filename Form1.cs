using System;
using System.Windows.Forms;

namespace OldPhonePadUI
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private string currentText = "";
        private int currentIndex = 0;
        private DateTime lastKeyPress;
        private readonly string[] keyMappings = new string[]
        {
            "", "&(", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"
        };

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1500; // 1.5 seconds
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            currentIndex = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text.Substring(0, 1); // Get the number part of the button text

            if (buttonText == "*")
            {
                if (currentText.Length > 0)
                {
                    currentText = currentText.Remove(currentText.Length - 1);
                    textBoxDisplay.Text = currentText;
                    currentIndex = 0; // Reset the current index
                    timer.Stop();
                }
            }
            else if (buttonText == "#")
            {
                // Define the behavior for the # button if needed
                currentText += "#";
                textBoxDisplay.Text = currentText;
                currentIndex = 0;
                timer.Stop();
            }
            else
            {
                int number;
                if (int.TryParse(buttonText, out number))
                {
                    if (number == 1 || number == 0)
                    {
                        // Append 1 or 0 directly to the text
                        currentText += buttonText;
                        textBoxDisplay.Text = currentText;
                        currentIndex = 0;
                        timer.Stop();
                    }
                    else if (number >= 2 && number <= 9)
                    {
                        DateTime now = DateTime.Now;

                        // If the same key is pressed within the timeout, cycle through the characters
                        if ((now - lastKeyPress).TotalMilliseconds < 1500 && currentText.Length > 0 && currentText[currentText.Length - 1].ToString() == keyMappings[number][currentIndex].ToString())
                        {
                            currentIndex = (currentIndex + 1) % keyMappings[number].Length;
                            currentText = currentText.Remove(currentText.Length - 1);
                            currentText += keyMappings[number][currentIndex];
                        }
                        else
                        {
                            currentIndex = 0;
                            currentText += keyMappings[number][currentIndex];
                        }

                        textBoxDisplay.Text = currentText;
                        lastKeyPress = now;
                        timer.Stop();
                        timer.Start();
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            currentText = "";
            currentIndex = 0;
            timer.Stop();
        }
    }
}
