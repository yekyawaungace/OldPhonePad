using OldPhonePadUI.Interface;


namespace OldPhonePadUI.Implement
{
    public class ZeroOneButtonHandler : IBtnChecker
    {
        #region CheckButtonPress
        public void CheckButtonPress(OldPhonePad context, Button button)
        {
            string buttonText = button.Text.Substring(0, 1);
            context.CurrentText += buttonText;
            context.txtShow.Text = context.CurrentText;
            context.CurrentIndex = 0;
            context.Timer.Stop();
        }
        #endregion

    }
}
