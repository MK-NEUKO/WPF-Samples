using BindingDataTriggerMVVM.Command;
using BindingDataTriggerMVVM.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

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

        public ICommand ChangePlayerCommand { get; }
        public ICommand EnterNamePlayerXCommand { get; }
        public ICommand EnterNamePlayerOCommand { get; }


        public MainViewModel()
        {
            PlayerX = new PlayerData { InAction = true, Name = "Michael", Points = 12 };
            PlayerO = new PlayerData { InAction = false, Name = "Jens", Points = 14 };

            ChangePlayerCommand = new ActionCommand(OnChangePlayerExecute, OnChangePlayerCanExecute);
            EnterNamePlayerXCommand = new ActionCommand(OnEnterNamePlayerXExecute, OnEnterNamePlayerXCanExecute);
        }

        private bool OnEnterNamePlayerXCanExecute(object arg)
        {
            return true;
        }

        private void OnEnterNamePlayerXExecute(object obj)
        {
            // Text aus textboxPlayerX beziehen
            // Text aus TextBox in PlayerX.Name speichern
        }

        private bool OnChangePlayerCanExecute(object arg)
        {
            // prüfen ob PlayerX.InAction oder PlayerO.InAction true
            return true;
        }

        private void OnChangePlayerExecute(object obj)
        {
            ChangePlayer();
        }

        private void ChangePlayer()
        {
            if (PlayerX.InAction)
            {
                PlayerX.InAction = false;
                PlayerO.InAction = true;
            }
            else
            {
                PlayerX.InAction = true;
                PlayerO.InAction = false;
            }
        }

        public void ResetPoints()
        {
            PlayerX.Points = 0;
            PlayerO.Points = 0;
        }
    }
}
