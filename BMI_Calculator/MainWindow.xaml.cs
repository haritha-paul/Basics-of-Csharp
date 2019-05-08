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

namespace BMI_Calculator
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
        private void btn_bmi(object sender, RoutedEventArgs e)
        {
            int weight;
            int height;
            

            weight = Convert.ToInt32(Textbox1.Text);
            height = Convert.ToInt32(Textbox2.Text);

            double BMI;

            BMI = weight / Math.Pow(height / 100.0, 2);
            BMI = Math.Round(BMI,2);
            //label6.Content = BMI;

            if(BMI < 18.5)
            {
                label5.Content = BMI + "\n" + "UNDER WEIGHT.!!";


            }
            else if(18.5< BMI && BMI < 24.9)
            {
                label5.Content = BMI + "\n" + "IDEAL";

            }

            else if(BMI > 24.9)
            {
                label4.Content = BMI + "\n" + "OVER WEIGHT..!!";


            }


        }
    }
}
