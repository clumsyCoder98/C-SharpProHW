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
using System.Windows.Shapes;

namespace Task3MVP
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CompressWindow : Window
    {
        public CompressWindow()
        {
            InitializeComponent();
        }
        public event EventHandler compressStart = null;
        private void compressButton_Click(object sender, RoutedEventArgs e)
        {
            compressStart.Invoke(sender, e);
        }
    }
}
