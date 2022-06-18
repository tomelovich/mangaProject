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
    /// Логика взаимодействия для Alice.xaml
    /// </summary>
    public partial class Alice : Window
    {
        public Alice()
        {
            InitializeComponent();
            al.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\alice.jpg"));
        }
        private void OpenMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
        private void OpenAL1_Click(object sender, RoutedEventArgs e)
        {
            al1 gl1 = new al1();
            this.Close();
            gl1.Show();
        }
        private void OpenAL2_Click(object sender, RoutedEventArgs e)
        {
            al2 gl2 = new al2();
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
