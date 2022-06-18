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

namespace Manga
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            parasite.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\parazite.jpg"));
            mbattle.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\mbattle.jpg"));
            naruto.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\naruto.jpg"));
            dragon.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\dragon.jpg"));
            paint.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\paint.jpg"));
        }
        private void OpenCatalog(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            this.Close();
            catalog.Show();
        }
        private void openMyProfile(object sender, RoutedEventArgs e)
        {
            MyProfile profile = new MyProfile();
            this.Close();
            profile.Show();
        }
        private void OpenDescription(object sender, RoutedEventArgs e)
        {
            description des = new description();
            this.Close();
            des.Show();
        }
        private void OpenMG(object sender, RoutedEventArgs e)
        {
            MG mBattle = new MG();
            this.Close();
            mBattle.Show();
        }
        private void OpenParasite(object sender, RoutedEventArgs e)
        {
            Parasite par = new Parasite();
            this.Close();
            par.Show();
        }
        private void OpenNAR(object sender, RoutedEventArgs e)
        {
            naruto nar = new naruto();
            this.Close();
            nar.Show();
        }

    }
}
