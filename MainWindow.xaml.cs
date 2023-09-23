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
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        private string name = "";
        private string email = "";
        private string information = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxBase messageBoxBase = new MessageBoxBase();
            messageBoxBase.ShowMessageBox(name, email, information);
        }

        class MessageBoxBase
        {
            public void ShowMessageBox(string name, string email, string information)
            {
                // Створити повідомлення з інформацією користувача
                string message = $"Ім'я: {name} \nEmail: {email}\nДодаткова інформація: {information}";

                // Відобразити MessageBox з інформацією про автора
                MessageBox(IntPtr.Zero, message, "Про автора", 0x40);
            }
        }
    }
}
