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

namespace Dojo_VO3
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<GeoObject> Shapes = new List<GeoObject>();

        public MainWindow()
        {
            InitializeComponent();
            cboForm.ItemsSource = new List<string>() {"Rechteck", "Kreis" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Shapes.Add(new GeoObject(
                cboForm.SelectedItem.ToString(), 
                int.Parse(tboPosX.Text), 
                int.Parse(tboPosY.Text), 
                int.Parse(tboHeight.Text), 
                int.Parse(tboWidth.Text)));
            dtgrDataGrid.ItemsSource = null;
            dtgrDataGrid.ItemsSource = Shapes;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var temp = dtgrDataGrid.SelectedItem as GeoObject;
            Shape geoObject = null;

            switch (temp.Shape)
            {
                case "Rechteck":
                    geoObject = new Rectangle()
                    { 
                        Height = temp.Height,
                        Width = temp.Width,
                        Stroke = new SolidColorBrush(Colors.Red),
                        StrokeThickness = 1
                    };

                    break;
                case "Kreis":
                    geoObject = new Ellipse()
                    {
                        Height = temp.Height,
                        Width = temp.Width,
                        Stroke = new SolidColorBrush(Colors.Red),
                        StrokeThickness = 1
                    };
                    break;
                default:
                    break;
            }
            canDrawingArea.Children.Add(geoObject);
            geoObject.SetValue(Canvas.TopProperty, (double)temp.PosY);
            geoObject.SetValue(Canvas.LeftProperty, (double)temp.PosX);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
