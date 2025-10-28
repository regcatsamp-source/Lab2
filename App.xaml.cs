using System;
using System.Windows;

namespace Lab2
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                // ���������� ������� ���� ��� �������
                ApplyTheme("LightTheme");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �������� ���� ��� ������: {ex.Message}",
                                "������", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// ���������� ���� �� ����� XAML ����� � ����� �������.
        /// </summary>
        public static void ApplyTheme(string themeName)
        {
            try
            {
                string uri = $"/{themeName}.xaml"; // ���� ����� � ����� �������
                var themeDict = new ResourceDictionary
                {
                    Source = new Uri(uri, UriKind.Relative)
                };

                Current.Resources.MergedDictionaries.Clear();
                Current.Resources.MergedDictionaries.Add(themeDict);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�� ������� ��������� ����: {ex.Message}",
                                "������ ���������� ����", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
