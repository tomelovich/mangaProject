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
    /// Логика взаимодействия для par2.xaml
    /// </summary>
    public partial class par2 : Window
    {
        int sch = 0;
        public par2()
        {
            InitializeComponent();
            counter.Text = (sch + 1) + " / 46";
            img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\001.jpg"));
        }
        private void OpenParasite_Click(object sender, RoutedEventArgs e)
        {
            Parasite p = new Parasite();
            this.Close();
            p.Show();
        }
        private void n_Click(object sender, RoutedEventArgs e)
        {
            sch--;
            if ((sch <= 40) && (sch >= 0))
            {
                counter.Text = (sch + 1) + " / 41";
            }
            else
            {
                sch = 40;
            }

            switch (sch)
            {
                case 0: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\001.jpg")); break;
                case 1: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\002.jpg")); break;
                case 2: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\003.jpg")); break;
                case 3: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\004.jpg")); break;
                case 4: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\005.jpg")); break;
                case 5: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\006.jpg")); break;
                case 6: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\007.jpg")); break;
                case 7: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\008.jpg")); break;
                case 8: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\009.jpg")); break;
                case 9: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\010.jpg")); break;
                case 10: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\011.jpg")); break;
                case 11: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\012.jpg")); break;
                case 12: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\013.jpg")); break;
                case 13: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\014.jpg")); break;
                case 14: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\015.jpg")); break;
                case 15: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\016.jpg")); break;
                case 16: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\017.jpg")); break;
                case 17: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\018.jpg")); break;
                case 18: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\019.jpg")); break;
                case 19: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\020.jpg")); break;
                case 20: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\021.jpg")); break;
                case 21: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\022.jpg")); break;
                case 22: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\023.jpg")); break;
                case 23: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\024.jpg")); break;
                case 24: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\025.jpg")); break;
                case 25: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\026.jpg")); break;
                case 26: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\027.jpg")); break;
                case 27: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\028.jpg")); break;
                case 28: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\029.jpg")); break;
                case 29: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\030.jpg")); break;
                case 30: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\031.jpg")); break;
                case 31: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\032.jpg")); break;
                case 32: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\033.jpg")); break;
                case 33: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\034.jpg")); break;
                case 34: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\035.jpg")); break;
                case 35: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\036.jpg")); break;
                case 36: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\037.jpg")); break;
                case 37: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\038.jpg")); break;
                case 38: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\039.jpg")); break;
                case 39: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\040.jpg")); break;
                case 40: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\041.jpg")); break;
            }
        }
        private void v_Click(object sender, RoutedEventArgs e)
        {
            sch++;
            if ((sch <= 40) && (sch >= 0))
            {
                counter.Text = (sch + 1) + " / 41";
            }
            else
            {
                sch = 40;
            }
            if (sch >= 40)
            {
                myPopup.IsOpen = true;
            }
            switch (sch)
            {
                case 0: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\001.jpg")); break;
                case 1: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\002.jpg")); break;
                case 2: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\003.jpg")); break;
                case 3: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\004.jpg")); break;
                case 4: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\005.jpg")); break;
                case 5: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\006.jpg")); break;
                case 6: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\007.jpg")); break;
                case 7: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\008.jpg")); break;
                case 8: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\009.jpg")); break;
                case 9: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\010.jpg")); break;
                case 10: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\011.jpg")); break;
                case 11: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\012.jpg")); break;
                case 12: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\013.jpg")); break;
                case 13: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\014.jpg")); break;
                case 14: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\015.jpg")); break;
                case 15: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\016.jpg")); break;
                case 16: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\017.jpg")); break;
                case 17: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\018.jpg")); break;
                case 18: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\019.jpg")); break;
                case 19: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\020.jpg")); break;
                case 20: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\021.jpg")); break;
                case 21: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\022.jpg")); break;
                case 22: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\023.jpg")); break;
                case 23: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\024.jpg")); break;
                case 24: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\025.jpg")); break;
                case 25: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\026.jpg")); break;
                case 26: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\027.jpg")); break;
                case 27: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\028.jpg")); break;
                case 28: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\029.jpg")); break;
                case 29: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\030.jpg")); break;
                case 30: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\031.jpg")); break;
                case 31: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\032.jpg")); break;
                case 32: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\033.jpg")); break;
                case 33: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\034.jpg")); break;
                case 34: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\035.jpg")); break;
                case 35: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\036.jpg")); break;
                case 36: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\037.jpg")); break;
                case 37: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\038.jpg")); break;
                case 38: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\039.jpg")); break;
                case 39: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\040.jpg")); break;
                case 40: img.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\parasite2\041.jpg")); break;
            }
        }
    }
}
