﻿using System;
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
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        public Catalog()
        {
            InitializeComponent();
           
            parasite.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\parazite.jpg"));
            mbattle.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\mbattle.jpg"));
            naruto.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\naruto.jpg"));
            dragon.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\dragon.jpg"));
            paint.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\paint.jpg"));
            skale.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\skale.jpg"));
            alice.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\alice.jpg"));
            jojo.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\jojo.jpg"));
            kaidi.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\kaidi.jpg"));
            teacher.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\teacher.jpg"));
            oneForFlight.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\oneForFlight.jpg"));
            onepunch.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\onepunch.jpg"));
            slamdunk.Source = new BitmapImage(new Uri(@"C:\Users\Admin\Desktop\Курсовое проектирование\Manga\Manga\Recources\obl\slamdunk.jpg"));
        }
        private void OpenMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
        private void OpenJOJO(object sender, RoutedEventArgs e)
        {
            Jojo jojo = new Jojo();
            this.Close();
            jojo.Show();
        }
        private void OpenSlamDunk(object sender, RoutedEventArgs e)
        {
            SlamDunk slamDunk = new SlamDunk();
            this.Close();
            slamDunk.Show();
        }
        private void OpenMG(object sender, RoutedEventArgs e)
        {
            MG mBattle = new MG();
            this.Close();
            mBattle.Show();
        }
        private void OpenAL(object sender, RoutedEventArgs e)
        {
            Alice alice = new Alice();
            this.Close();
            alice.Show();
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
