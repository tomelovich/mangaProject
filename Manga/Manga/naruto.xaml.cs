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
    /// Логика взаимодействия для naruto.xaml
    /// </summary>
    public partial class naruto : Window
    {
        public naruto()
        {
            InitializeComponent();
            nar.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\naruto.jpg"));
        }
        
        private void OpenMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
        private void OpenNAR1_Click(object sender, RoutedEventArgs e)
        {
            nar1 gl1 = new nar1();
            this.Close();
            gl1.Show();
        }
        private void OpenNAR2_Click(object sender, RoutedEventArgs e)
        {
            nar2 gl2 = new nar2();
            this.Close();
            gl2.Show();
        }
        private void OpenNAR3_Click(object sender, RoutedEventArgs e)
        {
            nar3 gl3 = new nar3();
            this.Close();
            gl3.Show();
        }
        private void OpenNAR4_Click(object sender, RoutedEventArgs e)
        {
            nar4 gl4 = new nar4();
            this.Close();
            gl4.Show();
        }
        private void OpenNAR5_Click(object sender, RoutedEventArgs e)
        {
            nar5 gl5 = new nar5();
            this.Close();
            gl5.Show();
        }
        private void OpenNAR6_Click(object sender, RoutedEventArgs e)
        {
            nar6 gl6= new nar6();
            this.Close();
            gl6.Show();
        }
        private void OpenCommentMB(object sender, RoutedEventArgs e)
        {
            CommentMB comMB = new CommentMB();
            this.Close();
            comMB.Show();
        }
    }
}
