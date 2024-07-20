﻿using OldPhonePadUI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadUI.Implement
{
    public class ZeroOneButtonHandler : IButtonHandler
    {
        public void HandleButtonPress(OldPhonePad context, Button button)
        {
            string buttonText = button.Text.Substring(0, 1);
            context.CurrentText += buttonText;
            context.TextBoxDisplay.Text = context.CurrentText;
            context.CurrentIndex = 0;
            context.Timer.Stop();
        }
    }
}