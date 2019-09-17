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
using System.Data.SqlClient;

namespace OlineCinema
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pass;
            if (LoginTB.Text != "" || PasswordTB.Password != "")
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\OlineCinema\OlineCinema\CinemaDB.mdf;Integrated Security=True"))
                {
                    try
                    {
                       connection.Open();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка соединения с базой данных!");
                        return;
                    }
                    string query = $"SELECT [Пароль] FROM [Пользователь] WHERE [Логин] = '{LoginTB.Text}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    try
                    {
                        pass = command.ExecuteScalar().ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Данного пользователя не существует!");
                        return;
                    }
                    if (pass != PasswordTB.Password)
                        MessageBox.Show("Неверный пароль!");
                    else
                    {
                        Main main = new Main();
                        main.Show();
                        Close();
                    } 
                }
            }
            else MessageBox.Show("Есть незаполненные поля!");
        }

        private void SignInB_Click(object sender, RoutedEventArgs e)
        {
            Регистрация reg = new Регистрация();
            reg.Show();
            Close();
        }

        private void LoginTB_GotFocus(object sender, RoutedEventArgs e)
        {
            LoginTB.Clear();
        }

        private void LoginTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text == "")
                LoginTB.Text = "Логин";
        }

        private void PasswordTB_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordTB.Clear();
        }

        private void PasswordTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTB.Password == "")
                PasswordTB.Password = "Пароль";
        }

        private void DontKnowPassB_Click(object sender, RoutedEventArgs e)
        {
            ЗабылПароль Pass = new ЗабылПароль();
            Pass.Show();
            Close();
        }
    }
}
