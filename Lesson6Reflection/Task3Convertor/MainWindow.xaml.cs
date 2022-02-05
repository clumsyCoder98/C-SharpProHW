
using System;
using System.Windows;

namespace Task3Convertor
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
        public event EventHandler convertAct = null;
        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            convertAct.Invoke(sender, e);
        }
    }
}