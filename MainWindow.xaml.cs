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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        public MainWindow()
        {
            InitializeComponent();
        }

        class MessageBoxBase
        {
            public void ShowMessageBox(string name, string email, string information)
            {
                // Створити повідомлення з інформацією користувача
                string message = $"Ім'я: {name} \nEmail: {email}\n Дополнительная информаци: {information}";

                // Відобразити MessageBox з інформацією про автора
                MessageBox(IntPtr.Zero, message, "Про автора", 0x40);
            }


        }

    }
}
