using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Convertor
{
    class Presenter
    {
        Model model = null;
        MainWindow view = null;
        public Presenter(MainWindow main)
        {
            view = main;
            model = new Model();
            view.convertAct += mainWindow_Convert;
        }
        void mainWindow_Convert(object sender, EventArgs e)
        {
            string input = view.InTemp.Text;
            object output = model.Convertor(input);
            view.OutTemp.Text = output.ToString();
        }
    }
}

