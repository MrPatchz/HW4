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

namespace Part1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Weight_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight = double.Parse(Weight.Text);
            double height = double.Parse(Height.Text);

            double BMI = (weight * 720) / Math.Pow(height, 2);

            if (BMI < 15){
                bodyMass.Text = "Your BMI is too low. Your BMI is " + BMI;
                TempCanvas.Background = Brushes.Blue;
            }
            else if (BMI >= 15 && BMI <= 26) {
                bodyMass.Text = "Your BMI is in range " + BMI;
                TempCanvas.Background = Brushes.Green;
            }
            else{
                bodyMass.Text = "Your BMI is too high " + BMI;
                TempCanvas.Background = Brushes.Yellow;
            }

        } 
    }
}
