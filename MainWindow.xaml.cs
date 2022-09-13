using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using Xceed.Wpf.Toolkit;
using static MatrixCalculator1.CustomGlobalFunctionsAndObjects;

namespace MatrixCalculator1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isFirstStart = true; 
        public MainWindow()
        {
            InitializeComponent();
            Thread.Sleep(5000);
            ChangeSizeOfMatrix1();
            ChangeSizeOfMatrix2();
            ChangeSizeOfMatrixResult();
        }
        void ChangeSizeOfMatrix1()
        {

            try
            {
                Matrix1.ColumnDefinitions.Clear();
                Matrix1.RowDefinitions.Clear();
                Matrix1.Children.Clear();

                int rows = Convert.ToInt32(Matrix1Rows.Value);
                int columns = Convert.ToInt32(Matrix1Columns.Value);

                for (int i = 0; i < rows; i++)
                {
                    Matrix1.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
                }
                for (int j = 0; j < columns; j++)
                {
                    Matrix1.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        //var matrixElement = new IntegerUpDown { AllowTextInput = true, Value = 0 };
                        var matrixElement = new MatrixElement();
                        
                        //matrixElement.Style.Setters.Add(new Setter(IntegerUpDown.ShowButtonSpinnerProperty, false));
                        //matrixElement.Style.Setters.Add(new Setter(PaddingProperty, new Thickness(0, 0, 16, 0)));
                        //matrixElement.Style.Setters.Add(new Setter(WidthProperty, 40));
                        /*
                        var asd = new Trigger()
                        {
                            Property = IntegerUpDown.ShowButtonSpinnerProperty,
                            Value = true
                        };
                        asd.Setters.Add(new Setter(PaddingProperty, new Thickness(0)));
                        asd.Setters.Add(new Setter(IntegerUpDown.ShowButtonSpinnerProperty, true));
                        
                        matrixElement.Style.Triggers.Add(asd);
                        */
                        Matrix1.Children.Add(matrixElement);
                        Grid.SetRow(matrixElement, i);
                        Grid.SetColumn(matrixElement, j);
                    }
                }
            }
            catch (Exception ex)
            {
                //System.Windows.MessageBox.Show(ex.Message);
            }
        }
        void ChangeSizeOfMatrix2()
        {

            try
            {
                Matrix2.ColumnDefinitions.Clear();
                Matrix2.RowDefinitions.Clear();
                Matrix2.Children.Clear();

                int rows = Convert.ToInt32(Matrix1Rows.Value);
                int columns = Convert.ToInt32(Matrix1Columns.Value);

                for (int i = 0; i < rows; i++)
                {
                    Matrix2.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
                }
                for (int j = 0; j < columns; j++)
                {
                    Matrix2.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        //var matrixElement = new IntegerUpDown { AllowTextInput = true, Value = 0 };
                        var matrixElement = new MatrixElement();

                        //matrixElement.Style.Setters.Add(new Setter(IntegerUpDown.ShowButtonSpinnerProperty, false));
                        //matrixElement.Style.Setters.Add(new Setter(PaddingProperty, new Thickness(0, 0, 16, 0)));
                        //matrixElement.Style.Setters.Add(new Setter(WidthProperty, 40));
                        /*
                        var asd = new Trigger()
                        {
                            Property = IntegerUpDown.ShowButtonSpinnerProperty,
                            Value = true
                        };
                        asd.Setters.Add(new Setter(PaddingProperty, new Thickness(0)));
                        asd.Setters.Add(new Setter(IntegerUpDown.ShowButtonSpinnerProperty, true));
                        
                        matrixElement.Style.Triggers.Add(asd);
                        */
                        Matrix2.Children.Add(matrixElement);
                        Grid.SetRow(matrixElement, i);
                        Grid.SetColumn(matrixElement, j);
                    }
                }
            }
            catch (Exception ex)
            {
                //System.Windows.MessageBox.Show(ex.Message);
            }
        }
        private void ChangeSizeOfMatrixResult()
        {

            try
            {
                MatrixResult.ColumnDefinitions.Clear();
                MatrixResult.RowDefinitions.Clear();
                MatrixResult.Children.Clear();

                int rows = Convert.ToInt32(Matrix1Rows.Value);
                int columns = Convert.ToInt32(Matrix1Columns.Value);

                for (int i = 0; i < rows; i++)
                {
                    MatrixResult.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
                }
                for (int j = 0; j < columns; j++)
                {
                    MatrixResult.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        //var matrixElement = new IntegerUpDown { AllowTextInput = true, Value = 0 };
                        var matrixElement = new MatrixElement();

                        //matrixElement.Style.Setters.Add(new Setter(IntegerUpDown.ShowButtonSpinnerProperty, false));
                        //matrixElement.Style.Setters.Add(new Setter(PaddingProperty, new Thickness(0, 0, 16, 0)));
                        //matrixElement.Style.Setters.Add(new Setter(WidthProperty, 40));
                        /*
                        var asd = new Trigger()
                        {
                            Property = IntegerUpDown.ShowButtonSpinnerProperty,
                            Value = true
                        };
                        asd.Setters.Add(new Setter(PaddingProperty, new Thickness(0)));
                        asd.Setters.Add(new Setter(IntegerUpDown.ShowButtonSpinnerProperty, true));
                        
                        matrixElement.Style.Triggers.Add(asd);
                        */
                        MatrixResult.Children.Add(matrixElement);
                        Grid.SetRow(matrixElement, i);
                        Grid.SetColumn(matrixElement, j);
                    }
                }
            }
            catch (Exception ex)
            {
                //System.Windows.MessageBox.Show(ex.Message);
            }
        }
        private void Matrix1Rows_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            ChangeSizeOfMatrix1();
            ChangeSizeOfMatrix2();
            ChangeSizeOfMatrixResult();
        }

        private void Matrix1Columns_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            ChangeSizeOfMatrix1();
            ChangeSizeOfMatrix2();
            ChangeSizeOfMatrixResult();
        }


        private void SumOfMatricesButton_Click(object sender, RoutedEventArgs e)
        {
            int rows = Convert.ToInt32(Matrix1Rows.Value);
            int columns = Convert.ToInt32(Matrix1Columns.Value);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    MatrixElement ME = (MatrixElement)MatrixResult.Children[j + i * columns];
                    MatrixElement M1 = (MatrixElement)Matrix1.Children[j + i * columns];
                    MatrixElement M2 = (MatrixElement)Matrix2.Children[j + i * columns];
                    //ME.ValueHolder.Value;
                    //MatrixResult.Children[j + i * columns] = Matrix1.Children[j + i * columns] + Matrix2.Children[j + i * columns];
                    ((MatrixElement)MatrixResult.Children[j + i * columns]).ValueHolder.Value = M1.ValueHolder.Value + M2.ValueHolder.Value;
                    MatrixResult.Children[j + i * columns].SetValue(IntegerUpDown.ValueProperty, M1.ValueHolder.Value + M2.ValueHolder.Value);
                    DebugMessage(M1.ValueHolder.Value.ToString() + " + " + M2.ValueHolder.Value.ToString() + " = " + (M1.ValueHolder.Value + M2.ValueHolder.Value).ToString());
                }
            }
        }
    }
}
