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
    /// Логика взаимодействия для MG.xaml
    /// </summary>
    public partial class MG : Window
    {
        public MG()
        {
            InitializeComponent();
            mbattle.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\mbattle.jpg"));
        }
        private void OpenMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
        private void OpenMB1_Click(object sender, RoutedEventArgs e)
        {
            mb1 gl1 = new mb1();
            this.Close();
            gl1.Show();
        }
        private void OpenMB2_Click(object sender, RoutedEventArgs e)
        {
            mb2 gl2 = new mb2();
            this.Close();
            gl2.Show();
        }
        private void OpenMB3_Click(object sender, RoutedEventArgs e)
        {
            mb3 gl3 = new mb3();
            this.Close();
            gl3.Show();
        }
        private void OpenMB4_Click(object sender, RoutedEventArgs e)
        {
            mb4 gl4 = new mb4();
            this.Close();
            gl4.Show();
        }
        
        private void OpenCommentMB(object sender, RoutedEventArgs e)
        {
            CommentMB comMB = new CommentMB();
            this.Close();
            comMB.Show();
        }
    }
}
