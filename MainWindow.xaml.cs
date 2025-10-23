using System;
using System.Windows;

namespace Lab2
{
    public partial class MainWindow : Window
    {
        Formula f = new Formula();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = 0, b = 0, c = 0, x = 0, y = 0;

            if (tbA.Text != "") a = double.Parse(tbA.Text);
            if (tbB.Text != "") b = double.Parse(tbB.Text);
            if (tbC.Text != "") c = double.Parse(tbC.Text);
            if (tbX.Text != "") x = double.Parse(tbX.Text);

            if (rb1.IsChecked == true) y = f.Formula1(a, b, x);
            if (rb2.IsChecked == true) y = f.Formula2(a, b, c, x);
            if (rb3.IsChecked == true) y = f.Formula3(a, x);
            if (rb4.IsChecked == true) y = f.Formula4(a, x);
            if (rb5.IsChecked == true) y = f.Variant2(a, b, c, x);

            tbRes.Text = "Результат: " + y.ToString("F3");
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            tbA.Text = "";
            tbB.Text = "";
            tbC.Text = "";
            tbX.Text = "";
            tbRes.Text = "";
        }
    }
}