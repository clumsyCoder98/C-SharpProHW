using System;
using System.Windows;

namespace Task3MVP
{
    class Presenter
    {
        MainWindow view = null;
        Model model = null;
        SearchWindow viewSearch = null;
        ReadWindow viewRead = null;
        CompressWindow viewCompress = null;
        public Presenter(MainWindow mainWindow)
        {
            view = mainWindow;
            model = new Model();
            view.searchAct += mainWindow_Search;
            view.readAct += mainWindow_Read;
            view.compressAct += mainWindow_Compress;
        }
        void mainWindow_Search(object sender, EventArgs e)
        {
            string name = view.textInput.Text;
            viewSearch = new SearchWindow();
            viewSearch.Owner = view;
            viewSearch.Show();
            viewSearch.resultOutput.Text=model.SearchFile(name);
        }
        void mainWindow_Read(object sender, EventArgs e)
        {
            viewRead = new ReadWindow();
            viewRead.Owner = view;
            viewRead.Show();
            viewRead.openRead_act += readWindow_Read;
        }
        void mainWindow_Compress(object sender, EventArgs e)
        {
            viewCompress = new CompressWindow();
            viewCompress.Owner = view;
            viewCompress.Show();
            viewCompress.compressStart += compressWindow_Comp;
        }
        void readWindow_Read (object sender, EventArgs e)
        {
            string input = viewRead.AdressInput.Text;
            viewRead.FileOutput.Text = model.ShowContent(input);
        }
        void compressWindow_Comp(object sender, EventArgs e)
        {
            string input = viewCompress.adressInput.Text;
            model.CreateZip(input);
            MessageBox.Show("Zip created!");
        }
    }
}
