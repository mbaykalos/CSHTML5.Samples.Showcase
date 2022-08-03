﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
#if SLMIGRATION
using System.Windows;
using System.Windows.Controls;
#else
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#endif

namespace OpenSilver.Samples.Showcase
{
    public partial class HtmlPresenter_Demo : UserControl
    {
        public HtmlPresenter_Demo()
        {
            this.InitializeComponent();
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "HtmlPresenter_Demo.xaml",
                    FilePathOnGitHub = "github/cshtml5/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/HtmlPresenter/HtmlPresenter_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "HtmlPresenter_Demo.xaml.cs",
                    FilePathOnGitHub = "github/cshtml5/OpenSilver.Samples.Showcase/blob/master/src/Samples/XAML_Controls/HtmlPresenter/HtmlPresenter_Demo.xaml.cs"
                }
            });
        }

    }
}
