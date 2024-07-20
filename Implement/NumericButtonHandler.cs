using OldPhonePadUI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadUI.Implement
{
    public class NumericButtonHandler : IButtonHandler
    {
        public void HandleButtonPress(OldPhonePad context, Button button)
        {
            string buttonText = button.Text.Substring(0, 1);
            int number = int.Parse(buttonText);
            DateTime now = DateTime.Now;

            if ((now - context.LastKeyPress).TotalMilliseconds < context.TimerInterval &&
                context.CurrentText.Length > 0 &&
                context.CurrentText[context.CurrentText.Length - 1].ToString() == context.KeyMappings[number][context.CurrentIndex].ToString())
            {
                context.CurrentIndex = (context.CurrentIndex + 1) % context.KeyMappings[number].Length;
                context.CurrentText = context.CurrentText.Remove(context.CurrentText.Length - 1);
                context.CurrentText += context.KeyMappings[number][context.CurrentIndex];
            }
            else
            {
                context.CurrentIndex = 0;
                context.CurrentText += context.KeyMappings[number][context.CurrentIndex];
            }

            context.TextBoxDisplay.Text = context.CurrentText;
            context.LastKeyPress = now;
            context.Timer.Stop();
            context.Timer.Start();
        }
    }
}
