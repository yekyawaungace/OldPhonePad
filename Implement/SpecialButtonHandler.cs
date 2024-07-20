using OldPhonePadUI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadUI.Implement
{
    public class SpecialButtonHandler : IButtonHandler
    {
        public void HandleButtonPress(OldPhonePad context, Button button)
        {
            string buttonText = button.Text.Substring(0, 1);

            if (buttonText == "*")
            {
                if (context.CurrentText.Length > 0)
                {
                    context.CurrentText = context.CurrentText.Remove(context.CurrentText.Length - 1);
                    context.TextBoxDisplay.Text = context.CurrentText;
                    context.CurrentIndex = 0;
                    context.Timer.Stop();
                }
            }
            else if (buttonText == "#")
            {
                context.CurrentText += "#";
                context.TextBoxDisplay.Text = context.CurrentText;
                context.CurrentIndex = 0;
                context.Timer.Stop();
            }
        }
    }
}
