using OldPhonePadUI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadUI.Implement
{
    public static class ButtonHandlerFactory
    {
        public static IButtonHandler GetButtonHandler(string buttonText)
        {
            return buttonText switch
            {
                "*" => new SpecialButtonHandler(),
                "#" => new SpecialButtonHandler(),
                "0" => new ZeroOneButtonHandler(),
                "1" => new ZeroOneButtonHandler(),
                _ => new NumericButtonHandler(),
            };
        }
    }
}
