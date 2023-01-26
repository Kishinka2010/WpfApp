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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для SelectLanguage.xaml
    /// </summary>
    public partial class SelectLanguage : Window
    {
        public SelectLanguage()
        {
            InitializeComponent();

            mediaElement1.Source = new Uri("C:/Users/Users/source/repos/WpfApp3/WpfApp3/images/1.mp3"); //добавление музыки
            mediaElement1.Play();

            ImageBrush bg = new ImageBrush();

            bg.ImageSource = new BitmapImage(new Uri("C:/Users/Users/source/repos/WpfApp3/WpfApp3/images/back2.png"));

            bg.TileMode = TileMode.Tile;

    
            Menu.Background = bg;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().ShowDialog();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmb.SelectedIndex == 0)
                Properties.Settings.Default.languageCode = "en-US";
            else Properties.Settings.Default.languageCode = "ru-RU";
            Properties.Settings.Default.Save();
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location); //
            Application.Current.Shutdown(); //                                           перезагрузка приложения
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            
            Environment.Exit(0); //выход из приложения
            
        }
    }
}

