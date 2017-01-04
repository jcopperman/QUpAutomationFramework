using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUp.Framework.Base;

namespace QUp.Framework.Base
{
    public class Base
    {
        public BasePage CurrentPage { get; set; }

        private IWebDriver _driver { get; set; }

        /// <summary>
        /// Using Generics to avoid boxing and unboxing of the Selenium Webdriver
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        /// <returns></returns>
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };

            PageFactory.InitElements(DriverContext.Driver, pageInstance);

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
