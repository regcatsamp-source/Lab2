using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab2
{
    public partial class MainWindow : Window
    {
        private bool isDarkTheme = false; // состояние темы

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;

            try
            {
                // Формула 1
                if (Radio1.IsChecked == true)
                {
                    double a = ParseDouble(R1TextA.Text);
                    double f = ParseDouble(R1ComboF.Text);
                    result = Formula1.Calculate(a, f);
                }

                // Формула 2
                else if (Radio2.IsChecked == true)
                {
                    double a = ParseDouble(R2TextA.Text);
                    double b = ParseDouble(R2TextB.Text);
                    double f = ParseDouble(R2ComboF.Text);
                    result = Formula2.Calculate(a, b, f);
                }

                // Формула 3
                else if (Radio3.IsChecked == true)
                {
                    double a = ParseDouble(R3TextA.Text);
                    double b = ParseDouble(R3TextB.Text);
                    double c = ParseDouble(R3ComboC.Text);
                    double d = ParseDouble(R3ComboD.Text);
                    result = Formula3.Calculate(a, b, c, d);
                }

                // Формула 4
                else if (Radio4.IsChecked == true)
                {
                    double a = ParseDouble(R4TextA.Text);
                    double d = ParseDouble(R4TextD.Text);
                    double c = ParseDouble(R4ComboC.Text);
                    result = Formula4.Calculate(a, c, d);
                }

                // Формула 5
                else if (Radio5.IsChecked == true)
                {
                    double t = ParseDouble(R5TextT.Text);
                    double x = ParseDouble(R5TextX.Text);
                    double f = ParseDouble(R5TextF.Text);
                    double y = ParseDouble(R5TextY.Text);
                    int N = Convert.ToInt32(R5TextN.Text);
                    int K = Convert.ToInt32(R5TextK.Text);

                    result = Formula5.Calculate(t, x, f, y, N, K);
                }

                ResultText.Text = $"Ответ: {result:F4}";
            }
            catch (FormatException)
            {
                ResultText.Text = "Ошибка: введены некорректные данные!";
            }
            catch (Exception ex)
            {
                ResultText.Text = $"Ошибка: {ex.Message}";
            }
        }

        private double ParseDouble(string text)
        {
            return double.Parse(text.Replace(',', '.'), CultureInfo.InvariantCulture);
        }

        // === Переключение темы ===
        private void ChangeTheme_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isDarkTheme = !isDarkTheme;
                string themeName = isDarkTheme ? "DarkTheme" : "LightTheme";

                App.ApplyTheme(themeName); // используем общий метод

                if (sender is Button button)
                    button.Content = isDarkTheme ? "Светлая тема" : "Тёмная тема";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка переключения темы:\n{ex.Message}",
                                "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // === Разрешаем только цифры, запятую и точку в TextBox ===
        private void NumberOnlyInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, @"[0-9.,]");
        }
    }
}
