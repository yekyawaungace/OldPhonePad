using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadUI.Interface
{
    public interface IBtnChecker
    {
        void CheckButtonPress(OldPhonePad oldPhonePad, Button button);
    }
}
