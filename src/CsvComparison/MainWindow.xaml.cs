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

namespace CsvComparison
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> temp = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            List<string> test = new List<string>();
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");
            test.Add("A");

            StatusGrid.ItemsSource = test;
            testGrid.ItemsSource = test;
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
