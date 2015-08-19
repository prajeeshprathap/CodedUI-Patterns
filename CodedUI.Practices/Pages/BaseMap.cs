using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUI.Practices.Pages
{
    public abstract class BaseMap
    {
        protected readonly BrowserWindow Window;
        internal Process BrowserProcess { get; private set; }

        protected BaseMap(BrowserWindow window)
        {
            Window = window;
            BrowserProcess = Window.Process;
        }

        internal void Navigate(string url)
        {
            Window.NavigateToUrl(new Uri(url));
        }
    }
}