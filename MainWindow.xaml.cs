using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            // ����������, ����� RadioButton ������, � ������������ ������ �������

            if (Radio1.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R1TextA.Text);
                double f = Convert.ToDouble(R1ComboF.Text);
                this.Title = "�����: " + Math.Sin(f * a).ToString("F");
            }

            if (Radio2.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R2TextA.Text);
                double b = Convert.ToDouble(R2TextB.Text);
                double f = Convert.ToDouble(R2ComboF.Text);
                this.Title = "�����: " + (Math.Cos(f * a) + Math.Sin(f * b)).ToString("F");
            }

            if (Radio3.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R3TextA.Text);
                double b = Convert.ToDouble(R3TextB.Text);
                double c = Convert.ToDouble(R3ComboC.Text);
                double d = Convert.ToDouble(R3ComboD.Text);
                this.Title = "�����: " + (c * a * a + d * b * b).ToString("F");
            }

            if (Radio4.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R4TextA.Text);
                double d = Convert.ToDouble(R4TextD.Text);
                double c = Convert.ToDouble(R4ComboC.Text);
                double res = 1;

                for (int i = 0; i < d; i++)
                    res = res * (c + a) + 1;

                this.Title = "�����: " + res.ToString("F");
            }
        }
    }
}
