﻿using Silkweb.Mobile.Core.ViewModels;
using Silkweb.Mobile.Core.Interfaces;

namespace Silkweb.Mobile.Core.ViewModels
{
    public class SelectableViewModel : ViewModelBase, ISelectable
    {
        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set  {  SetProperty(ref _isSelected, value); }
        }
    }
}

