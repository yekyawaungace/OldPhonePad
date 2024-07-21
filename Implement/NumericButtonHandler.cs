using OldPhonePadUI.Interface;


namespace OldPhonePadUI.Implement
{
    public class NumericButtonHandler : IBtnChecker
    {
        #region CheckButtonPress
        public void CheckButtonPress(OldPhonePad context, Button button)
        {
            string buttonText = button.Text.Substring(0, 1);
            int number = int.Parse(buttonText);
            DateTime now = DateTime.Now;

            if ((now - context.LastKeyPress).TotalMilliseconds < context.TimerInterval &&
                context.CurrentText.Length > 0 &&
                context.CurrentText[context.CurrentText.Length - 1].ToString() == context.KeyMappings[number][context.CurrentIndex].ToString())
            {
                //want to know first time, second time or thrid time to click the button
                context.CurrentIndex = (context.CurrentIndex + 1) % context.KeyMappings[number].Length;
                context.CurrentText = context.CurrentText.Remove(context.CurrentText.Length - 1);
                context.CurrentText += context.KeyMappings[number][context.CurrentIndex];
            }
            else
            {
                context.CurrentIndex = 0;
                context.CurrentText += context.KeyMappings[number][context.CurrentIndex];
            }

            context.txtShow.Text = context.CurrentText;
            context.LastKeyPress = now;
            context.Timer.Stop();
            context.Timer.Start();
        }
        #endregion

    }
}
