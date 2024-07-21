using OldPhonePadUI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadUI.Implement
{
    public class SpecialButtonHandler : IBtnChecker
    {
        public void CheckButtonPress(OldPhonePad context, Button button)
        {
            string buttonText = button.Text.Substring(0, 1);

            if (buttonText == "*")
            {
                if (context.CurrentText.Length > 0)
                {
                    context.CurrentText = context.CurrentText.Remove(context.CurrentText.Length - 1);
                    context.txtShow.Text = context.CurrentText;
                    context.CurrentIndex = 0;
                    context.Timer.Stop();
                }
            }
            else if (buttonText == "#")
            {
                context.CurrentText += "#";
                context.txtShow.Text = context.CurrentText;
                context.CurrentIndex = 0;
                context.Timer.Stop();
            }
        }
    }
}
