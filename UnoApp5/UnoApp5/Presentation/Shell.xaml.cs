﻿using Uno.Toolkit.UI;

namespace UnoApp5.Presentation
{
    public sealed partial class Shell : UserControl, IContentControlProvider
    {
        public Shell()
        {
            this.InitializeComponent();
        }

        public ContentControl ContentControl => Splash;
    }
}