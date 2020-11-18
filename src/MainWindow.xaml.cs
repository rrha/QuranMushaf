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
        private void Btn1(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/page001.png", UriKind.Relative));
        }
        private void Btn2(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/page002.png", UriKind.Relative));
        }
        private void Btn3(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn4(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn5(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn6(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn7(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn8(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn9(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn10(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn11(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn12(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn13(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn14(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn15(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn16(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn17(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn18(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn19(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn20(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn21(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn22(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn23(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn24(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn25(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn26(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn27(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn28(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn29(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn30(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn31(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn32(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn33(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn34(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn35(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn36(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn37(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn38(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn39(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn40(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn41(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn42(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn43(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn44(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn45(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn46(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn47(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn48(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn49(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn50(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn51(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn52(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn53(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn54(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn55(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn56(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn57(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn58(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn59(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn60(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn61(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn62(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn63(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn64(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn65(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn66(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn67(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn68(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn69(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn70(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn71(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn72(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn73(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn74(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn75(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn76(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn77(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn78(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn79(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn80(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn81(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn82(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn83(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn84(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn85(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn86(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn87(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn88(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn89(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn90(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn91(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn92(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn93(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn94(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn95(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn96(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn97(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn98(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn99(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn100(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn101(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn102(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn103(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn104(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn105(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn106(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn107(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn108(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn109(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn110(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn111(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn112(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn113(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
        private void Btn114(object sender, RoutedEventArgs e)
        {
            PageImage.Source = new BitmapImage(new Uri(@"pages/.png", UriKind.Relative));
        }
    }
}
