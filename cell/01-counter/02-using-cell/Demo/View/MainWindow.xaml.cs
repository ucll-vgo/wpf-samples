using Cells;
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
        private readonly Cell<int> counterValue;

        public MainWindow()
        {
            InitializeComponent();

            counterValue = Cell.Create(0);
            UpdateView();

            // ValueChanged is an event that is fired whenever the Cell's content is changed
            // The line below states that whenever this happens, UpdateView should be called
            counterValue.ValueChanged += UpdateView;
        }

        private void OnIncrease(object sender, RoutedEventArgs e)
        {
            counterValue.Value++;
            // No need to call UpdateView() as counterValue will automatically
            // signal it has changed, which triggers a call to UpdateView
        }

        private void UpdateView()
        {
            counterViewer.Text = counterValue.Value.ToString();
        }
    }
}
