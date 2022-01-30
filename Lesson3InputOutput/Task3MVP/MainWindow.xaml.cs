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

namespace Task3MVP
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

        public event EventHandler searchAct = null;
        public event EventHandler readAct = null;
        public event EventHandler compressAct = null;

        private void src_btn_Click(object sender, RoutedEventArgs e)
        {
            searchAct.Invoke(sender,e);

        }

        private void read_btn_Click(object sender, RoutedEventArgs e)
        {
            readAct.Invoke(sender, e);
        }

        private void compr_btn_Click(object sender, RoutedEventArgs e)
        {
            compressAct.Invoke(sender, e);
        }
    }
}
