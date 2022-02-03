using System;
using FreshMvvm;
using WarGameXam.Styles;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarGameXam
{
    public partial class App : Application
    {
        const int smallWightResolution = 768;
        const int smallHeightResolution = 1280;

        public App()
        {
            InitializeComponent();
            LoadStyles();


            var mainPage = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            MainPage = new FreshNavigationContainer(mainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        void LoadStyles()
        {
            if (IsASmallDevice())
            {
                dictionary.MergedDictionaries.Add(SmallDeviceStyles.SharedInstance);
            }
            else
            {
                dictionary.MergedDictionaries.Add(GeneralDeviceStyles.SharedInstance);
            }
        }

        public static bool IsASmallDevice()
        {
            // Get Metrics
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            // Width (in pixels)
            var width = mainDisplayInfo.Width;

            // Height (in pixels)
            var height = mainDisplayInfo.Height;
            return (width <= smallWightResolution && height <= smallHeightResolution);
        }
    }
}
