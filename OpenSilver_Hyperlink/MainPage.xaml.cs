using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilver_Hyperlink
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var stopwatch = Stopwatch.StartNew();
            if (int.TryParse(CountTextBox.Text, out int count))
            {
                var items = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    items.Add($"HyperlinkButton {i}");
                }
                DefaultItems.ItemsSource = items;
            }
            stopwatch.Stop();
            Time1.Text = $"{stopwatch.ElapsedMilliseconds}ms";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var stopwatch = Stopwatch.StartNew();
            if (int.TryParse(CountTextBox.Text, out int count))
            {
                var items = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    items.Add($"HyperlinkButton {i}");
                }
                SimplifiedItems.ItemsSource = items;
            }
            stopwatch.Stop();
            Time2.Text = $"{stopwatch.ElapsedMilliseconds}ms";
        }
    }
}
