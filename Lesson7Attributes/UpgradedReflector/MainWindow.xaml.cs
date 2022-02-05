using Microsoft.Win32;
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

namespace UpgradedReflector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler FileClick = null;
        public event EventHandler OpenClick = null;
        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            FileClick.Invoke(sender, e);
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenClick.Invoke(sender, e);
        }
    }
}
