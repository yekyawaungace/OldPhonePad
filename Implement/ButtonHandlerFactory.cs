using OldPhonePadUI.Interface;

namespace OldPhonePadUI.Implement
{
    public static class ButtonHandlerFactory
    {
        #region GetButtonChecker
        public static IBtnChecker GetButtonChecker(string buttonText)
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
        #endregion

    }
}
