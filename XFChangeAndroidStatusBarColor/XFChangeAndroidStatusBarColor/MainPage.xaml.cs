﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFChangeAndroidStatusBarColor.Services;

namespace XFChangeAndroidStatusBarColor
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var scm = Xamarin.Forms.DependencyService.Get<IStatusBarColorManager>();

            scm.SetColor(Color.Red, false);
        }
    }
}
