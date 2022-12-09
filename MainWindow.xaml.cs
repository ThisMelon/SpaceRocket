using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Timers;
using System.Diagnostics;

namespace RocketGame
{
        public partial class MainWindow : Window
        { 
        
            public bool Spinning = true;

            public MainWindow()
            {
                InitializeComponent();
            }

            public async void Spin_Click(object sender, RoutedEventArgs e)
            {
                if (Spinning == true)
                {
                    Spinning = false;
                    for (int i = 0; i < 5; i++)
                    {
                        if(i < 4)
                        {
                            Image finalImage = Rocket;
                            BitmapImage logo = new BitmapImage();
                            logo.BeginInit();
                            logo.UriSource = new Uri(@"pack://application:,,,/RocketGame;component/rocket_on_00" + i + ".png");
                            logo.EndInit();
                            finalImage.Source = logo;
                            var t1 = Task.Delay(250);
                            await t1;
                        }
                        else
                        {
                            Image finalImage = Rocket;
                            BitmapImage logo = new BitmapImage();
                            logo.BeginInit();
                            logo.UriSource = new Uri(@"pack://application:,,,/RocketGame;component/rocket_off_000.png");
                            logo.EndInit();
                            finalImage.Source = logo;
                            var t1 = Task.Delay(250);
                            await t1;
                        }
                    }
                    Spinning = true;
                }
            }

            private void Shoot_Click(object sender, RoutedEventArgs e)
            {

            }
    }
}
