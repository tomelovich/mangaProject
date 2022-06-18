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
    /// Логика взаимодействия для Slam1.xaml
    /// </summary>
    public partial class Slam1 : Window
    {
        int sch = 0;

        public Slam1()
        {
            InitializeComponent();
            counter.Text = (sch + 1) + " / 38";

            img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\001.jpg"));
        }
        private void OpenSlam2_Click(object sender, RoutedEventArgs e)
        {
            Slam2 gl2 = new Slam2();
            this.Close();
            gl2.Show();
        }
        private void n_Click(object sender, RoutedEventArgs e)
        {

            sch--;
            if ((sch <= 37) && (sch >= 0))
            {
                counter.Text = (sch + 1) + " / 38";
            }
            else
            {
                sch = 37;
            }

            switch (sch)
            {

                case 0: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\001.jpg")); break;
                case 1: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\002.jpg")); break;
                case 2: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\003.jpg")); break;
                case 3: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\004.jpg")); break;
                case 4: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\005.jpg")); break;
                case 5: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\006.jpg")); break;
                case 6: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\007.jpg")); break;
                case 7: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\008.jpg")); break;
                case 8: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\009.jpg")); break;
                case 9: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\010.jpg")); break;
                case 10: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\011.jpg")); break;
                case 11: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\012.jpg")); break;
                case 12: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\013.jpg")); break;
                case 13: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\014.jpg")); break;
                case 14: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\015.jpg")); break;
                case 15: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\016.jpg")); break;
                case 16: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\017.jpg")); break;
                case 17: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\018.jpg")); break;
                case 18: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\019.jpg")); break;
                case 19: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\020.jpg")); break;
                case 20: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\021.jpg")); break;
                case 21: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\022.jpg")); break;
                case 22: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\023.jpg")); break;
                case 23: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\024.jpg")); break;
                case 24: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\025.jpg")); break;
                case 25: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\026.jpg")); break;
                case 26: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\027.jpg")); break;
                case 27: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\028.jpg")); break;
                case 28: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\029.jpg")); break;
                case 29: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\030.jpg")); break;
                case 30: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\031.jpg")); break;
                case 31: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\032.jpg")); break;
                case 32: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\033.jpg")); break;
                case 33: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\034.jpg")); break;
                case 34: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\035.jpg")); break;
                case 35: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\036.jpg")); break;
                case 36: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\037.jpg")); break;
                case 37: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\038.jpg")); break;
            }
        }
        private void v_Click(object sender, RoutedEventArgs e)
        {
            sch++;
            if ((sch <= 37) && (sch >= 0))
            {
                counter.Text = (sch + 1) + " / 38";
            }
            else
            {
                sch = 37;
            }
            if (sch >= 37)
            {
                myPopup.IsOpen = true;
            }
            switch (sch)
            {
                case 0: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\001.jpg")); break;
                case 1: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\002.jpg")); break;
                case 2: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\003.jpg")); break;
                case 3: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\004.jpg")); break;
                case 4: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\005.jpg")); break;
                case 5: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\006.jpg")); break;
                case 6: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\007.jpg")); break;
                case 7: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\008.jpg")); break;
                case 8: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\009.jpg")); break;
                case 9: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\010.jpg")); break;
                case 10: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\011.jpg")); break;
                case 11: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\012.jpg")); break;
                case 12: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\013.jpg")); break;
                case 13: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\014.jpg")); break;
                case 14: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\015.jpg")); break;
                case 15: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\016.jpg")); break;
                case 16: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\017.jpg")); break;
                case 17: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\018.jpg")); break;
                case 18: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\019.jpg")); break;
                case 19: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\020.jpg")); break;
                case 20: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\021.jpg")); break;
                case 21: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\022.jpg")); break;
                case 22: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\023.jpg")); break;
                case 23: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\024.jpg")); break;
                case 24: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\025.jpg")); break;
                case 25: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\026.jpg")); break;
                case 26: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\027.jpg")); break;
                case 27: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\028.jpg")); break;
                case 28: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\029.jpg")); break;
                case 29: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\030.jpg")); break;
                case 30: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\031.jpg")); break;
                case 31: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\032.jpg")); break;
                case 32: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\033.jpg")); break;
                case 33: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\034.jpg")); break;
                case 34: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\035.jpg")); break;
                case 35: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\036.jpg")); break;
                case 36: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\037.jpg")); break;
                case 37: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\slam1\038.jpg")); break;
            }
        }
    }
}
