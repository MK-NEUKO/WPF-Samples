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

        private PlayerData playerO;

        public PlayerData PlayerO
        {
            get { return playerO; }
            set { playerO = value; }
        }


        public MainViewModel()
        {
            PlayerX = new PlayerData { InAction = true, Name = "Michael", Points = 12 };
            PlayerO = new PlayerData { InAction = false, Name = "Jens", Points = 14 };
        }
    }
}
