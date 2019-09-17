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
using System.Data.SqlClient;

namespace OlineCinema
{
    /// <summary>
    /// Логика взаимодействия для Регистрация.xaml
    /// </summary>
    public partial class Регистрация : Window
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FirstNameTB.Text != "" || EmailTB.Text != "" || PhoneTB.Text != "" ||
            LoginTB.Text != "" || PasswordTB.Password != "" || RepPasswordTB.Password != "")
            {
                if (PasswordTB.Password == RepPasswordTB.Password)
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
                        string query = $"INSERT INTO [Пользователь] Values('{LoginTB.Text}', '{PasswordTB.Password}', '{EmailTB.Text}', '{PhoneTB.Text}', 0, 0, '{LastNameTB.Text}', '{FirstNameTB.Text}', '{MiddleNameTB.Text}')";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Регистрация прошла успешно!");
                        LastNameTB.Clear();
                        FirstNameTB.Clear();
                        MiddleNameTB.Clear();
                        EmailTB.Clear();
                        PhoneTB.Clear();
                        LoginTB.Clear();
                        PasswordTB.Clear();
                        RepPasswordTB.Clear();
                    }
                }
                else MessageBox.Show("Пароли не свопадают!");
            }
            else MessageBox.Show("Есть незаполненные поля!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow log = new MainWindow();
            log.Show();
            Close();
        }
    }
}
