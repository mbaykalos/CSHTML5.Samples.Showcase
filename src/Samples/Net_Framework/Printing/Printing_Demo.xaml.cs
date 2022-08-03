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
    public partial class Printing_Demo : UserControl
    {
        public Printing_Demo()
        {
            this.InitializeComponent();
        }

        private void ButtonPrint_Click(object sender, RoutedEventArgs e)
        {
            var invoiceToPrint = new Invoice();
            CSHTML5.Native.Html.Printing.PrintManager.Print(invoiceToPrint);
        }

        private void ButtonViewSource_Click(object sender, RoutedEventArgs e)
        {
            ViewSourceButtonHelper.ViewSource(new List<ViewSourceButtonInfo>()
            {
                new ViewSourceButtonInfo()
                {
                    TabHeader = "Printing_Demo.xaml",
                    FilePathOnGitHub = "github/cshtml5/OpenSilver.Samples.Showcase/blob/master/src/Samples/Net_Framework/Printing/Printing_Demo.xaml"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "Printing_Demo.xaml.cs",
                    FilePathOnGitHub = "github/cshtml5/OpenSilver.Samples.Showcase/blob/master/src/Samples/Net_Framework/Printing/Printing_Demo.xaml.cs"
                },
                new ViewSourceButtonInfo()
                {
                    TabHeader = "Invoice.xaml",
                    FilePathOnGitHub = "github/cshtml5/OpenSilver.Samples.Showcase/blob/master/src/Samples/Net_Framework/Printing/Invoice.xaml"
                }
            });
        }

    }
}
