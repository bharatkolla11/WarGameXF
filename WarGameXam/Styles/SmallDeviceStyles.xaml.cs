using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace WarGameXam.Styles
{
    public partial class SmallDeviceStyles : ResourceDictionary
    {
        public static SmallDeviceStyles SharedInstance { get; } = new SmallDeviceStyles();
        public SmallDeviceStyles()
        {
            InitializeComponent();
        }
    }
}
