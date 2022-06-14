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
    /// Логика взаимодействия для mb2.xaml
    /// </summary>
    public partial class mb2 : Window
    {
        int sch = 0;

        public mb2()
        {
            InitializeComponent();
            counter.Text = (sch + 1) + " / 26";

            img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\001.jpg"));
        }
        private void OpenMB3_Click(object sender, RoutedEventArgs e)
        {
            mb3 gl3 = new mb3();
            this.Close();
            gl3.Show();
        }
        private void n_Click(object sender, RoutedEventArgs e)
        {

            sch--;
            if ((sch <= 25) && (sch >= 0))
            {
                counter.Text = (sch + 1) + " / 26";
            }
            else
            {
                sch = 25;
            }

            switch (sch)
            {

                case 0: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\001.jpg")); break;
                case 1: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\002.jpg")); break;
                case 2: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\003.jpg")); break;
                case 3: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\004.jpg")); break;
                case 4: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\005.jpg")); break;
                case 5: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\006.jpg")); break;
                case 6: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\007.jpg")); break;
                case 7: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\008.jpg")); break;
                case 8: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\009.jpg")); break;
                case 9: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\010.jpg")); break;
                case 10: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\011.jpg")); break;
                case 11: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\012.jpg")); break;
                case 12: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\013.jpg")); break;
                case 13: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\014.jpg")); break;
                case 14: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\015.jpg")); break;
                case 15: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\016.jpg")); break;
                case 16: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\017.jpg")); break;
                case 17: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\018.jpg")); break;
                case 18: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\019.jpg")); break;
                case 19: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\020.jpg")); break;
                case 20: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\021.jpg")); break;
                case 21: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\022.jpg")); break;
                case 22: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\023.jpg")); break;
                case 23: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\024.jpg")); break;
                case 24: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\025.jpg")); break;
                case 25: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\026.jpg")); break;

            }
        }
        private void v_Click(object sender, RoutedEventArgs e)
        {
            sch++;
            if ((sch <= 25) && (sch >= 0))
            {
                counter.Text = (sch + 1) + " / 26";
            }
            else
            {
                sch = 25;
            }
            if (sch >= 25)
            {
                myPopup.IsOpen = true;
            }
            switch (sch)
            {
                case 0: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\001.jpg")); break;
                case 1: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\002.jpg")); break;
                case 2: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\003.jpg")); break;
                case 3: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\004.jpg")); break;
                case 4: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\005.jpg")); break;
                case 5: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\006.jpg")); break;
                case 6: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\007.jpg")); break;
                case 7: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\008.jpg")); break;
                case 8: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\009.jpg")); break;
                case 9: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\010.jpg")); break;
                case 10: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\011.jpg")); break;
                case 11: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\012.jpg")); break;
                case 12: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\013.jpg")); break;
                case 13: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\014.jpg")); break;
                case 14: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\015.jpg")); break;
                case 15: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\016.jpg")); break;
                case 16: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\017.jpg")); break;
                case 17: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\018.jpg")); break;
                case 18: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\019.jpg")); break;
                case 19: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\020.jpg")); break;
                case 20: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\021.jpg")); break;
                case 21: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\022.jpg")); break;
                case 22: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\023.jpg")); break;
                case 23: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\024.jpg")); break;
                case 24: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\025.jpg")); break;
                case 25: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\gl2\026.jpg")); break;
            }

        }
    }
}
