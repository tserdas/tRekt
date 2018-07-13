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
            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch(index)
            {
                case 0:
                    GridMain.Background = Brushes.White;
                    break;
                case 1:
                    GridMain.Background = Brushes.SaddleBrown;
                    break;
                case 2:
                    GridMain.Background = Brushes.RosyBrown;
                    break;
                case 3:
                    GridMain.Background = Brushes.SandyBrown;
                    break;
                case 4:
                    GridMain.Background = Brushes.SkyBlue;
                    break;
                case 5:
                    GridMain.Background = Brushes.Snow;
                    break;
                case 6:
                    GridMain.Background = Brushes.SlateGray;
                    break;
            }
        }

        private void btn_close(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
