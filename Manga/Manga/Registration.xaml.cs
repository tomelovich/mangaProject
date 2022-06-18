using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Security.Cryptography;

namespace Manga
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
           
        }
        string GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
        private void OpenReg_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            this.Close();
            reg.Show();
        }
            private void Registration_Click(object sender, RoutedEventArgs e)
        {
            if ((name.Text.Length > 15) || (surname.Text.Length > 15) || (password.Password.Length > 32) || (login.Text.Length > 15))
            {
                MessageBox.Show("Превышено кол-во символов!");
                return;
            }
            if ((surname.Text == "") || (name.Text == "") || (login.Text == "") || (password.Password == ""))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (password.Password.Length < 6)
            {
                MessageBox.Show("Пароль должен состоять из 6 и более символов!");
                return;
            }
            if (IsUserExists())
                return;

            
            string hash = GetHashString(password.Password);

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`nick`, `password`, `name`, `country`, `gender`, `info`) VALUES (@nick, @password , @name , @country , @gender , @info)", db.getConnection());
            command.Parameters.Add("@nick", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = hash;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = surname.Text + " "+ name.Text;
            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = countries.Text;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender.Text;
            command.Parameters.Add("@info", MySqlDbType.VarChar).Value = Info.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(" Регистрация прошла успешно.");
                Reg reg = new Reg();
                reg.Show();
                this.Close();
                
            }
            else
                MessageBox.Show(" Вы  не зарегистрированы в системе");

            db.closeConnection();
        }
        public Boolean IsUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `nick` = @uN", db.getConnection());
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Ник занят, введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
