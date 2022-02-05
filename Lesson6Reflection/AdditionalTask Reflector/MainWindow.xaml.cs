using System;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Reflection;


namespace AdditionalTask_Reflector
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

        Assembly assembly = null;

        private void openBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if( fileDialog.ShowDialog() == true)
            {
                string path = fileDialog.FileName;
                try
                {
                    assembly = Assembly.LoadFrom(path);
                    fileOverview.Text += $"Assembly {path} successfully loaded" + Environment.NewLine + Environment.NewLine;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                fileOverview.Text += "List of all types included in: " + assembly.FullName + Environment.NewLine + Environment.NewLine;

                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    fileOverview.Text += $"\t>>>Type: {type.Name.ToString()}" + Environment.NewLine + Environment.NewLine;

                    var methods = type.GetMethods();
                    if (methods != null)
                    {
                        foreach (MethodInfo method in methods)
                        {
                            string methodInfo = $"Method: {method.Name} \n";
                            MethodBody body = method.GetMethodBody();
                            if(body != null)
                            {
                                var byteArray = body.GetILAsByteArray();
                                foreach (var @byte in byteArray)
                                {
                                    methodInfo += @byte + ":";
                                }
                            }
                            fileOverview.Text += methodInfo + Environment.NewLine + Environment.NewLine;
                        }
                    }

                    var properties = type.GetProperties();
                    if (properties != null)
                    {
                        foreach (PropertyInfo property in properties)
                        {
                            string propertyInfo = $"Property: {property.Name}";
                            fileOverview.Text += propertyInfo + Environment.NewLine + Environment.NewLine;
                        }
                    }

                    var fields = type.GetFields();
                    if(fields != null)
                    {
                        foreach(FieldInfo field in fields)
                        {
                            string fieldInfo = $"Field: {field.Name}\n\n";
                            fileOverview.Text += fieldInfo;
                        }
                    }
                }

            }


        }
    }
}
