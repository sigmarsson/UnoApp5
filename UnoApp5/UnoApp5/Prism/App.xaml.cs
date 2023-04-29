using Microsoft.UI.Xaml;

using System.IO;
using System;

namespace Weather.History
{
    public sealed partial class PrismApp
    {
        public PrismApp()
        {
#if WINDOWS
            UnhandledException += ExceptionHandler;
#endif
            InitializeComponent();
        }

        public void ExceptionHandler(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
        {
        }
    }
}