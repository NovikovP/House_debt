using System;
using System.Collections.Generic;
using System.IO;
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

namespace House_debts
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string FileName = "Database.bin";
        string ExceptionForUser = "Что-то пошло не так. Поробуйте перезапустить программу или свяжитесь с разработчиком: successdca@gmail.com";


        public MainWindow()
        {
            InitializeComponent();

            LoadFromFile();
            LoginWindow lg = new LoginWindow();
            lg.ShowDialog();
        }
        public void LoadFromFile()//Вызывают из файла массив сырого расписания rep
        {
            try
            {
                FileStream fs = new FileStream(FileName, FileMode.Open);
//                rep.DeserializeBinary(fs);
                fs.Close();
            }
            catch
            {
                this.Opacity = 0.8;
                ExceptionWindow ew = new ExceptionWindow();
 //               ew.Show("Проблема при загрузке базы данных" + ExceptionForUser);
                ew.ShowDialog();
                this.Opacity = 1;
            }
        }

        public void SaveInFile()//Сохраняет в файл массив rep
        {
            try
            {
                FileStream fs = new FileStream(FileName, FileMode.Create);
//                rep.SerializeBinary(fs);
                fs.Close();
            }
            catch
            {
                this.Opacity = 0.8;
                ExceptionWindow ew = new ExceptionWindow();
//                ew.Show("Проблема при сохранении базы данных" + ExceptionForUser);
                ew.ShowDialog();
                this.Opacity = 1;
            }
        }

    }
}
