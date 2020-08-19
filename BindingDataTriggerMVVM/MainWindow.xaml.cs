using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BindingDataTriggerMVVM.ViewModel;

namespace BindingDataTriggerMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangePlayer_Click(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)DataContext).ChangePlayer();
        }

        private void ResetPoints_Click(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)DataContext).ResetPoints();
        }

        private void EnterNamePlayerX(object sender, RoutedEventArgs e)
        {
            if (textBoxPlayerX.Text != null)
            {
                ((MainViewModel)DataContext).PlayerX.Name = textBoxPlayerX.Text;
            }
        }

        private void EnterNamePlayerO(object sender, RoutedEventArgs e)
        {
            if (textBoxPlayerO.Text != null)
            {
                ((MainViewModel)DataContext).PlayerO.Name = textBoxPlayerO.Text;
            }
        }
    }
}
