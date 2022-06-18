using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Manga
{
    /// <summary>
    /// Логика взаимодействия для description.xaml
    /// </summary>
    public partial class description : Window
    {
        public description()
        {
            InitializeComponent();
            main.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\design\1.jpg"));
            VK.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\icon\vk.png"));
        }
        private void X_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://com-x.life/main") { UseShellExecute = true });
        }
        private void WButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://vk.com/tomelovich") { UseShellExecute = true });
        }
        private void Gmail_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("tomelovichs@gmail.com") { UseShellExecute = true });
        }
        private void OpenMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}
