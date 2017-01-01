﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace GoogleMaps.Bindings.ViewModels
{
    public class MapLongClickedPageViewModel : ViewModelBase
    {
        private int _clickedCount;

        public int ClickedCount
        {
            get { return _clickedCount; }
            set { SetProperty(ref _clickedCount, value); }
        }

        public Command<MapLongClickedEventArgs> MapLongClickedCommand => new Command<MapLongClickedEventArgs>(
            args =>
            {
                ClickedCount++;
            });

    }
}