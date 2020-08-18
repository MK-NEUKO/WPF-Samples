using BindingDataTriggerMVVM.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BindingDataTriggerMVVM.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private PlayerData _playerX;

        public PlayerData PlayerX
        {
            get { return _playerX; }
            set { _playerX = value; }
        }

        public MainViewModel()
        {
            PlayerX = new PlayerData { InAction = true, Name = "Michael", Points = 12 };
        }
    }
}
