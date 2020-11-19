using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace src
{
    public partial class MainWindow : Window
    {
        int counter = 1;
        string addOnString;

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
            if (counter < 604){counter += 1;}
            CheckCounter();
            PageImage.Source = new BitmapImage(new Uri(@"pages/" + "page" + addOnString + counter.ToString() + ".png", UriKind.Relative));
        }
        private void BackwardBtn(object sender, RoutedEventArgs e)
        {
            if (counter > 1){counter -= 1;}
            CheckCounter();
            PageImage.Source = new BitmapImage(new Uri(@"pages/" + "page" + addOnString + counter.ToString() + ".png", UriKind.Relative));
        }
        private void Btn1(object sender, RoutedEventArgs e)
        {
            counter = 1;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page001.png", UriKind.Relative));
        }
        private void Btn2(object sender, RoutedEventArgs e)
        {
            counter = 2;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page002.png", UriKind.Relative));
        }
        private void Btn3(object sender, RoutedEventArgs e)
        {
            counter = 50;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page050.png", UriKind.Relative));
        }
        private void Btn4(object sender, RoutedEventArgs e)
        {
            counter = 76;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page076.png", UriKind.Relative));
        }
        private void Btn5(object sender, RoutedEventArgs e)
        {
            counter = 106;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page106.png", UriKind.Relative));
        }
        private void Btn6(object sender, RoutedEventArgs e)
        {
            counter = 128;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page128.png", UriKind.Relative));
        }
        private void Btn7(object sender, RoutedEventArgs e)
        {
            counter = 151;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page151.png", UriKind.Relative));
        }
        private void Btn8(object sender, RoutedEventArgs e)
        {
            counter = 177;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page177.png", UriKind.Relative));
        }
        private void Btn9(object sender, RoutedEventArgs e)
        {
            counter = 187;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page187.png", UriKind.Relative));
        }
        private void Btn10(object sender, RoutedEventArgs e)
        {
            counter = 207;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page207.png", UriKind.Relative));
        }
        private void Btn11(object sender, RoutedEventArgs e)
        {
            counter = 221;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page221.png", UriKind.Relative));
        }
        private void Btn12(object sender, RoutedEventArgs e)
        {
            counter = 235;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page235.png", UriKind.Relative));
        }
        private void Btn13(object sender, RoutedEventArgs e)
        {
            counter = 249;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page249.png", UriKind.Relative));
        }
        private void Btn14(object sender, RoutedEventArgs e)
        {
            counter = 255;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page255.png", UriKind.Relative));
        }
        private void Btn15(object sender, RoutedEventArgs e)
        {
            counter = 262;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page262.png", UriKind.Relative));
        }
        private void Btn16(object sender, RoutedEventArgs e)
        {
            counter = 267;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page267.png", UriKind.Relative));
        }
        private void Btn17(object sender, RoutedEventArgs e)
        {
            counter = 282;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page282.png", UriKind.Relative));
        }
        private void Btn18(object sender, RoutedEventArgs e)
        {
            counter = 293;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page293.png", UriKind.Relative));
        }
        private void Btn19(object sender, RoutedEventArgs e)
        {
            counter = 305;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page305.png", UriKind.Relative));
        }
        private void Btn20(object sender, RoutedEventArgs e)
        {
            counter = 312;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page312.png", UriKind.Relative));
        }
        private void Btn21(object sender, RoutedEventArgs e)
        {
            counter = 322;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page322.png", UriKind.Relative));
        }
        private void Btn22(object sender, RoutedEventArgs e)
        {
            counter = 331;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page331.png", UriKind.Relative));
        }
        private void Btn23(object sender, RoutedEventArgs e)
        {
            counter = 341;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page341.png", UriKind.Relative));
        }
        private void Btn24(object sender, RoutedEventArgs e)
        {
            counter = 349;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page349.png", UriKind.Relative));
        }
        private void Btn25(object sender, RoutedEventArgs e)
        {
            counter = 359;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page359.png", UriKind.Relative));
        }
        private void Btn26(object sender, RoutedEventArgs e)
        {
            counter = 366;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page366.png", UriKind.Relative));
        }
        private void Btn27(object sender, RoutedEventArgs e)
        {
            counter = 376;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page376.png", UriKind.Relative));
        }
        private void Btn28(object sender, RoutedEventArgs e)
        {
            counter = 385;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page385.png", UriKind.Relative));
        }
        private void Btn29(object sender, RoutedEventArgs e)
        {
            counter = 396;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page396.png", UriKind.Relative));
        }
        private void Btn30(object sender, RoutedEventArgs e)
        {
            counter = 404;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page404.png", UriKind.Relative));
        }
        private void Btn31(object sender, RoutedEventArgs e)
        {
            counter = 411;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page411.png", UriKind.Relative));
        }
        private void Btn32(object sender, RoutedEventArgs e)
        {
            counter = 414;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page414.png", UriKind.Relative));
        }
        private void Btn33(object sender, RoutedEventArgs e)
        {
            counter = 417;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page417.png", UriKind.Relative));
        }
        private void Btn34(object sender, RoutedEventArgs e)
        {
            counter = 428;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page428.png", UriKind.Relative));
        }
        private void Btn35(object sender, RoutedEventArgs e)
        {
            counter = 434;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page434.png", UriKind.Relative));
        }
        private void Btn36(object sender, RoutedEventArgs e)
        {
            counter = 440;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page440.png", UriKind.Relative));
        }
        private void Btn37(object sender, RoutedEventArgs e)
        {
            counter = 445;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page445.png", UriKind.Relative));
        }
        private void Btn38(object sender, RoutedEventArgs e)
        {
            counter = 452;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page452.png", UriKind.Relative));
        }
        private void Btn39(object sender, RoutedEventArgs e)
        {
            counter = 458;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page458.png", UriKind.Relative));
        }
        private void Btn40(object sender, RoutedEventArgs e)
        {
            counter = 467;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page467.png", UriKind.Relative));
        }
        private void Btn41(object sender, RoutedEventArgs e)
        {
            counter = 477;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page477.png", UriKind.Relative));
        }
        private void Btn42(object sender, RoutedEventArgs e)
        {
            counter = 483;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page483.png", UriKind.Relative));
        }
        private void Btn43(object sender, RoutedEventArgs e)
        {
            counter = 489;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page489.png", UriKind.Relative));
        }
        private void Btn44(object sender, RoutedEventArgs e)
        {
            counter = 496;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page496.png", UriKind.Relative));
        }
        private void Btn45(object sender, RoutedEventArgs e)
        {
            counter = 498;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page498.png", UriKind.Relative));
        }
        private void Btn46(object sender, RoutedEventArgs e)
        {
            counter = 502;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page502.png", UriKind.Relative));
        }
        private void Btn47(object sender, RoutedEventArgs e)
        {
            counter = 506;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page506.png", UriKind.Relative));
        }
        private void Btn48(object sender, RoutedEventArgs e)
        {
            counter = 511;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page511.png", UriKind.Relative));
        }
        private void Btn49(object sender, RoutedEventArgs e)
        {
            counter = 515;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page515.png", UriKind.Relative));
        }
        private void Btn50(object sender, RoutedEventArgs e)
        {
            counter = 518;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page518.png", UriKind.Relative));
        }
        private void Btn51(object sender, RoutedEventArgs e)
        {
            counter = 520;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page520.png", UriKind.Relative));
        }
        private void Btn52(object sender, RoutedEventArgs e)
        {
            counter = 523;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page523.png", UriKind.Relative));
        }
        private void Btn53(object sender, RoutedEventArgs e)
        {
            counter = 525;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page525.png", UriKind.Relative));
        }
        private void Btn54(object sender, RoutedEventArgs e)
        {
            counter = 528;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page528.png", UriKind.Relative));
        }
        private void Btn55(object sender, RoutedEventArgs e)
        {
            counter = 531;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page531.png", UriKind.Relative));
        }
        private void Btn56(object sender, RoutedEventArgs e)
        {
            counter = 534;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page534.png", UriKind.Relative));
        }
        private void Btn57(object sender, RoutedEventArgs e)
        {
            counter = 537;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page537.png", UriKind.Relative));
        }
        private void Btn58(object sender, RoutedEventArgs e)
        {
            counter = 542;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page542.png", UriKind.Relative));
        }
        private void Btn59(object sender, RoutedEventArgs e)
        {
            counter = 545;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page545.png", UriKind.Relative));
        }
        private void Btn60(object sender, RoutedEventArgs e)
        {
            counter = 548;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page548.png", UriKind.Relative));
        }
        private void Btn61(object sender, RoutedEventArgs e)
        {
            counter = 551;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page551.png", UriKind.Relative));
        }
        private void Btn62(object sender, RoutedEventArgs e)
        {
            counter = 553;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page553.png", UriKind.Relative));
        }
        private void Btn63(object sender, RoutedEventArgs e)
        {
            counter = 554;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page554.png", UriKind.Relative));
        }
        private void Btn64(object sender, RoutedEventArgs e)
        {
            counter = 555;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page555.png", UriKind.Relative));
        }
        private void Btn65(object sender, RoutedEventArgs e)
        {
            counter = 557;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page557.png", UriKind.Relative));
        }
        private void Btn66(object sender, RoutedEventArgs e)
        {
            counter = 560;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page560.png", UriKind.Relative));
        }
        private void Btn67(object sender, RoutedEventArgs e)
        {
            counter = 562;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page562.png", UriKind.Relative));
        }
        private void Btn68(object sender, RoutedEventArgs e)
        {
            counter = 564;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page564.png", UriKind.Relative));
        }
        private void Btn69(object sender, RoutedEventArgs e)
        {
            counter = 566;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page566.png", UriKind.Relative));
        }
        private void Btn70(object sender, RoutedEventArgs e)
        {
            counter = 568;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page568.png", UriKind.Relative));
        }
        private void Btn71(object sender, RoutedEventArgs e)
        {
            counter = 570;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page570.png", UriKind.Relative));
        }
        private void Btn72(object sender, RoutedEventArgs e)
        {
            counter = 572;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page572.png", UriKind.Relative));
        }
        private void Btn73(object sender, RoutedEventArgs e)
        {
            counter = 574;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page574.png", UriKind.Relative));
        }
        private void Btn74(object sender, RoutedEventArgs e)
        {
            counter = 575;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page575.png", UriKind.Relative));
        }
        private void Btn75(object sender, RoutedEventArgs e)
        {
            counter = 577;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page577.png", UriKind.Relative));
        }
        private void Btn76(object sender, RoutedEventArgs e)
        {
            counter = 578;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page578.png", UriKind.Relative));
        }
        private void Btn77(object sender, RoutedEventArgs e)
        {
            counter = 580;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page580.png", UriKind.Relative));
        }
        private void Btn78(object sender, RoutedEventArgs e)
        {
            counter = 582;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page582.png", UriKind.Relative));
        }
        private void Btn79(object sender, RoutedEventArgs e)
        {
            counter = 583;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page583.png", UriKind.Relative));
        }
        private void Btn80(object sender, RoutedEventArgs e)
        {
            counter = 584;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page584.png", UriKind.Relative));
        }
        private void Btn81(object sender, RoutedEventArgs e)
        {
            counter = 586;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page586.png", UriKind.Relative));
        }
        private void Btn82(object sender, RoutedEventArgs e)
        {
            counter = 586;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page586.png", UriKind.Relative));
        }
        private void Btn83(object sender, RoutedEventArgs e)
        {
            counter = 587;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page587.png", UriKind.Relative));
        }
        private void Btn84(object sender, RoutedEventArgs e)
        {
            counter = 589;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page589.png", UriKind.Relative));
        }
        private void Btn85(object sender, RoutedEventArgs e)
        {
            counter = 590;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page590.png", UriKind.Relative));
        }
        private void Btn86(object sender, RoutedEventArgs e)
        {
            counter = 590;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page590.png", UriKind.Relative));
        }
        private void Btn87(object sender, RoutedEventArgs e)
        {
            counter = 591;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page591.png", UriKind.Relative));
        }
        private void Btn88(object sender, RoutedEventArgs e)
        {
            counter = 592;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page592.png", UriKind.Relative));
        }
        private void Btn89(object sender, RoutedEventArgs e)
        {
            counter = 593;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page593.png", UriKind.Relative));
        }
        private void Btn90(object sender, RoutedEventArgs e)
        {
            counter = 594;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page594.png", UriKind.Relative));
        }
        private void Btn91(object sender, RoutedEventArgs e)
        {
            counter = 594;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page594.png", UriKind.Relative));
        }
        private void Btn92(object sender, RoutedEventArgs e)
        {
            counter = 595;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page595.png", UriKind.Relative));
        }
        private void Btn93(object sender, RoutedEventArgs e)
        {
            counter = 596;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page596.png", UriKind.Relative));
        }
        private void Btn94(object sender, RoutedEventArgs e)
        {
            counter = 596;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page596.png", UriKind.Relative));
        }
        private void Btn95(object sender, RoutedEventArgs e)
        {
            counter = 597;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page597.png", UriKind.Relative));
        }
        private void Btn96(object sender, RoutedEventArgs e)
        {
            counter = 597;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page597.png", UriKind.Relative));
        }
        private void Btn97(object sender, RoutedEventArgs e)
        {
            counter = 598;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page598.png", UriKind.Relative));
        }
        private void Btn98(object sender, RoutedEventArgs e)
        {
            counter = 598;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page598.png", UriKind.Relative));
        }
        private void Btn99(object sender, RoutedEventArgs e)
        {
            counter = 599;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page599.png", UriKind.Relative));
        }
        private void Btn100(object sender, RoutedEventArgs e)
        {
            counter = 599;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page599.png", UriKind.Relative));
        }
        private void Btn101(object sender, RoutedEventArgs e)
        {
            counter = 600;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page600.png", UriKind.Relative));
        }
        private void Btn102(object sender, RoutedEventArgs e)
        {
            counter = 600;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page600.png", UriKind.Relative));
        }
        private void Btn103(object sender, RoutedEventArgs e)
        {
            counter = 601;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page601.png", UriKind.Relative));
        }
        private void Btn104(object sender, RoutedEventArgs e)
        {
            counter = 601;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page601.png", UriKind.Relative));
        }
        private void Btn105(object sender, RoutedEventArgs e)
        {
            counter = 601;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page601.png", UriKind.Relative));
        }
        private void Btn106(object sender, RoutedEventArgs e)
        {
            counter = 602;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page602.png", UriKind.Relative));
        }
        private void Btn107(object sender, RoutedEventArgs e)
        {
            counter = 602;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page602.png", UriKind.Relative));
        }
        private void Btn108(object sender, RoutedEventArgs e)
        {
            counter = 602;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page602.png", UriKind.Relative));
        }
        private void Btn109(object sender, RoutedEventArgs e)
        {
            counter = 603;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page603.png", UriKind.Relative));
        }
        private void Btn110(object sender, RoutedEventArgs e)
        {
            counter = 603;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page603.png", UriKind.Relative));
        }
        private void Btn111(object sender, RoutedEventArgs e)
        {
            counter = 603;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page603.png", UriKind.Relative));
        }
        private void Btn112(object sender, RoutedEventArgs e)
        {
            counter = 604;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page604.png", UriKind.Relative));
        }
        private void Btn113(object sender, RoutedEventArgs e)
        {
            counter = 604;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page604.png", UriKind.Relative));
        }
        private void Btn114(object sender, RoutedEventArgs e)
        {
            counter = 604;
            PageImage.Source = new BitmapImage(new Uri(@"pages/page604.png", UriKind.Relative));
        }
    }
}
