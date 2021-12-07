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

namespace Practice_6_Bengardt
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
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            Pair firstP = new Pair(int.Parse(FIRSTP1.Text), int.Parse(SECONDP1.Text));
            Pair secondP = new Pair(int.Parse(FIRSTP2.Text), int.Parse(SECONDP2.Text));
            Pair resultP = firstP.Substract(secondP);
            result.Text = (resultP.First, resultP.Second).ToString();
        }

        private void ComparisonPair_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(int.Parse(FIRSTP1.Text), int.Parse(SECONDP1.Text));
            result.Text = pair ? "true" : "false";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
