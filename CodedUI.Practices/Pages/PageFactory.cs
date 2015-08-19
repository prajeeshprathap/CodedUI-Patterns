using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUI.Practices.Pages
{
    public class PageFactory
    {
        public static TPage Create<TPage, TMap, TValidator>(string url, bool disposeOnPlayback = true)
            where TPage : BasePage<TMap, TValidator>
            where TMap : BaseMap
            where TValidator : BaseValidator<TMap>
        {
            return CreatePage<TPage, TMap, TValidator>(url, disposeOnPlayback);
        }

        public static TPage Create<TPage, TMap, TValidator>(string url, string browser, bool disposeOnPlayback = true)
            where TPage : BasePage<TMap, TValidator>
            where TMap : BaseMap
            where TValidator : BaseValidator<TMap>
        {
            BrowserWindow.CurrentBrowser = browser;
            return CreatePage<TPage, TMap, TValidator>(url, disposeOnPlayback);
        }
        public static TPage Create<TPage, TMap, TValidator>(Process browserProcess)
            where TPage : BasePage<TMap, TValidator>
            where TMap : BaseMap
            where TValidator : BaseValidator<TMap>
        {
            return CreatePage<TPage, TMap, TValidator>(browserProcess);
        }

        private static TPage CreatePage<TPage, TMap, TValidator>(string url, bool disposeOnPlayback = true) where TPage : BasePage<TMap, TValidator>
            where TMap : BaseMap where TValidator : BaseValidator<TMap>
        {
            var window = BrowserWindow.Launch(new Uri(url));
            window.Maximized = true;
            if (!disposeOnPlayback)
            {
                window.CloseOnPlaybackCleanup = false;
            }
            var map = Activator.CreateInstance(typeof (TMap), window) as TMap;
            var validator = Activator.CreateInstance<TValidator>();
            var page = Activator.CreateInstance<TPage>();
            validator.Map = map;
            page.Map = map;
            page.Validator = validator;
            return page;
        }

        private static TPage CreatePage<TPage, TMap, TValidator>(Process browserProcess)
            where TPage : BasePage<TMap, TValidator>
            where TMap : BaseMap
            where TValidator : BaseValidator<TMap>
        {
            var window = BrowserWindow.FromProcess(browserProcess);
            window.Maximized = true;
            var map = Activator.CreateInstance(typeof(TMap), window) as TMap;
            var validator = Activator.CreateInstance<TValidator>();
            var page = Activator.CreateInstance<TPage>();
            validator.Map = map;
            page.Map = map;
            page.Validator = validator;
            return page;
        }
    }
}