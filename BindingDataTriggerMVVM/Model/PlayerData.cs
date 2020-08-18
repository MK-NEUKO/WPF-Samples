using BindingDataTriggerMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BindingDataTriggerMVVM.Model
{
    class PlayerData : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private bool _inAction;

        public bool InAction
        {
            get { return _inAction; }
            set { SetProperty(ref _inAction, value); }
        }

        private int _points;

        public int Points
        {
            get { return _points; }
            set { SetProperty(ref _points, value); }
        }

    }
}
