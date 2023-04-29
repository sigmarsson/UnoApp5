using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Nostra13.Universalimageloader.Core;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnoApp5.Presentation;

using Weather.History;

namespace UnoApp5.Droid
{
    [global::Android.App.ApplicationAttribute(
        Label = "@string/ApplicationName",
        Icon = "@mipmap/iconapp",
        LargeHeap = true,
        HardwareAccelerated = true,
        Theme = "@style/AppTheme"
    )]
    public class Application : Microsoft.UI.Xaml.NativeApplication
    {

        public Application()
        {
            ConfigureUniversalImageLoader();
        }

        public Application(IntPtr javaReference, JniHandleOwnership transfer)
            : base(() => new PrismApp(), javaReference, transfer)
        {
            ConfigureUniversalImageLoader();
        }

        private static void ConfigureUniversalImageLoader()
        {
            // Create global configuration and initialize ImageLoader with this config
            ImageLoaderConfiguration config = new ImageLoaderConfiguration
                .Builder(Context)
                .Build();

            ImageLoader.Instance.Init(config);

            ImageSource.DefaultImageLoader = ImageLoader.Instance.LoadImageAsync;
        }

        protected override UIElement CreateShell()
        {
            var shell = Container.Resolve<Shell>();

#if WINDOWS
            shell.Loaded += (s, e) =>
            {
                MainXamlRoot = (s as UIElement).XamlRoot;
            };
#endif
            return shell;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new NotImplementedException();
        }
    }
}