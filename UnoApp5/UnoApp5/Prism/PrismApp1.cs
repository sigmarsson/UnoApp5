#if WINDOWS
using Windows.ApplicationModel;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
#endif
using System;

#if ANDROID
using Android.Views;
#endif

namespace Weather.History
{
    public sealed partial class PrismApp
    {
        internal static Window Window;

#if WINDOWS
        internal static XamlRoot MainXamlRoot { get; private set; }
#endif

    }
}
