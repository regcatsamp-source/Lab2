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
                // Подключаем светлую тему при запуске
                ApplyTheme("LightTheme");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки темы при старте: {ex.Message}",
                                "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Подключает тему по имени XAML файла в корне проекта.
        /// </summary>
        public static void ApplyTheme(string themeName)
        {
            try
            {
                string uri = $"/{themeName}.xaml"; // темы лежат в корне проекта
                var themeDict = new ResourceDictionary
                {
                    Source = new Uri(uri, UriKind.Relative)
                };

                Current.Resources.MergedDictionaries.Clear();
                Current.Resources.MergedDictionaries.Add(themeDict);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось применить тему: {ex.Message}",
                                "Ошибка применения темы", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
