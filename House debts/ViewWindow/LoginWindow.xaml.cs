using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace House_debts
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            
                if ((true))//textBoxLogin.Text == Data.rep.Login) && (PasswordBox.Password == Data.rep.Password))
                {
 //                   Data.isAnyDataHere = true;
                    this.Close();
                }
                else
                {
                    this.Opacity = 0.8;
                    ExceptionWindow ew = new ExceptionWindow();
                    ew.Show("Логин/пароль введен неверно");
                    ew.ShowDialog();
                    this.Opacity = 1;
                }
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rectangle2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    }
}
