using OldPhonePadUI.Interface;


namespace OldPhonePadUI.Implement
{
    public class SpecialButtonHandler : IBtnChecker
    {
        public void CheckButtonPress(OldPhonePad context, Button button)
        {
            #region CheckButtonPress
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
            #endregion

        }
    }
}
