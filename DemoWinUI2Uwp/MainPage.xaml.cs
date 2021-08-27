using Serilog;
using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoWinUI2Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<SolidColorBrush> ColorOptions = new List<SolidColorBrush> {
            new SolidColorBrush(Colors.Magenta),
            new SolidColorBrush(Colors.Black),
            new SolidColorBrush(Colors.Red),
            new SolidColorBrush(Colors.Orange),
            new SolidColorBrush(Colors.Yellow),
            new SolidColorBrush(Colors.Green),
            new SolidColorBrush(Colors.Blue),
            new SolidColorBrush(Colors.Indigo),
            new SolidColorBrush(Colors.Violet),
            new SolidColorBrush(Colors.White)
        };
        private SolidColorBrush CurrentColorBrush = null;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BrushButtonClick(Microsoft.UI.Xaml.Controls.SplitButton sender, Microsoft.UI.Xaml.Controls.SplitButtonClickEventArgs args)
        {
            // When the button part of the split button is clicked,
            // apply the selected color.
            var color = CurrentColorBrush?.Color;
            if (color != null)
            {
                ChangeColor(color.Value);
            }
        }

        private void BrushSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // When the flyout part of the split button is opened and the user selects
            // an option, set their choice as the current color, apply it, then close the flyout.
            CurrentColorBrush = (SolidColorBrush)e.AddedItems[0];
            SelectedColorBorder.Background = CurrentColorBrush;
            ChangeColor(CurrentColorBrush.Color);
            BrushFlyout.Hide();
        }

        private void ChangeColor(Color color)
        {
            // Apply the color to Stride Game
            Log.Information("Change Color to:{Color}", color);
        }


    }
}
