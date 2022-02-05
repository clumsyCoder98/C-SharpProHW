using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradedReflector
{
    class Presenter
    {
        MainWindow view = null;
        FileOverview viewFile = null;
        Model model = null;

        public Presenter(MainWindow mainWindow)
        {
            view = mainWindow;
            model = new Model();
            view.FileClick += view_FileClick;
            view.OpenClick += view_OpenClick;
        }

        public void view_FileClick (object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                view.FilePath.Text = dialog.FileName;

            }
        }

        public void view_OpenClick(object sender, EventArgs e)
        {
            if(view.FilePath.Text != null)
            {
                string path = view.FilePath.Text;
                viewFile = new FileOverview();
                viewFile.Show();
                try
                {
                    model.LoadAssembly(path);
                    viewFile.FileText.Text += $"Assembly: {path} was successfully loaded!" + Environment.NewLine + Environment.NewLine;
                }
                catch (FileNotFoundException ex)
                {
                    viewFile.FileText.Text += ex.Message;
                }

                viewFile.FileText.Text += model.ShowTypes();

                if (view.MethodCheck.IsChecked == true)
                {
                    viewFile.FileText.Text += model.ShowMethods();
                }
                if (view.PropCheck.IsChecked == true)
                {
                    viewFile.FileText.Text += model.ShowProperties();
                }
                if (view.FieldsCheck.IsChecked == true)
                {
                    viewFile.FileText.Text += model.ShowFields();
                }
                if (view.AttributesCheck.IsChecked == true)
                {
                    viewFile.FileText.Text += model.ShowAttributes();
                }
            }
        }
    }
}
