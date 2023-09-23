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
using System.Runtime.InteropServices;
namespace collaboration
{
    public partial class MainWindow : Window
    {
        // Импорт с библиотеки user32.dll для взаимодействия с методами MessageBox
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
       // Инициализация самого MessageBox
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        private string name = "Денис";
        private string email = "denis@gmail.com";
        private string information = "Super puper programmer in the WORLD!!!";

        public MainWindow()
        {
            InitializeComponent();
        }

        // Метод вывода с помощью кнопки
        private void ShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxBase messageBoxBase = new MessageBoxBase();
            messageBoxBase.ShowMessageBox(name, email, information);
        }

        // Сам класс где мы реализуем сам вывод информации про пользователя черещ MessageBox
        class MessageBoxBase
        {
            public void ShowMessageBox(string name, string email, string information)
            {
                // Створити повідомлення з інформацією користувача
                string message = $"Name: {name} \nEmail: {email}\nInformation: {information}";

                // Відобразити MessageBox з інформацією про автора
                MessageBox(IntPtr.Zero, message, "For autor", 0x40);
            }
        }
    }
}
