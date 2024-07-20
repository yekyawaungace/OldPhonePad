using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadUI.Interface
{
    public interface IButtonHandler
    {
        void HandleButtonPress(OldPhonePad context, Button button);
    }
}
