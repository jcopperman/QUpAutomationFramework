using QUp.Framework.Base;
using TechTalk.SpecFlow;

namespace TestProject
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.FireFox)
        {
            InitializeSettings();
            //NaviateSite();
        }

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }
    }
}
