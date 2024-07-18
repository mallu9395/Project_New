using ReservationSystem.ViewModel;
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

namespace ReservationSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // and our main window trying to bind current viewmodel that means data context for main window is gonna be
            // main viewmodel and it not good practice in mvvm because our viewmodel is directly accessing the viewmodel 
            //so instead this binding go to app.xaml.cs and create instance and set the datacontext
           // DataContext = new MainViewModel();
        }
    }
}
