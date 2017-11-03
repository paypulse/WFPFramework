using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WPFrameWork
{
    
    public class WPFrameWork
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();

            Uri uri = new Uri("pack://application:,,,/Setting.xml");
            Stream stream = Application.GetResourceStream(uri).Stream;
            Window win = XamlReader.Load(stream) as Window;

            //Event 추가시 
            //win.AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonOnClick));

        }
    }
}
