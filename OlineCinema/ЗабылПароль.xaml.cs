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

namespace OlineCinema
{
    /// <summary>
    /// Логика взаимодействия для ЗабылПароль.xaml
    /// </summary>
    public partial class ЗабылПароль : Window
    {
        public ЗабылПароль()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow logIn = new MainWindow();
            logIn.Show();
            Close();
        }
    }
}
