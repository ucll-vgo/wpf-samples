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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counterValue;

        public MainWindow()
        {
            InitializeComponent();

            counterValue = 0;
            UpdateView();
        }

        private void OnIncrease(object sender, RoutedEventArgs e)
        {
            counterValue++;

            // Since WPF does not know that counterValue was increased,
            // we need to update the view manually
            UpdateView();
        }

        private void UpdateView()
        {
            // Updates the TextBlock so that it shows the counter's current value
            counterViewer.Text = counterValue.ToString();
        }
    }
}
