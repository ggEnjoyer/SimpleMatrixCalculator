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

namespace MatrixCalculator1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Matrix1.ColumnDefinitions.Add(new ColumnDefinition());
            Matrix1.ColumnDefinitions.Add(new ColumnDefinition());
            Matrix1.ColumnDefinitions.Add(new ColumnDefinition());
            Matrix1.RowDefinitions.Add(new RowDefinition());
            Matrix1.RowDefinitions.Add(new RowDefinition());

            var myUserControl = new TextBox();
            Matrix1.Children.Add(myUserControl);
            Grid.SetRow(myUserControl, 1);
        }
    }
}
