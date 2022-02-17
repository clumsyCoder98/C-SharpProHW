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
using System.IO;
using System.Xml.Serialization;

namespace Task3
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

        public string path;

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == true)
            {
                path = dialog.FileName;
            }
        }

        private void DeSerializeBtn_Click(object sender, RoutedEventArgs e)
        {
            if(path != null)
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                XmlSerializer deserializer = new XmlSerializer(typeof(XMLtest));
                XMLtest file = (XMLtest)deserializer.Deserialize(stream);
                TextView.Text = file.name + Environment.NewLine + file.surname + Environment.NewLine +
                    file.country + Environment.NewLine + file.overall;
            }

        }
    }
}
