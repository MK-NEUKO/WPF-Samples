using BindingDataTriggerMVVM.Command;
using BindingDataTriggerMVVM.Model;
using System;
using System.CodeDom;
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
        public ICommand ResetPointsCommand { get; }


        public MainViewModel()
        {
            PlayerX = new PlayerData { InAction = true, Name = "Michael", Points = 12 };
            PlayerO = new PlayerData { InAction = false, Name = "Jens", Points = 14 };

            ChangePlayerCommand = new ActionCommand(OnChangePlayerExecute, OnChangePlayerCanExecute);
            EnterNamePlayerXCommand = new ActionCommand(OnEnterNamePlayerXExecute, OnEnterNamePlayerXCanExecute);
            EnterNamePlayerOCommand = new ActionCommand(OnEnterNamePlayerOExecute, OnEnterNamePlayerOCanExecute);
            ResetPointsCommand = new ActionCommand(OnResetPointsExecute, OnResetPointsCanExecute);
        }

        private bool OnResetPointsCanExecute(object arg)
        {
            return true;
        }

        private void OnResetPointsExecute(object obj)
        {
            ResetPoints();
        }

        private bool OnEnterNamePlayerOCanExecute(object arg)
        {
            if (arg is TextBox value)
                return value.Text != "";
            else
                // Exeption zurückgeben
                return false;
        }

        private void OnEnterNamePlayerOExecute(object obj)
        {
            if (obj is TextBox value)
                PlayerO.Name = value.Text;
        }

        private bool OnEnterNamePlayerXCanExecute(object arg)
        {
            if (arg is TextBox value)
                return value.Text != "";
            else
                // Exeption zurückgeben
                return false;
        }

        private void OnEnterNamePlayerXExecute(object obj)
        {
            if (obj is TextBox value)
                PlayerX.Name = value.Text;
        }

        private bool OnChangePlayerCanExecute(object arg)
        {
            if (PlayerX.InAction || PlayerO.InAction)
                return true;
            else
                return false;
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

        private void ResetPoints()
        {
            PlayerX.Points = 0;
            PlayerO.Points = 0;
        }
    }
}
