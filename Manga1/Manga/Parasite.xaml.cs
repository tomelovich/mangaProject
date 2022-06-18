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

namespace Manga
{
    /// <summary>
    /// Логика взаимодействия для Parasite.xaml
    /// </summary>
    public partial class Parasite : Window
    {
        public Parasite()
        {
            InitializeComponent();
            parasite.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\parazite.jpg"));
        }
        private void OpenMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
        private void OpenPAR1_Click(object sender, RoutedEventArgs e)
        {
            par1 gl1 = new par1();
            this.Close();
            gl1.Show();
        }
        private void OpenPAR2_Click(object sender, RoutedEventArgs e)
        {
            par2 gl2 = new par2();
            this.Close();
            gl2.Show();
        }
  
        private void OpenCommentMB(object sender, RoutedEventArgs e)
        {
            CommentMB comMB = new CommentMB();
            this.Close();
            comMB.Show();
        }
    }
}
