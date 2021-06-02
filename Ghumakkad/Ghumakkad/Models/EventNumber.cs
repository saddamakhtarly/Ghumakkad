using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ghumakkad.Models
{
  public  class EventNumber: BindableBase
    {
        private bool _framClicked;

        public bool FramClicked
        {
            get => _framClicked;
            set => SetProperty(ref _framClicked, value);
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TimeShow1 { get; set; }
        public string TimeShow2 { get; set; }
        public string LiveButton { get; set; }
        public string FramOne { get; set; }
        public string FramTwo { get; set; }


    }
}
