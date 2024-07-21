using OldPhonePadUI.Implement;
using OldPhonePadUI.Interface;
using System;
using System.Windows.Forms;

namespace OldPhonePadUI
{
    public partial class OldPhonePad : Form
    {
        public System.Windows.Forms.Timer Timer { get; private set; }
        public string CurrentText { get; set; } = "";
        public int CurrentIndex { get; set; } = 0;
        public DateTime LastKeyPress { get; set; }
        public int TimerInterval { get; private set; } = 60000;
        public TextBox txtShow { get; private set; }

        public readonly string[] KeyMappings = new string[]
        {
            "", "&(", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"
        };

        public OldPhonePad()
        {
            InitializeComponent();
            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = TimerInterval;
            Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            CurrentIndex = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text.Substring(0, 1);

            //Factory Desgin Pattern
            IBtnChecker btnchecker = ButtonHandlerFactory.GetButtonChecker(buttonText);
            btnchecker.CheckButtonPress(this, button);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShow.Clear();
            CurrentText = "";
            CurrentIndex = 0;
            Timer.Stop();
        }
    }
}
