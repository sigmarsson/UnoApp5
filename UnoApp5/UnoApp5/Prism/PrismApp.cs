using System;

using Microsoft.UI.Xaml;


#if WINDOWS
using System.Diagnostics;


using Windows.ApplicationModel;
#endif

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.DryIoc;
using Uno.Extensions.Hosting;

namespace Weather.History
{
    public sealed partial class PrismApp : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterTypes(containerRegistry);
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

    }
}
