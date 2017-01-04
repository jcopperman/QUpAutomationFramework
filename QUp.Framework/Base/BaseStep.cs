using QUp.Framework.Config;
using QUp.Framework.Helpers;

namespace QUp.Framework.Base
{
    /// <summary>
    /// BaseStep class for Specflow step definition inheritance
    /// </summary>
    public abstract class BaseStep : Base
    {
        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.Environment);
            LogHelpers.Write("Opened the browser");
        }
    }
}
