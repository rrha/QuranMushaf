using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace src
{
    public partial class MainWindow : Window
    {
        int counter = 1;
        string addOnString = "00";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckCounter()
        {
            if (counter >= 1 && counter <= 9)
            {
                addOnString = "00";
            }
            else if (counter >= 10 && counter <= 99)
            {
                addOnString = "0";
            }
            else if (counter >= 100)
            {
                addOnString = "";
            }
        }
        private void ForwardBtn(object sender, RoutedEventArgs e)
        {
            CheckCounter();
            if (counter < 604)
            {
                counter += 1;
            }
            PageImage.Source = new BitmapImage(new Uri(@"pages/" + "page" + addOnString + counter.ToString() + ".png", UriKind.Relative));
        }

        private void BackwardBtn(object sender, RoutedEventArgs e)
        {
            CheckCounter();
            if (counter > 1)
            {
                counter -= 1;
            }
            PageImage.Source = new BitmapImage(new Uri(@"pages/" + "page" + addOnString + counter.ToString() + ".png", UriKind.Relative));
        }
    }
}
