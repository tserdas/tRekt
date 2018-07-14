using Newtonsoft.Json;
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

namespace tRekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tryclick(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            //GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);
            Grid.SetColumn(GridCursor, index);
            switch(index)
            {
                case 0:
                    dataGrid.Visibility = Visibility.Visible;
                    btn_Download.Visibility = Visibility.Visible;
                    break;
                case 1:
                    dataGrid.Visibility = Visibility.Collapsed;
                    btn_Download.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    dataGrid.Visibility = Visibility.Collapsed;
                    btn_Download.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    dataGrid.Visibility = Visibility.Collapsed;
                    btn_Download.Visibility = Visibility.Collapsed;
                    break;
                case 4:
                    dataGrid.Visibility = Visibility.Collapsed;
                    btn_Download.Visibility = Visibility.Collapsed;
                    break;
                case 5:
                    dataGrid.Visibility = Visibility.Collapsed;
                    btn_Download.Visibility = Visibility.Collapsed;
                    break;
                case 6:
                    dataGrid.Visibility = Visibility.Collapsed;
                    btn_Download.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void btn_close(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_fullscreen(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void btn_download(object sender, RoutedEventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.get();
            List<CryptoInfo> cryptocollection = JsonConvert.DeserializeObject<List<CryptoInfo>>(rClient.GetResult);
            dataGrid.ItemsSource = cryptocollection;            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_contact(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/cryptoaltrader");
        }
    }
}
