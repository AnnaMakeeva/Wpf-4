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

namespace Wpf_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollor = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollor;
            resSum.Text = resDouble.ToString();

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate1Evro = Convert.ToDouble(rate1.Text);
            double sum1Evro = Convert.ToDouble(sum1.Text);
            double res1Evro = rate1Evro * sum1Evro;
            resSum1.Text = res1Evro.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate2Grivna = Convert.ToDouble(rate2.Text);
            double sum2Grivna = Convert.ToDouble(sum2.Text);
            double res2Grivna = rate2Grivna * sum2Grivna;
            resSum2.Text = res2Grivna.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate3Drama = Convert.ToDouble(rate3.Text);
            double sum3Drama = Convert.ToDouble(sum3.Text);
            double res3Drama = rate3Drama * sum3Drama;
            resSum3.Text = res3Drama.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double distanceInches = Convert.ToDouble(distance.Text); 
            double resInches = distanceInches * 0.0254;
            res.Text = resInches.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double distance1Fut = Convert.ToDouble(distance1.Text);
            double res1Fut = distance1Fut * 0.3048;
            res1.Text = res1Fut.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double distance2Mil = Convert.ToDouble(distance2.Text);
            double res2Mil = distance2Mil * 1609.34;
            res2.Text = res2Mil.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double distance3Verst = Convert.ToDouble(distance3.Text);
            double res3Verst = distance3Verst * 1066.8;
            res3.Text = res3Verst.ToString();
        }
    }
}
