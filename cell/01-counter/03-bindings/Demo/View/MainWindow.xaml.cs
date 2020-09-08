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
        // We upgrade this from field to property
        // This is because bindings only work on properties
        public Cell<int> CounterValue { get; }

        public MainWindow()
        {
            InitializeComponent();

            CounterValue = Cell.Create(0);

            // All code related to updating the view has been replaced by the binding in the XAML

            // The binding in the XAML refers to a CounterValue
            // but whose CounterValue should be used?
            // The DataContext determines where a binding gets its data from
            // In our case, this MainWindow object has the CounterValue
            // We need to tell WPF this explicitly by setting the DataContext
            DataContext = this;
        }

        private void OnIncrease(object sender, RoutedEventArgs e)
        {
            CounterValue.Value++;
        }
    }
}
