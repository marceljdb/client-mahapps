using System;
using System.Collections;
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
using MahApps.Metro.Controls;
using MahAppsExample.Telas;

namespace MahAppsExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.AutoGenerateColumns = true;
            dataGrid.ItemsSource = Environment.GetEnvironmentVariables()
                .Cast<DictionaryEntry>().ToList();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
        private MetroWindow testWindow;

        private MetroWindow GetTestWindow()
        {
            if (testWindow != null)
            {
                testWindow.Close();
            }
            testWindow = new MetroWindow() { Owner = this, WindowStartupLocation = WindowStartupLocation.CenterOwner, Title = "Cadastrar OS", Width = 500, Height = 300 };
            testWindow.Closed += (o, args) => testWindow = null;
            return testWindow;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            var w = new OrdemServico();
            //w.Content = new TextBlock() { Text = "", FontSize = 28, FontWeight = FontWeights.Light, VerticalAlignment = VerticalAlignment.Center, HorizontalAlignment = HorizontalAlignment.Center };
            w.BorderThickness = new Thickness(1);
            w.SetResourceReference(MetroWindow.BorderBrushProperty, "AccentColorBrush");
            w.GlowBrush = null;
           // w.HorizontalAlignment = HorizontalAlignment.Center;
            //w.VerticalAlignment = VerticalAlignment.Center;
            w.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            flyMenu.IsOpen = !flyMenu.IsOpen;

       }
    }
}
